using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp
{
    class Ahorcado
    {
        static readonly string[] words = { "jurutungo", "almocafre", "ahuehue", "retintin", "ñoño", "chanza", "ringorrango"};
        static bool isCorrect = false;

        public static void Main(string[] args)
        {
            Ahorcado a = new Ahorcado();

            bool Continue = true;
            
            while(Continue){
                
                Random rand = new Random();
                int randNum = rand.Next(0, words.Length);

                string palabra = words[randNum];//randNum
                char[] word = new char[palabra.Length];
                Console.WriteLine(palabra);
                
                a.printWord(word, palabra);

                while (!isCorrect)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Entra una letra");
                    char let = Console.ReadLine().ToCharArray()[0];
                    a.Evaluate(let, palabra, word);
                    a.printWord(word, palabra);
                }

                Console.WriteLine("");
                Console.WriteLine("Quieres volver a jugar? (si/no)");
                string play = Console.ReadLine();

                if(play == "no"){
                    Continue = false;
                    isCorrect = false;
                    Console.WriteLine("");
                }
                else{
                    isCorrect = false;
                    Console.Clear();
                }
                
                
            }

        }

        void Evaluate(char letEval, string word, char[] wordChar){
            
            for(int i = 0; i<word.Length; i++){
                if(word[i] == letEval){
                    wordChar[i] = letEval;
                }
            }
           
        }

        void printWord(char[] wordChar, string word){

            char letter;

            bool allCheck = true;

            for(int i = 0; i < wordChar.Length; i++){
                letter = word[i];

                if(letter == wordChar[i]){
                    Console.Write(letter);
                }
                else{
                    Console.Write("_");
                    allCheck = false;
                }
            }

            if(allCheck == true)
            {
                isCorrect = true;
            }
        }
    }
}
