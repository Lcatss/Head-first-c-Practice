using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WindowsFormsApplication1
{
    public class Bet
    {
        public int amount;
        public int dog;
        public Guy bettor;

        public string getDescription()//返回下注情况
        {
            if (amount == 0)
                return bettor.name + " 还没有下注";
            else
                return bettor.name + "下注" + amount + "元在狗 #" + dog;
        }

        public int payout(int winner)//支付赌金
        {
            if (dog == winner)
                return amount;
            else
                return -amount;
        }

    }
}
