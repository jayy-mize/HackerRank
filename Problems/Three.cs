using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPlayground.Problems
{

    //problem 4 hackerank
    public class Three
    {
        public Three()
        {

        }


        public void Execute(string name)
        {
            var n = 9;
            var x = new List<int> { 9, 7, 3, 1 };

            var n1 = 10;
            var x1 = new List<int> { 1, 5, 10, 3 };


            var n2 = 5;
            var x2 = new List<int> { 2,1,5 };


            getMostVisited(n2,x2);
        }

        public int getMostVisited(int n, List<int> sprints)
        {
            var tracker = new List<Tracker>();
            //setup tracker(unique)
            for (var i = 1; i <= n ; i++)
            {
                tracker.Add(new Tracker(i));
            }

            //run sprints and log, dont iterate past last leg
            for(var i = 0; i < (sprints.Count-1); i++)
            {
                var start = sprints[i];
                var end = sprints[i + 1];

                //forward run
                if(start<end)
                {
                    for(var s = start; s <= end; s++)
                    {
                        var update = tracker.First(t => t.Leg == s);
                        update.Value++;
                    }
                }
                //backwards run
                else
                {
                    for (var s = end; s <= start; s++)
                    {
                        var update = tracker.First(t => t.Leg == s);
                        update.Value++;
                    }
                }

            }
            var max = tracker.OrderByDescending(t => t.Value).First().Value;
            var hitMost = tracker.Where(t => t.Value == max).OrderBy(t => t.Leg).First().Leg;
            Console.WriteLine($"Max value is {max}");
            Console.WriteLine($"Hit Most is  {hitMost}");

            return hitMost;
        }

        public class Tracker
        {
            public Tracker(int x)
            {
                Leg = x;
                Value = 0;
            }
            public int Leg;
            public int Value;
        }

    }
}
