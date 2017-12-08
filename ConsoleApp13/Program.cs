using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp13.UserInterface;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();

        }
        private void Run()
        {
            Menu m = new Menu();
            m.MenuRun();
        }


    }
        
 }
