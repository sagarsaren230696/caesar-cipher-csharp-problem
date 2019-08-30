using System;
using System.Linq;
using System.Collections.Generic;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            char[] textChar = text.ToCharArray();
            Queue<char> textQueue = new Queue<char>();
            foreach (char letter in textChar)
            {
            if(((int)letter >=65 && (int)letter<=90) || ((int)letter >=97 && (int)letter<=122) )
            {
                if (Char.IsUpper(letter))
                {
                    textQueue.Enqueue((char)(((int)letter + shiftKey - 65)%26 + 65));
                }
                else
                {
                    textQueue.Enqueue((char)(((int)letter + shiftKey - 97)%26 + 97));
                }
            }
            else
            {
                textQueue.Enqueue(letter);
            }
                
            }
            char[] textCharNew = textQueue.ToArray();
            string textNew = new string(textCharNew);
            return textNew;
            throw new NotImplementedException("You need to implement this function.");
        }
        public static void Main(string[] args){
            string text = Console.ReadLine();
            int shiftKey = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Rotate(text,shiftKey));
        }
    }
}
