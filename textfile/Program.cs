using System.Collections;
using System;
using System.IO;
using Microsoft.VisualBasic;
using System.ComponentModel;

namespace textfile
{
   

    internal class Program
    {
        public int convert(int a) {
            double d = Convert.ToInt32(a);
            d = a + a * 0.1;
            int i = Convert.ToInt32(a);
            return i;
        }


        static void Main(string[] args)
        {
           
           
            string path = @"C:\vlm\text.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
                TextWriter tw = new StreamWriter(path);
                // tw.WriteLine("The very first line!");
                tw.Close();
            }
            
            else if (File.Exists(path))
            {
                 DateTime start = DateTime.Now;
                Thread.Sleep(5000);

                for (int i = 0; i < 100000; i++)
                {
                    Random rnd = new Random();
                    int num = rnd.Next(250000, 5500000);
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(num);

                    }
                }
            DateTime end = DateTime.Now;

            TimeSpan ts = (end - start);
            Console.WriteLine("Elapsed Time is {0} ms", ts.TotalMilliseconds);
            }
           

            var lista = new ArrayList();

           /* +10%
            TextReader tr;
            tr = File.OpenText(@"C:\vlm\text.txt");

            String Actor;
            Actor = tr.ReadLine();

            while (Actor != null)
            {
                lista.Add(Actor);
                Actor = tr.ReadLine();
            }

            foreach (string a in lista)
            {
                Console.WriteLine(a);
            }

            foreach (string a in lista)
            {
              int result = Int32.Parse(a);
                lista.Remove(a);
                String b = a + result;
                lista.Add(b);
            }
            foreach (int a in lista)
            {
                a = convert(a);
               
            }*/
        }
    }
}
