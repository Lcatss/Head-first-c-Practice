using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 入侵者
{
    public partial class Form1 : Form
    {
        private int cell = 0;
        List<Keys> keyPressed=new List<Keys>();
        private Game game;
        private bool gameOver;

        public Form1()
        {
            InitializeComponent();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            //update the animation of invaders
            game.Twinkle();
            cell++;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
            if(gameOver)
                if(e.KeyCode==Keys.R)
                {
                    //code to reset the game and timer
                    return;
                }
            if (e.KeyCode == Keys.Space)
                game.FireShot();
            if (keyPressed.Contains(e.KeyCode))
                keyPressed.Remove(e.KeyCode);
            keyPressed.Add(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keyPressed.Contains(e.KeyCode))
                keyPressed.Remove(e.KeyCode);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            game.Go();
            foreach (Keys key in keyPressed)
            {
                if (key == Keys.Left)
                {
                    game.MovePlayer(Direction.Left);
                    return;
                }
                else if (key == Keys.Right)
                {
                    game.MovePlayer(Direction.Right);
                    return;
                }
            }
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            game.Draw(g,cell);
        }
    }
}
