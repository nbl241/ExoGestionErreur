using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoGestionErreur
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;

            while(!isValid)
            {
                try
                {
                    Console.WriteLine("Veuillez saisir un entier");
                    var num = Console.ReadLine();
                    bool success = int.TryParse(num, out int n);
                    if (!success)
                    {
                        throw new InvalidNumber();
                    }
                    isValid = true;
                }
                catch (InvalidNumber invNum)
                {
                    Console.WriteLine(invNum.Message.ToString());
                }
                finally
                {
                    Console.ReadLine();
                }
            }
        }
    }
}
