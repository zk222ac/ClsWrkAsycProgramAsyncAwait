using System;
using System.Threading;
using System.Threading.Tasks;

namespace ClsWrkAsycProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // SubMethod();
            Console.WriteLine("Program is start Now");
            var worker = new Worker();
            worker.DownloadFileAsync().GetAwaiter().GetResult();
            if (!worker.IsCompleted)
            {
                Console.WriteLine("Finally you finish your all of work");
            }

            Console.WriteLine("Program ends");
           // Console.WriteLine("Starting time.............................");
           // Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
           // // What is your main job how to make your methods asychronously
           // // mechanism no : 1
           // // simple create an object instance of task and then call the method delegately
           // //----------------------------------------------------------- 
           // Task task1 = new Task(PourCoffee);
           //  task1.Start();
           // task1.Wait();
           // //---------------------------------------------------------
           // //----------------------------------------------------------- 
           // Task task2 = new Task(HeatPan);
           // task2.Start();
           // task2.Wait();
           // //---------------------------------------------------------
           // //----------------------------------------------------------- 
           // Task task3 = new Task(FryBacon);
           // task3.Start();
           // //---------------------------------------------------------
           // //----------------------------------------------------------- 
           // Task task4 = new Task(ToastBread);
           // task4.Start();
           // //---------------------------------------------------------
           // //----------------------------------------------------------- 
           // Task task5 = new Task(ButterJamoToast);
           // task5.Start();
           // //---------------------------------------------------------
           // //----------------------------------------------------------- 
           // Task task6 = new Task(PourJuice);
           // task6.Start();
           // //---------------------------------------------------------
           // // mechanish no :2
           // // Task task1 = new Task(() => { PourCoffee(); });
           // // mechnish no 3: 
           // // Task.Run(()=> { Console.WriteLine("run method asychronously"); });
           // //------------------------------------------------------------
           // // PourCoffee();
           // // HeatPan();
           // // FryBacon();
           // // ToastBread();
           // // ButterJamoToast();
           // // PourJuice();
           // // anonynous method { () => { expression } }
           //Task t = Task.Run(()=> {
           //    Console.WriteLine("Ending time....................................");
           //    Console.WriteLine(DateTime.Now.ToString("HH:mm:ss")); });
           // t.Wait();
            Console.ReadKey();
        }

        public static async void SubMethod()
        {
            Console.WriteLine("Program is start Now");
            var worker = new Worker();
           await worker.DownloadFileAsync();
            if (!worker.IsCompleted)
            {
                Console.WriteLine("Finally you finish your all of work");
            }

        }

        public static void PourCoffee()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task no : 1 Pour a cup of coffee" + i);
                Console.BackgroundColor = ConsoleColor.Green;
                Thread.Sleep(800);
            }
        }
        public static void HeatPan()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task no : 2 Heat up a Pan and fried Two Eggs" + i);
                Console.BackgroundColor = ConsoleColor.Red;
                Thread.Sleep(800);
            }
        }
        public static void FryBacon()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task no : 3 Fry three slices of becon" + i);
                Console.BackgroundColor = ConsoleColor.Cyan;
                Thread.Sleep(800);
            }
        }

        public static void ToastBread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task no : 4 Toast two pieces of bread" + i);
                Console.BackgroundColor = ConsoleColor.Blue;
                Thread.Sleep(800);
            }
        }
        public static void ButterJamoToast()
        { 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task no : 5 Butter and Jam on the Toast" + i);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Thread.Sleep(800);
            }
        }
        public static void PourJuice()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task no : 6 Pour a class on orange juice" + i);
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Thread.Sleep(800);
            }
        }


    }
}
