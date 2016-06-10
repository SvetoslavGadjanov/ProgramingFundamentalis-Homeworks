using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CensorYourEmailAddress
{
    class CensorYourEmailAddress
    {
        static void Main(string[] args)
        {
            string[] inputEmail = Console.ReadLine().Split('@');
            string email = inputEmail[0];
            string hideEmail = new String('*', email.Length);
            hideEmail = hideEmail + "@" + inputEmail[1];

            string textMesage = Console.ReadLine();
            string toPrint = textMesage.Replace(String.Join("@", inputEmail), hideEmail);

            Console.WriteLine(toPrint);

        }
    }
}
