using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    public class Password
    {
        public static bool Digit(string Password)
        {
            bool correct = (true);
            bool error = (false);
            //цифры
            if (Password.Any(Char.IsDigit))
            {
                return correct;
            }
            else return error;
        
        }
    }
}
