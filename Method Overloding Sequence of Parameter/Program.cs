using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloding_Sequence_of_Parameter
{

    class name
    {
        public void show(int x,string y)
        {
            Console.WriteLine("hello");
        }
        public void show(string x,int y)
        {
            Console.WriteLine("hiii Akshay saini");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            name obj = new name();
            obj.show("hi",10);
            Console.ReadLine();
        }
    }
}
