using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClsWrkAsycProgram
{
   public class Worker
    {
        public bool IsCompleted { get; set; } = false;

        // CPU bound operation method
        // Main method : this method called two internal method inside
        // async is C# keyword --> used between access modifier and return type
        // hard and fast rule : you must have to followthe instructions
        // void is not acceptable : retuen type must be Task , Task<T>
        // apply async , deployed await and accomodated return type Task
        // You will get compiler error if you are missing three things
        public async Task DownloadFileAsync()
        {           
            Console.WriteLine("Start work here");
            // This method is calling data from external server or resource
            // this is a general practice call await opertor while you are aceesing external sources
           await DownloadFileFromExternalServerAsync();
            Console.WriteLine("End work here");
            IsCompleted = true;

            // other program activity
            await Task.Run(() => { InternalMethodOperations(); });
            
        }

        public void InternalMethodOperations()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Internal method");                  
            }
           
        }
        // I/O bound operation method
        public async Task<string> DownloadFileFromExternalServerAsync()
        {
           await Task.Run(()=> {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(".");                   
                }
            });
           
            return "File is downloaded successfully";
        }

    }
}
