using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPlayground.Problems
{
    //problem 2 in hacker rank
    public class One
    {
        public One()
        {

        }


        public void Execute(string name)
        {
            name = "1.30";
            var decimalMoney = Convert.ToDecimal(name);
            Console.WriteLine(decimalMoney);

            var coinsNeeded = 0;
            var p = .01;
            var n = .05;
            var d = .1;
            var q = .25;
            var f = .5;

            var target = decimalMoney;
            while(target != 0)
            {
                //take fifty
                if(target >= .5m)
                {
                    coinsNeeded++;
                    target = target - .5m;
                }
                //take quarter
                else if (target < .5m && target >= .25m)
                {
                    coinsNeeded++;
                    target = target - .25m;
                }
                //take dime
                else if (target < .25m && target >= .1m)
                {
                    coinsNeeded++;
                    target = target - .1m;
                }
                //take nickle
                else if (target < .1m && target >= .05m)
                {
                    coinsNeeded++;
                    target = target - .05m;
                }
                //take penny
                else
                {
                    coinsNeeded++;
                    target = target - .01m;
                }

            }


            Console.WriteLine($"coinsNeeded {coinsNeeded}");



        }
    }


}
