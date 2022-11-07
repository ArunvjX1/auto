using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using auto.com.auto;
namespace auto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kola te = new kola("hello Arun Vijay");
            Console.WriteLine(te);
            overload tum = new overload();
            Console.WriteLine("\n",tum,"\n");
            tum.over();

            tum.over(16995);
            Console.ReadLine();

            
           
        }
    }
}
