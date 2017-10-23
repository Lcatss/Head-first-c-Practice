using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        public void UpdateCharacters()
        {
            player.Location = game.PlayerLocation;
            if(game.MaxPlayerHitPoints!=0)
                playerHitPoints.Value = 100*game.PlayerHitPoints / game.MaxPlayerHitPoints ;

            List<PictureBox> weaponList = new List<PictureBox>()
            {
                ListBow,ListSword,ListMace,ListBluePotion,ListRedPotion,
            };

            int enemiesShown = 0;


            

            foreach (Enemy enemy in game.Enemies)
            {
                PictureBox picturebox=GetPictureBox(enemy);
                ProgressBar progressBar=GetProgressBar(enemy);
                if (enemy.Alive)
                {
                    picturebox.Location = enemy.Location;
                    picturebox.Visible = true;
                    picturebox.Enabled = true;
                    if(enemy.MaxHitPoints!=0)
                        progressBar.Value = 100*enemy.HitPoints / enemy.MaxHitPoints;
                    enemiesShown++;
                }
                else
                {
                    picturebox.Visible = false;
                    picturebox.Enabled = false;
                    progressBar.Value = 0;
                }
            }



            Control weaponControl = GetPictureBox(game.WeaponInRoom);
            weaponControl.Visible = true;

            if (game.CheckPlayerInventory<Sword>())
                ListSword.Visible = true;
            if (game.CheckPlayerInventory<Bow>())
                ListBow.Visible = true;
            if (game.CheckPlayerInventory<Mace>())
                ListMace.Visible = true;
            if (game.CheckPlayerInventory<BluePotion>())
                ListBluePotion.Visible = true;
            else
                ListBluePotion.Visible = false;
            if (game.CheckPlayerInventory<RedPotion>())
                ListRedPotion.Visible = true;
            else
                ListRedPotion.Visible = false;

            foreach (PictureBox picturebox in weaponList)
                picturebox.BorderStyle = BorderStyle.None;

            if (game.EquippedWeapon != null)
            {

                PictureBox weaponEquipped = GetListPictureBox(game.EquippedWeapon);
                weaponEquipped.BorderStyle = BorderStyle.FixedSingle;
                
            }

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;
           
            if (game.PlayerHitPoints <= 0)//玩家死后
            {
                timer1.Enabled = false;
                MessageBox.Show("You Died");  
                Application.Exit();
            }

            if (enemiesShown < 1)//打倒所有敌人后
            {
                timer1.Enabled = false;
                MessageBox.Show("You have defeated the enemies on this level");
                weaponControl.Visible = false;
                if (!game.NewLevel(random))
                {
                    Application.Exit();
                }
                else
                {
                    timer1.Enabled = true;
                    UpdateCharacters();
                }
            }
        }

        private PictureBox GetPictureBox(Mover mover)
        {
            if (mover is Bat)
                return bat;
            if (mover is Ghost)
                return ghost;
            if (mover is Ghoul)
                return ghoul;
            if (mover is Player)
                return player;
            
            return null;
        }

        private PictureBox GetPictureBox(Weapon weapon)
        {
            if (weapon is Sword)
                return sword;
            if (weapon is Bow)
                return bow;
            if (weapon is Mace)
                return mace;
            if (weapon is BluePotion)
                return bluePotion;
            if (weapon is RedPotion)
                return redPotion;
            return null;
        }

        private PictureBox GetListPictureBox(Weapon weapon)
        {
            if (weapon is Sword)
                return ListSword;
            if (weapon is Bow)
                return ListBow;
            if (weapon is Mace)
                return ListMace;
            if (weapon is BluePotion)
                return ListBluePotion;
            if (weapon is RedPotion)
                return ListRedPotion;
            return null;
        }

        private ProgressBar GetProgressBar(Mover mover)
        {
            if(mover is Player)
                return playerHitPoints;
            if(mover is Bat)
                return batHitPoints;
            if(mover is Ghost)
                return ghostHitPoints;
            if(mover is Ghoul)
                return ghoulHitPoints;
            return null;
        }
            


        private void ListSword_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory<Sword>())
                game.Equip("Sword");
            UpdateCharacters();
        }

        private void ListBow_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory<Bow>())
                game.Equip("Bow");
            UpdateCharacters();
        }

        private void ListMace_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory<Mace>())
                game.Equip("Mace");
            UpdateCharacters();
        }

        private void ListBluePotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory<BluePotion>())
                game.Equip("Blue Potion");
            UpdateCharacters();
        }

        private void ListRedPotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory<RedPotion>())
                game.Equip("Red Potion");
            UpdateCharacters();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //移动
            if(e.KeyCode==Keys.W)
            {
                game.Move(Direction.Up,random);
                UpdateCharacters();
            }
            if (e.KeyCode == Keys.A)
            {
                game.Move(Direction.Left, random);
                UpdateCharacters();
            }
            if (e.KeyCode == Keys.D)
            {
                game.Move(Direction.Right, random);
                UpdateCharacters();
            }
            if (e.KeyCode == Keys.S)
            {
                game.Move(Direction.Down, random);
                UpdateCharacters();
            }

            //攻击
            if (e.KeyCode == Keys.I)
            {
                game.Attack(Direction.Up, random);
                UpdateCharacters();
            }
            if (e.KeyCode == Keys.J)
            {
                game.Attack(Direction.Left, random);
                UpdateCharacters();
            }
            if (e.KeyCode == Keys.K)
            {
                game.Attack(Direction.Down, random);
                UpdateCharacters();
            }
            if (e.KeyCode == Keys.L)
            {
                game.Attack(Direction.Right, random);
                UpdateCharacters();
            }
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Enemy enemy in game.Enemies)
            {
                enemy.Move(random);
            }
            UpdateCharacters();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }












    }
}
