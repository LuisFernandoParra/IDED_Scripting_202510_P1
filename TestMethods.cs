using System.Collections.Generic;
using System.ComponentModel.Design;

namespace TestProject1
{
    internal class TestMethods
    {
        internal static uint StackFirstPrime(Stack<uint> stack)
        {
            Stack<uint> Aux = new Stack<uint>();
            uint result = 0;
            while (stack.Count > 0)
            {
                uint current = stack.Pop();
                if (EsPrimo(current))
                {
                    result = current;
                    Aux.Push(current);
                    break;
                }
              

                    Aux.Push(current);
            }

            while (Aux.Count > 0)
            {
                stack.Push(Aux.Pop());
            }
            return result;


        }

        internal static Stack<uint> RemoveFirstPrime(Stack<uint> stack)
        {
            Stack<uint> Aux = new Stack<uint>();
            bool eliminado = false;
            while (stack.Count > 0)
            {
                uint current = stack.Pop();
                if (!eliminado && EsPrimo(current))
                {
                    eliminado = true;
                    continue;
                }
                Aux.Push(current);
            }

            while (Aux.Count > 0)
            {
                stack.Push(Aux.Pop());
            }
            return stack;
        }

        internal static Queue<uint> CreateQueueFromStack(Stack<uint> stack)
        {
            Queue<uint> queue = new Queue<uint>();

            foreach (uint item in stack)
            {
                queue.Enqueue(item);
            }
            
            return queue;

        }

        internal static List<uint> StackToList(Stack<uint> stack)
        {
            return new List<uint>(stack);
        }

        internal static bool FoundElementAfterSorted(List<int> list, int value)
        {
          for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[i])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
          }
            foreach (int item in list)
            {
                if (item == value)
                {
                    return true;
                }
            }
            return false;
        }

        static bool EsPrimo(uint num)
        {
            if (num < 2) return false;
            for (uint i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}