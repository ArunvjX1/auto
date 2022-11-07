using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto.com.auto
{
    class kola
    {
        public kola()
        {

            Console.WriteLine("this is the default Value");
        }
        public kola(int a)
        {

            Console.WriteLine("this is the default Value of int {0}", a);
        }
        public kola(string test)
        {
            Console.WriteLine("This is the Value of the string: {0}", test);
        }
    }
    public class overload
        {

           public void over() {
                Console.WriteLine("this is the default overloading method we are creating!");
            }
         public void over(int a) {
                Console.WriteLine(a);
            
            }
        public void over(string check) {
                Console.WriteLine(check);
            }
        }
    
    
    

    internal class auto
    {

    }
}
