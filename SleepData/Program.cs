﻿using System;
using System.IO;

namespace SleepData
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // ask for input
            Console.WriteLine("Enter 1 to create data file.");
            Console.WriteLine("Enter 2 to parse data.");
            Console.WriteLine("Enter anything else to quit.");
            // input response
            string resp = Console.ReadLine()
;
            // specify path for data file
           string file = AppDomain.CurrentDomain.BaseDirectory +"data.txt";

            if (resp == "1")
            {
              
                // ask a question
                Console.WriteLine("How many weeks of data is needed?");
                // input the response (convert to int)
                int weeks = int.Parse(Console.ReadLine());

                // determine start and end date
                DateTime today = DateTime.Now;
                // we want full weeks sunday - saturday
                DateTime dataEndDate = today.AddDays(-(int)today.DayOfWeek);
                // subtract # of weeks from endDate to get startDate
                DateTime dataDate = dataEndDate.AddDays(-(weeks * 7));
               





                // random number generator
                Random rnd = new Random();

                // create file
                StreamWriter sw = new StreamWriter(file);
                // loop for the desired # of weeks
                while (dataDate < dataEndDate)
                {
                    // 7 days in a week
                    int[] hours = new int[7];
                    for (int i = 0; i < hours.Length; i++)
                    {
                        // generate random number of hours slept between 4-12 (inclusive)
                        hours[i] = rnd.Next(4, 13);
                    }
                    // M/d/yyyy,#|#|#|#|#|#|#
                    //Console.WriteLine($"{dataDate:M/d/yy},{string.Join("|", hours)}");

                    
                  sw.WriteLine($"{dataDate:dddd dd MMMM},{string.Join("|", hours)}");
                    // add 1 week to date
                    dataDate = dataDate.AddDays(7);
                }
                sw.Close();
            }
            else if (resp == "2")
            {
                StreamReader fileReader = new StreamReader(file);
                while (!fileReader.EndOfStream)
                        {
                   
                    string line = fileReader.ReadLine();

                    Console.WriteLine(line);


                    String[] laFecha = line.Split(',');
                    DateTime parsedDate = DateTime.Parse(laFecha[0]);
                    String semana = (parsedDate.ToString("dddd dd MMMM"));

                    String[] diasSemana = laFecha[1].Split(',','|'); // Why is the comma splitting mandatory, when youre already splitting the array?

                    

                  Console.WriteLine("Week of {0}",semana);
                 
                   Console.WriteLine($"{"Mon",4}{"Tue",4}{"Wed",4}{"Thr",4}{"Fri",4}{"Sat",4}{"Sun",4}");
                   Console.WriteLine($"{diasSemana[0],4}{diasSemana[1],4}{diasSemana[2],4}{diasSemana[3],4}{diasSemana[4],4}{diasSemana[5],4}{diasSemana[6],4}");

                    
                

                
                }
                    }
                  

            
        }
    }
}
