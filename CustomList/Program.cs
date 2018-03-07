using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {

        static void Main(string[] args)
        {
            customList<string> listOne = new customList<string>() { "10", "20", "30", "40", "50"};
            //customList<string> listTwo = new customList<string>() {"40", "50", "60", "10"};
            listOne.Remove("20");
            listOne.Remove("30");
            Console.WriteLine(listOne);
            Console.ReadLine();
            //customList<string> listThree = new customList<string>();
            //listThree = listOne + listTwo;
            //Console.WriteLine(listThree);
            //Console.ReadLine();
            //listThree = listOne - listTwo;
            //Console.WriteLine(listThree);
            //Console.ReadLine();

        }
    }
}
