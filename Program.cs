using System;

namespace MyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("sssss");
            myStack.Push("Ahoj");
            myStack.PrintStack();
            
        }
    }

    class Stack<T>
    {
        int index;
        T[] element;
        public Stack(int maxElements = 100)
        {
            element = new T[maxElements];
            index = 0;
        }
        public void Push(T c) //ukládá znak na vrchol zásobníku
        {
            element[index] = c;
            index++;
        }
        public T Pop() //vrací znak z vrcholu zásobníku a odstraňuje jej ze Zásobníku
        {
            if (index > 0)
            {
                throw new ApplicationException();
            }
            else
            {
                T lastElement = element[index];
                index--;
                return lastElement;
            }
        }
        public T Peek() //  vrací znak na vrcholu zásobníku (nechává jej v zásobníku)
        {
            T lastElement = element[index - 1];
            return lastElement;
        }
        public bool IsEmpty() //vrací true/false podle toho, zda je či není Zásobník prázdný
        {
            bool empty = true;
            if (index > 0)
            {
                empty = false;
            }
            return empty;
        }
        public void PrintStack() //vypíše na konzoli všechny hodnoty ze zásobníku //predelat
        {
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(element[i]);
            }
        }
    }
    public class FindChars
    { 

    }
}
