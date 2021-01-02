using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Lab_6.Exceptions;

namespace Lab_6.Logger
{
    static class Logger
    {
        private static void Report(bool ifFile, string filePath, string log)
        {
            if (ifFile)
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(log);
                }
            }
            else
                Console.WriteLine(log);
        }

        public static void Writelog(CustomException ex, bool toFile = false, string filePath = @"D:\Visual\3 sem\Lab_6\log.txt")
        {
            DateTime time = DateTime.Now;


            string toLog = $"{time} INFO:\n" +
                    $"{ex.Message} \n{ex.ErrorClass}";

            Report(toFile, filePath, toLog);
        }
        public class ConsoleLogger
        {
            public static void WriteLog(CustomException ex, string _FilePath = @"D:\Visual\3 sem\Lab_6\log.txt")
            {
                Logger.Writelog(ex, filePath: _FilePath);
            }
        }
        public class FileLogger
        {
            public static void WriteLog(CustomException ex, string _FilePath = @"D:\Visual\3 sem\Lab_6\log.txt")
            {
                Logger.Writelog(ex, true, filePath: _FilePath);
            }
        }
    }
}