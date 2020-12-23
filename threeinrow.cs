using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp
{
    class threeinrow
    {
        static bool isPlaying = false;
        static string[,] game = new string[3, 3];

        static void Main(string[] args){
            bool con = true;

            while (con)
            {
                bool player = true;
                int fila = 0;
                int columna = 0;

                draw(fila, columna, player);
                do
                {
                    Console.WriteLine("Entra la columna: ");
                    int.TryParse(Console.ReadLine(), out columna);
                    Console.WriteLine("Entra la fila: ");
                    int.TryParse(Console.ReadLine(), out fila);

                    draw(fila - 1, columna - 1, player);

                    evaluate();

                    player = !player;


                } while (isPlaying);

                if (!player) Console.WriteLine("GANA EL JUGADOR X"); else Console.WriteLine("GANA EL JUGADOR O");

                Console.WriteLine("Quieres volver a jugar? (si/no)");
                string play = Console.ReadLine();

                if (play == "no")
                {
                    con = false;
                    
                    
                    Console.WriteLine("");
                }
                else
                {
                    isPlaying = false;
                    game = new string[3, 3];
                    Console.Clear();
                }
            }
        }

        static void draw(int row, int column, bool play)
        {
            for(int i = 0; i<3; i++)
            {
                for(int j = 0; j <3; j++){

                    if(!isPlaying) game[i, j] = " _ ";

                    if (i == row && j == column && isPlaying == true && play){
                        game[i, j] = " X ";
                    }else if (i == row && j == column && isPlaying == true && !play){
                        game[i, j] = " O ";
                    }

                    Console.Write(game[i, j] + "|");
                }
                Console.WriteLine("");

                
            }

            isPlaying = true;
        }

        static void evaluate(){
            if(game[0, 0] == game[0, 1] && game[0,1] == game[0, 2] && game[0, 0] != " _ "){
                isPlaying = false;
            } else if (game[1, 0] == game[1, 1] && game[1, 1] == game[1, 2] && game[1, 0] != " _ ")
            {
                isPlaying = false;
            }else if (game[2, 0] == game[2, 1] && game[2, 1] == game[2, 2] && game[2, 0] != " _ ")
            {
                isPlaying = false;
            }else if (game[0, 0] == game[1, 0] && game[1, 0] == game[2, 0] && game[0, 0] != " _ ")
            {
                isPlaying = false;
            }
            else if (game[0, 1] == game[1, 1] && game[1, 1] == game[2, 1] && game[0, 1] != " _ ")
            {
                isPlaying = false;
            }
            else if (game[0, 2] == game[1, 2] && game[1, 2] == game[2, 2] && game[0, 2] != " _ ")
            {
                isPlaying = false;
            }
            else if (game[0, 0] == game[1, 1] && game[1, 1] == game[2, 2] && game[0, 0] != " _ ")
            {
                isPlaying = false;
            }
            else if (game[0, 2] == game[1, 1] && game[1, 1] == game[2, 0] && game[0, 2] != " _ ")
            {
                isPlaying = false;
            }
        }
    }
}
