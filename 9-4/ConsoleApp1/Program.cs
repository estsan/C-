using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IntList
    {
        int[] internalArray = new int[10];
        int Length = 0;

        public void Add(int x)
        {
            if (internalArray.Length == Length)
            {
                int[] internalArrayTemp = new int[Length + 10];
                for (int i = 0; i < Length; i++)
                {
                    internalArrayTemp[i] = internalArray[i];
                }
                internalArray = internalArrayTemp;
            }
            internalArray[Length] = x;
            Length++;
        }
        public void Remove(int y)
        {
            int indexOfRemove = 0;
            for (int i = 0; i < Length; i++)
            {
                if (internalArray[i] == y)
                {
                    indexOfRemove = i;
                    Length--;
                    break;
                }
            }
            for (int i = indexOfRemove; i < Length; i++)
            {
                internalArray[i] = internalArray[i + 1];
            }
        }
    

    }
    class Program
    {
        static void Main(string[] args)
        {
            IntList lista = new IntList();

            lista.Add(1);
            lista.Add(10);
            lista.Add(3);

            lista.Remove(1);
            lista.Remove(3);

            IntList listo = new IntList();
            listo.Add(3);

            lista.Remove(3);


        }
    }
}
