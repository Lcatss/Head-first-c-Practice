
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Guy
    {
        public string name;
        public int money;
        public Bet myBet;

        public RadioButton myRadioButton;
        public Label myLabel;

        public void updateLabels()
        {
            myRadioButton.Text=name+"有"+money+"元";
            myLabel.Text=myBet.getDescription();
        }

        public void clearBet()//重置赌注为0
        {
            myBet.amount=0;
        }

        public bool placeBet(int amount, int dog)//下注
        {
            if (money >= amount)
            {
                myBet = new Bet() { bettor = this, amount = amount, dog = dog };
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void collect(int winner)//赌金结算
        {
            money += myBet.payout(winner);
        }

    }
}
