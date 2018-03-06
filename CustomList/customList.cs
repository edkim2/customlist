﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class customList<T> : IEnumerable<T>
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
        public int MaximumIndexCapacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }
        public void Add(T itemToAdd)
        {
            if (count == MaximumIndexCapacity)
            {
                CreateBiggerArray();
            }
            finalArray[count] = itemToAdd;
            count++;
        }

        public void CreateBiggerArray()
        {
            T[] temproraryArray = new T[capacity * 2];
            for (int i = 0; i < count; i++)
            {
                temporaryArray[i] = finalArray[i];
            }
            capacity = capacity * 2;
            finalArray = temporaryArray;
        }

        public bool Remove(T itemToRemove)
        {
            for (int i = 0; i < count; i++)
            {
                if (finalArray[i].Equals(itemToRemove))
                {
                    finalArray[i] = finalArray[i + 1];
                    count++;
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return finalArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            string toString = "";
            for (int i = 0; i < count; i++)
            {
                toString = toString + finalArray[i] + " ";
            }
            return toString;
        }
    }
}