using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Game
    {
        public static void Play(Person player1, Person player2)
        {
            bool player1Chioce = player1.Decide();
            bool player2Choice = player2.Decide();

            player1.Play(player1Chioce, player2Choice);
            player2.Play(player2Choice,player1Chioce);
        }
    }
}
