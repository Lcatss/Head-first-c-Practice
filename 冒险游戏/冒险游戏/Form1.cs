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
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    ghoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }

            if (showBat)
                bat.Visible = true;
            else
                bat.Visible = false;
            if (showGhost)
                ghost.Visible = true;
            else 
                ghost.Visible = false;
            if (showGhoul)
                ghoul.Visible = true;
            else
                ghoul.Visible = false;

            sword.Visible = false;
            bow.Visible = false;
            redPotion.Visible = false;
            bluePotion.Visible = false;
            mace.Visible = false;


            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = sword; break;
                case "Bow":
                    weaponControl = bow; break;
                case "Mace":
                    weaponControl = mace; break;
                case "Blue Potion":
                    weaponControl = bluePotion; break;
                case "Red Potion":
                    weaponControl = redPotion; break;
            }
            weaponControl.Visible = true;

            if (game.CheckPlayerInventory("Sword"))
                ListSword.Visible = true;
            if (game.CheckPlayerInventory("Bow"))
                ListBow.Visible = true;
            if (game.CheckPlayerInventory("Mace"))
                ListMace.Visible = true;
            if (game.CheckPlayerInventory("Blue Potion"))
                ListBluePotion.Visible = true;
            else
                ListBluePotion.Visible = false;
            if (game.CheckPlayerInventory("Red Potion"))
                ListRedPotion.Visible = true;
            else
                ListRedPotion.Visible = false;

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;
            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You Died");
                Application.Exit();
            }
            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(random);
                UpdateCharacters();
            }



        }



        private void ListSword_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");
                ListSword.BorderStyle = BorderStyle.FixedSingle;
                ListBow.BorderStyle = BorderStyle.None;
                ListMace.BorderStyle = BorderStyle.None;
                ListBluePotion.BorderStyle = BorderStyle.None;
                ListRedPotion.BorderStyle = BorderStyle.None;

                attackUp.Text = "Up";
                attackLeft.Visible = true;
                attackRight.Visible = true;
                attackDown.Visible = true;
            }
        }

        private void ListBow_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                game.Equip("Bow");
                ListSword.BorderStyle = BorderStyle.None;
                ListBow.BorderStyle = BorderStyle.FixedSingle;
                ListMace.BorderStyle = BorderStyle.None;
                ListBluePotion.BorderStyle = BorderStyle.None;
                ListRedPotion.BorderStyle = BorderStyle.None;

                attackUp.Text = "Up";
                attackLeft.Visible = true;
                attackRight.Visible = true;
                attackDown.Visible = true;
            }
        }

        private void ListMace_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
            {
                game.Equip("Mace");
                ListSword.BorderStyle = BorderStyle.None;
                ListBow.BorderStyle = BorderStyle.None;
                ListMace.BorderStyle = BorderStyle.FixedSingle;
                ListBluePotion.BorderStyle = BorderStyle.None;
                ListRedPotion.BorderStyle = BorderStyle.None;

                attackUp.Text = "Up";
                attackLeft.Visible = true;
                attackRight.Visible = true;
                attackDown.Visible = true;
            }
        }

        private void ListBluePotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                game.Equip("Blue Potion");
                ListSword.BorderStyle = BorderStyle.None;
                ListBow.BorderStyle = BorderStyle.None;
                ListMace.BorderStyle = BorderStyle.None;
                ListBluePotion.BorderStyle = BorderStyle.FixedSingle;
                ListRedPotion.BorderStyle = BorderStyle.None;

                attackUp.Text = "Drink";
                attackLeft.Visible = false;
                attackRight.Visible = false;
                attackDown.Visible = false;
            }
        }

        private void ListRedPotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Red Potion"))
            {
                game.Equip("Red Potion");
                ListSword.BorderStyle = BorderStyle.None;
                ListBow.BorderStyle = BorderStyle.None;
                ListMace.BorderStyle = BorderStyle.None;
                ListBluePotion.BorderStyle = BorderStyle.None;
                ListRedPotion.BorderStyle = BorderStyle.FixedSingle;

                attackUp.Text = "Drink";
                attackLeft.Visible = false;
                attackRight.Visible = false;
                attackDown.Visible = false;
            }
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right,random);
            UpdateCharacters();
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void attackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void attackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void attackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void attackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
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









    }
}
