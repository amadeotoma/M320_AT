using System;

namespace Browsersimulator
{
    public class StringStack
    {
        private string[] values;
        private int index;

        public StringStack(int size)
        {
            values = new string[size];
            index = 0;
        }

        public void Push(string value)
        {
            if (IsFull)
            {
                Console.WriteLine("Stack ist voll. Es können keine Elemente gepickt werden.");
                return;
            }

            values[index++] = value;
        }

        public string Pop()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack ist leer. Es können keine Elemente gepopt werden.");
                return null;
            }

            return values[--index];
        }

        public string Peek()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack ist leer. Es können keine Elemente gepeekt werden.");
                return null;
            }

            return values[index - 1];
        }

        public void Swap()
        {
            if (index < 2)
            {
                Console.WriteLine("Stack hat weniger als zwei elemente. Kann nicht gewechselt werden.");
                return;
            }

            string temp = values[index - 1];
            values[index - 1] = values[index - 2];
            values[index - 2] = temp;
        }

        public void Clear()
        {
            Array.Clear(values, 0, values.Length);
            index = 0;
        }

        public bool IsEmpty => index == 0;

        public int Count => index;

        public bool IsFull => index == values.Length;
    }
}