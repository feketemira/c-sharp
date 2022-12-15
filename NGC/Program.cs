namespace NGC
{

internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            Random rnd = new Random();
            int szf = rnd.Next(1,100);

            switch (szf)
            {
                case int n when (n <= 67):
                    Console.WriteLine("atlag lett");
                    
                    break;

                case int n when (n <= 87 && n > 67):
                    Console.WriteLine("optimista lett");
                    break;

                case int n when (n > 87):
                    Console.WriteLine("pesszimista lett");
                    break;
            }

        }
    }
}