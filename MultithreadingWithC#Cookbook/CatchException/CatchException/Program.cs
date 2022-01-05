using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Threading.Thread;
using static System.Console;

namespace CatchException
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Thread(FaultyThread);
            t.Start();
            t.Join();
            try
            {
                t = new Thread(BadFaultyThread);
                t.Start();
            }
            catch (Exception ex)
            {
                WriteLine("We won't get here!");
            }
            Read();
        }
        static void BadFaultyThread()
        {
            WriteLine("Starting a faulty thread...");
            Sleep(TimeSpan.FromSeconds(2));
            throw new Exception("Boom");
        }
        static void FaultyThread()
        {
            try
            {
                WriteLine("Starting a faulty thread...");
                Sleep(TimeSpan.FromSeconds(1));
                throw new Exception("Boom");
            }
            catch (Exception ex)
            {
                WriteLine($"Exception handle:{ex.Message}");
            }
        }
    }
}
