using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap5
{
    internal class myStack<t1>
    {
        t1[] arr;
        int size;
        int tos;
        public myStack(int _size = 5)
        {
            size = _size;
            arr = new t1[size];
            tos = 0;
        }
        public int Size
        {
            get { return size; }
        }
        public void Push(t1 val)
        {
            if (tos < size)
            {
                arr[tos] = val;
                tos++;
            }
            else throw new Exception();
        }
        public t1 Pop()
        {
            if (tos != 0)
            {
                t1 removedElement = arr[0];

                // Shift the elements to the left 
                for (int i = 0; i < tos - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                tos--;
                return removedElement;
            }
            else
            {
                throw new Exception();
            }
        }
        public bool Isfull()
        {
            return tos == size;
        }
        public bool IsEmpty()
        {
            return tos == 0;
        }
        /*public override string ToString()
        {
            //return $"{t1}"
        }*/
    }
}
