using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace 入侵者
{
    class Game
    {
        private int score = 0;
        private int liveLeft = 2;
        private int wave = 0;
        private int frameSkipped = 0;

        private Rectangle boundaries;
        private Random random;

        private Direction invaderDirection;
        private List<Invader> invaders;

        private PlayerShip playerShip;
        private List<Shot> playerShots;
        private List<Shot> invaderShots;

        private Stars stars;


        public event EventHandler GameOver;

        public Game()
        {

        }

        public void Twinkle()
        {
            stars.Twinkle();
        }

        public void FireShot()
        {

        }

        public void Go()
        {

        }

        public void MovePlayer(Direction direction)
        {

        }

        public void Draw(Graphics g,int cell)
        {

        }
    }
}
