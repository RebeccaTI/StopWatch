namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
             Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = second => 10s = 10 seconds");
            Console.WriteLine("M = minute => 1m = 1 minutes");
            Console.WriteLine("0 = exit");
            Console.WriteLine("How long do you want to count?");

           string data = Console.ReadLine().ToLower();
           char  type = char.Parse(data.Substring(data.Length-1, 1));
           int time = int.Parse(data.Substring(0, data.Length -1));
           int multiplier = 1;

            if (type == 'm')
            
                multiplier = 60;
            
            if (time == 0)
                System.Environment.Exit(0);
        
            PreStart(time * multiplier);

        }

        static void PreStart(int time) {
             Console.Clear();
             Console.WriteLine("Ready...");
             Thread.Sleep(1000);
             Console.WriteLine("Set...");
             Thread.Sleep(1000);
             Console.WriteLine("Go...");
             Thread.Sleep(2500);

             Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;
            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Finished Stopwatch");
            Thread.Sleep(2000);
            Console.WriteLine("Thank you for using");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
