using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal static uint StackFirstPrime(Stack<uint> stack)
        {

            foreach (var num in stack)
            {
                if (EsPrimo(num))
                    return num;
            }

            return 0; ;
        }

        internal static Stack<uint> RemoveFirstPrime(Stack<uint> stack)
        {
            return null;
        }

        internal static Queue<uint> CreateQueueFromStack(Stack<uint> stack)
        {
            return null;
        }

        internal static List<uint> StackToList(Stack<uint> stack)
        {
            return new List<uint>(stack);
        }

        internal static bool FoundElementAfterSorted(List<int> list, int value)
        {
            list.Sort();

            return list.Contains(value);
        }

        static bool EsPrimo(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}