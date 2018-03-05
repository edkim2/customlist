using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class customList<T>
    {
        // member variables
        int count;
        int capacity = 5;
        T[] temporaryArray; // maybe move this to a method called CreatingNewArray
        T[] finalArray;


        // constructor
        public customList()
        {
            capacity = 5;
            temporaryArray = new T[0];
            finalArray = new T[capacity];
        }
        
        // member methods
        public void Add(T itemToAdd)
        {

        }

        public void CreateBiggerArray()
        {
            T[] temproraryArray = new T[capacity * 2];
            for(int i = 0; i < count; i++)
            {
                temporaryArray[i] = finalArray[i];
            }
            capacity = capacity * 2;
            finalArray = temporaryArray;
        }

        public void Remove(T itemToRemove)
        {

        }

    }
}
