using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Threading.Thread;
using static System.Console;

namespace ReaderWriterLockSlim类
{
    class Program
    {
        static ReaderWriterLockSlim _rw = new ReaderWriterLockSlim();
        static Dictionary<int, int> _items = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            new Thread(Read) { IsBackground = true }.Start();
            new Thread(Read) { IsBackground = true }.Start();
            new Thread(Read) { IsBackground = true }.Start();
            new Thread(() => Write("Thread1")) { IsBackground = true }.Start();
            new Thread(() => Write("Thread2")) { IsBackground = true }.Start();
            Sleep(TimeSpan.FromSeconds(30));
            Read();
        }
        static void Read()
        {
            WriteLine("Reading content of a dictionary");
            while (true)
            {
                try
                {
                    _rw.EnterReadLock();
                    foreach (var key in _items.Keys)
                    {
                        Sleep(TimeSpan.FromSeconds(0.1));
                    }
                }
                finally
                {
                    _rw.ExitReadLock();
                }
            }
        }
        static void Write(string threadName)
        {
            while (true)
            {
                try
                {
                    int newkey = new Random().Next(250);
                    _rw.EnterUpgradeableReadLock();
                    if (!_items.ContainsKey(newkey))
                    {
                        try
                        {
                            _rw.EnterWriteLock();
                            _items[newkey] = 1;
                            WriteLine($"New Key {newkey} is added to a dictionary by a {threadName}");
                        }
                        finally
                        {
                            _rw.ExitWriteLock();
                        }
                    }
                    Sleep(TimeSpan.FromSeconds(0.1));
                }
                finally
                {
                    _rw.ExitUpgradeableReadLock();
                }
            }
        }

    }
}
