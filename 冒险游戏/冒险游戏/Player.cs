using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Player:Mover
    {
        private Weapon equippedWeapon;
        public Weapon EquippedWeapon { get { return equippedWeapon; } }

        private List<Weapon> weapons = new List<Weapon>();
        public List<Weapon> Weapons
        {
            get
            {
                return weapons;
            }
        }

        public Player(Game game, Point location)
            : base(game, location,10)
        {}
       



        public void IncreaseHealth(int health, Random random)
        {
            hitPoints += random.Next(1, health);
        }

        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in weapons)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                if (Nearby(game.WeaponInRoom.Location, 10))
                {
                    weapons.Add(game.WeaponInRoom);
                    game.WeaponInRoom.PickUpWeapon();
                    if (weapons.Count == 1)
                        Equip(game.WeaponInRoom.Name);

                }
            }
        }

        public void Attack(Direction direction, Random random) 
        {
            if (equippedWeapon != null)
            {
                equippedWeapon.Attack(direction, random);
                if (equippedWeapon is IPotion)
                {
                    IPotion potion = equippedWeapon as IPotion;
                    weapons.Remove(equippedWeapon);
                }
            }
            

        }
    }
    
}
