using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    public class IntroLinq
    {
        public IntroLinq() 
        {
        }

        public static void Introduction()
        {
            // Specify the data source.
            int[] scores = { 88, 75, 97, 92, 69, 81, 60, 72, 96, 64, 72 };

            List<int> listScore = new List<int>();
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > 80)
                {
                    listScore.Add(scores[i]);
                }
            }

            // Execute the query.
            foreach (int i in listScore)
            {
                Console.Write(i + " ");
            }

            // Output: 88 97 92 81 96 88 97 92 81 96
        }

        public static void IntroductionWithLinq()
        {
            // Specify the data source.
            int[] scores = { 88, 75, 97, 92, 69, 81, 60, 72, 96, 64, 72 };

            IEnumerable<int> listScore = from score in scores
                                         where score > 80
                                         select score;

            // Execute the query.
            foreach (int i in listScore)
            {
                Console.Write(i + " ");
            }

            // Output: 88 97 92 81 96
        }
    }
}
