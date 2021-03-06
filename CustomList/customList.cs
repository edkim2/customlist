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
        int capacity;
        T[] temporaryArray; // maybe move this to a method called CreatingNewArray
        T[] finalArray;


        // constructor
        public customList()
        {
            capacity = 10;
            finalArray = new T[capacity];
            temporaryArray = new T[0];
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

        public void Remove(T itemToRemove)
        {
            bool noItem = true;
            bool removedItem = false;
            T[] temporaryArrayList = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                if (noItem)
                {
                    if (finalArray[i].Equals(itemToRemove))
                    {
                        noItem = false;
                        removedItem = true;
                    }
                    else
                    {
                        temporaryArrayList[i] = finalArray[i];
                    }
                }
                else
                {
                    temporaryArrayList[i - 1] = finalArray[i];
                }
            }
            if (removedItem)
            {
                count--;
            }
            finalArray = temporaryArrayList;
            //for (int i = 0; i < count; i++)
            //{
            //    if (finalArray[i].Equals(itemToRemove))
            //    {
            //        finalArray[i] = finalArray[i + 1];
            //        count--;
            //        return true;
            //    }
            //}
            //return false;
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

        public static customList<T> operator + (customList<T> listOne, customList<T> listTwo)
        {
            customList<T> sumOfLists = new customList<T>();
            foreach (T itemToAdd in listOne)
            {
                sumOfLists.Add(itemToAdd);
            }
            foreach (T itemToAdd in listTwo)
            {
                sumOfLists.Add(itemToAdd);
            }
            return sumOfLists;
            //sumOfLists = listOne + listTwo;
            //return sumOfLists;
        }

        public static customList<T> operator - (customList<T> listOne, customList<T> listTwo)
        {
            for (int i = 0; i < listOne.Count; i++)
            {
                for (int j = 0; j < listTwo.Count; j++)
                {
                    if (listOne.finalArray[i].Equals(listTwo.finalArray[j]))
                    {
                        listOne.Remove(listTwo.finalArray[j]);
                    }
                }
            }
            return listOne;
        }

        public customList<T> ZipperList (customList<T> listOne, customList<T> listTwo)
        {
            customList<T> zipperList = new customList<T>();
            for (int i = 0; i < listOne.count && i <listTwo.count; i++)
            {
                zipperList.Add(listOne.finalArray[i]);
                zipperList.Add(listTwo.finalArray[i]);
            }
            return zipperList;
            //if (listOne.Count > listTwo.Count || listOne.Count < listTwo.Count || listOne.Count == listTwo.Count)
            //{
            //    for (int i = 0; i < listOne.Count; i++)
            //    {
            //        Console.WriteLine(
            //    }
            }
        }
}