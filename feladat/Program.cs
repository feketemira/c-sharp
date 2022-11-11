using System.Linq.Expressions;
using System.Numerics;

namespace zh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int>();
            nums.Add(8);
            nums.Add(37);
            nums.Add(11);
            nums.Add(98);
            nums.Add(95);
            nums.Add(43);
            nums.Add(11);
            nums.Add(98);
            nums.Add(8);
            nums.Add(8);
            nums.Add(37);
            var words = new List<string>() { "fa", "kép", "daru", "fa", "alma", "doboz", "kép", "doboz", "fa" };


            Console.WriteLine("3.feladat------------------------");
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > 20)
                {
                    Console.WriteLine(nums[i]);
                }
            }

            Console.WriteLine("4.feladat------------------------");
            for (int i = 0; i < nums.Count; i++)
            {
                int count = 0;
                Console.Write(nums[i] + ": ");
                for (int j = 0; j < nums.Count; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
            // töröld ki a listából a leggyakrabban előforduló kezdőbetűjű szavakat
            Console.WriteLine("5.feladat------------------------");//nincs befejezve
            int max = 0;
            for (int i = 0; i < words.Count; i++)
            {
                int count = 0;
                var fletter1 = words[i].Substring(0, 1);
                foreach (string s in words)
                {
                    var fletter2 = s.Substring(0, 1);
                    if (fletter1.Equals(fletter2))
                    {
                        count++;
                    }
                    if (count > max)
                    {
                        max= count;
                    }
                }

                Console.WriteLine(fletter1 + " " + count);
            }
            Console.WriteLine(max);
            foreach (string s in words)
            {
                Console.Write(s + ", ");
            }
            Console.WriteLine(" ");


            Console.WriteLine("6.feladat------------------------");
            double avg = nums.Average();
            Console.WriteLine("Average: " + avg);
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < avg)
                {
                    Console.WriteLine(nums[i]);
                }
            }
            //Keresd meg a szót amiben a legtöbb s betű van
            Console.WriteLine("7.feladat------------------------");// nincs befejezve
            var counts = new List<int>();
            char sletter = 's';
            foreach (string s in words)
            {
                int count = 0;
                foreach (char c in s)
                {
                    if (c.Equals(sletter))
                    {
                        count++;
                    }
                }
                counts.Add(count);
            }
            foreach (int i in counts)
            {
                Console.Write(i + ", ");

            }
            Console.WriteLine(" ");
            Console.WriteLine("9.feladat------------------------");
            Random rnd = new Random();
            int randnum = rnd.Next(0, 20);
            Console.WriteLine("Give me a number!(0-20)");
            int usernum= Convert.ToInt32(Console.ReadLine());
            if (usernum == randnum)
            {
                Console.WriteLine("You won!!");
            }
            else if (usernum > randnum)
            {
                Console.WriteLine("smaller");
            }
            else if(usernum < randnum)
            {
                Console.WriteLine("bigger");
            }
            Console.WriteLine(randnum);

        }

    }
}