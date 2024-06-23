using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiseFlight
{
    static internal class Buffer
    {
        public static string CompaniTxtBox = "Выберите авиакомпанию";

        public static string ReisTxtBox = "Выберите номер рейса";

        public static int BChost = 0;

        public static bool pay = true;

        public static List<string> bookings = new List<string>();

        public static List<string> bookingsDB = new List<string>();

        public static int inBDbe = 0;

        public static int inBDbb = 0;

        public static int Beco = 0;

        public static int Bbusiness = 0;
    }
}
