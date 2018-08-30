using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGitFromVS
{
    class Program
    {
        static void Main(string[] args)
        {
            var saludo = new Saludo();
            Console.Write(saludo.Mensaje);

            Console.Read();
        }
    }
}
