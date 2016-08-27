using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace auto_distribution
{
    class PublicMethods
    {
        public static int getRandomNumber(int min, int max)
        {
            int start = min;
            int end = max;
            Random rd = new Random();
            return rd.Next(start, end);

        }
        public static int transferToInt(string text)
        {
            int result=0;
            var i = int.TryParse(text, out result);
            if (i&&result>-1)
                return result;
            else
                return -1;

        }

    }
}
