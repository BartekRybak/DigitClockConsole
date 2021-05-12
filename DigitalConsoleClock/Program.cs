using System;
using System.Threading;
using System.Collections.Generic;

namespace DigitalConsoleClock
{
    class Program
    {
        static string[] digits = new string[]
        {
            "████████n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "        n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "████████n",

            "        n"+
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "        n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "        n",

            "████████n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "████████n" +
            "█n" +
            "█n" +
            "█n" +
            "█n" +
            "█n" +
            "█n" +
            "█n" +
            "█n" +
            "████████n",

            "████████n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "████████n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "████████n",

            "        n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "████████n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n",

            "████████n" +
            "█n" +
            "█n" +
            "█n" +
            "█n" +
            "█n" +
            "█n" +
            "█n" +
            "█n" +
            "████████n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "████████n",

            "████████n" +
            "█n" +
            "█n" +
            "█n" +
            "█n" +
            "█n" +
            "█n" +
            "█n" +
            "█n" +
            "████████n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "████████n",

            "████████n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "        n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n",

            "████████n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "████████n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "████████n",


            "████████n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "█      █n" +
            "████████n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "       █n" +
            "████████n",

            "        n"+
            "        n" +
            "        n" +
            "        n" +
            "        n" +
            "    █   n" +
            "    █   n" +
            "    █   n" +
            "    █   n" +
            "        n" +
            "    █   n" +
            "    █   n" +
            "    █   n" +
            "    █   n" +
            "        n" +
            "        n" +
            "        n" +
            "        n" +
            "        n",
        };

        static void Main(string[] args)
        {
           
            while(true)
            {
                DateTime dt = DateTime.Now;
                string hour = dt.Hour.ToString();
                string minute = dt.Minute.ToString();
                string seconds = dt.Second.ToString();
                int space = 12;

                if(hour.Length == 1) { hour = "0" + hour; }
                if (minute.Length == 1) { minute = "0" + minute; }
                if (seconds.Length == 1) { seconds = "0" + seconds; }

                Console.Clear();
                // HOUR
                DrawDigit(1, 1, Convert.ToInt32(hour[0]) - 48, digits);
                DrawDigit(1 + space, 1, Convert.ToInt32(hour[1]) - 48, digits);
                DrawDigit(1 + space * 2 , 1, 10, digits);
                
                // MIN
                DrawDigit(1 + space * 3, 1, Convert.ToInt32(minute[0]) - 48, digits);
                DrawDigit(1 + space * 4, 1, Convert.ToInt32(minute[1]) - 48, digits);
                DrawDigit(1 + space * 5, 1, 10, digits);

                // SEC
                DrawDigit(1 + space * 6, 1, Convert.ToInt32(seconds[0]) - 48, digits);
                DrawDigit(1 + space * 7, 1, Convert.ToInt32(seconds[1]) - 48, digits);

                Thread.Sleep(1000);
            }

        }

        static void DrawDigit(int x,int y,int digit,string[] digits_temples)
        {
            string[] _d = digits_temples[digit].Split('n');
            Console.SetCursorPosition(x, y);
            for(int i =0;i< _d.Length;i++)
            {
                for(int k = 0;k < _d[i].Length;k++)
                {
                    Console.SetCursorPosition(x + k, y + i);
                    Console.Write(_d[i][k]);
                }
            }
        }
    }
}
