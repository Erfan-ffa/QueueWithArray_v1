using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class QueueArray
    {
        int[] numArray;
        int arrayLength;
        int front,rear = 0;



        public QueueArray(int SizeArray)
        {
            arrayLength = SizeArray;
            numArray = new int[arrayLength];
        }

        bool IsFull()
        {
            if (rear >= arrayLength)
                return true;
            return false;
        }

        bool IsEmpty()
        {
            if (rear == front)
                return true;
            return false;
        }


        public void Enqueue(int Num)
        {
            if (!IsFull())
            {
                numArray[rear] = Num;
                rear++;
            }
            else
            {
                Console.WriteLine("Queue is full!");
            }
        }

        public int Dequeue()
        {
            if (!IsEmpty())
            {
                int result = numArray[front];
                for (int i = 0; i < numArray.Length -1 ; i++)
                {
                    numArray[i] = numArray[i + 1];
                }
                rear--;
                return result;
            }
            return -1;
        }

        public void PrintMembers()
        {
            if (!IsEmpty()) 
            {
                for (int i = front; i < rear; i++)
                {
                    Console.WriteLine(numArray[i]);
                }                
            }
        }
    }
}
