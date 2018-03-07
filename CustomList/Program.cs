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
            customList<string> listOne = new customList<string>() { "10", "20", "30", "40"};
            customList<string> listTwo = new customList<string>() {"50", "60", "70", "80", "10"};
            customList<string> listThree = new customList<string>();
            listThree = listOne + listTwo;
            Console.WriteLine(listThree);
            Console.ReadLine();
            listThree = listOne - listTwo;
            Console.WriteLine(listThree);
            Console.ReadLine();

        }
    }
}
