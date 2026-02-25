using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_course.Advancedshit.Delegates
{
    public class ActionFunc
    {
        public static void ConsoleWarn(string msg, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(msg);
            }
        }

        public static string IntAsString(int i)
        {
            return i.ToString();
        }
    }
}