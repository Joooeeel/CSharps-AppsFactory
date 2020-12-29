using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp.OcaGame
{
    class MainClass
    {
        static void Main(string[] args){
            //Initialize Random
            Random r = new Random();
            
            //Lista de Jugadores
            List<Player> players = new List<Player>();

            //DIccionario de ocas
            Dictionary<int, int> ocas = new Dictionary<int, int>();
            Dictionary<int, int> puente = new Dictionary<int, int>();
            Dictionary<int, int> dados = new Dictionary<int, int>();
            Dictionary<int, int> penalizaciones = new Dictionary<int, int>();

            //Iniciamos la posicion de ocas
            ocas = init(0);
            puente = init(1);
            dados = init(2);
            penalizaciones = init(3);

            
            int numPlayers;

            Console.WriteLine("Bienvenido al juego de la OCA");
            Console.WriteLine("");
            Console.WriteLine("Introduzca el número de jugadores:");
            int.TryParse(Console.ReadLine(), out numPlayers);

            for(int i=0; i < numPlayers; i++){
                players.Add(new Player());
                Console.WriteLine("Introduza el nombre del jugador: ");
                players[i].nombre = Console.ReadLine();
                players[i].casilla = 1;
                players[i].turnosRestantes = 0;
                players[i].isActive = true;
            }

            //GAME START
            bool isActive = true;
            int newMove;
            int player = 0;

            while (isActive){
                newMove = r.Next(1, 7);
                int newSquare = newMove + players[player].casilla;

                if (players[player].isActive && players[player].turnosRestantes == 0){
                    players[player].casilla = newSquare;
                    Console.WriteLine(players[player].nombre + " se ha movido a la casilla: " + players[player].casilla);

                    //CHECK IF POSITION CONTAINS OCA
                    if (ocas.ContainsKey(newSquare))
                    {
                        Console.WriteLine("De oca a oca y tiro porque me toca");
                        players[player].casilla = ocas[newSquare];
                        Console.WriteLine(players[player].nombre + " se ha movido a la casilla: " + players[player].casilla);
                    }

                    //CHECK IF POSITION CONTAINS PUENTE
                    if (puente.ContainsKey(newSquare))
                    {
                        Console.WriteLine("De puente a puente y tiro porque me lleva la corriente");
                        players[player].casilla = puente[newSquare];
                        Console.WriteLine(players[player].nombre + " se ha movido a la casilla: " + players[player].casilla);
                    }

                    //CHECK IF POSITION CONTAINS DADO
                    if (dados.ContainsKey(newSquare))
                    {
                        Console.WriteLine("De dado a dado y tiro porque me ha tocado");
                        players[player].casilla = dados[newSquare];
                        Console.WriteLine(players[player].nombre + " se ha movido a la casilla: " + players[player].casilla);
                    }

                    //CHECK IF POSITION TAKES SOME PENALITATION
                    if (penalizaciones.ContainsKey(newSquare))
                    {
                        players[player].turnosRestantes = penalizaciones[newSquare];

                        if (players[player].turnosRestantes == 10){
                            players[player].isActive = false;
                            Console.WriteLine(players[player].nombre + " ha muerto");
                        }
                        else { Console.WriteLine(players[player].nombre + " tiene una penalización de: " + players[player].turnosRestantes + " turnos."); }

                    }
                }
                else{
                    players[player].turnosRestantes--;
                }



                //CHECK IF FINISH
                /*if (players[player].casilla >= 63){
                    Console.WriteLine("");
                    Console.WriteLine("El jugador: " + players[player].nombre + " HA GANADO!!!!!!!! ");
                    isActive = false;
                }*/

                if (players[player].casilla == 63)
                {
                    Console.WriteLine("");
                    Console.WriteLine(players[player].nombre + " HA GANADO!!!!!!!! ");
                    isActive = false;
                }else if(players[player].casilla > 63){
                    int moveBack = players[player].casilla - 63;
                    int actual = players[player].casilla - newMove;

                    players[player].casilla = 63 - moveBack;
                    Console.WriteLine(players[player].nombre + " se ha pasado y retrocede");
                    Console.WriteLine(players[player].nombre + " se ha movido de: " + actual + " a la casilla: " + players[player].casilla);
                }

                if (player < numPlayers - 1) player++; else player=0;


            }
            

        }

        static Dictionary<int, int> init(int game){
            Dictionary<int, int> final = new Dictionary<int, int>();

            if(game == 0){ 
                final.Add(5, 9);
                final.Add(9, 14);
                final.Add(14, 18);
                final.Add(23, 27);
                final.Add(27, 32);
                final.Add(32, 36);
                final.Add(36, 41);
                final.Add(41, 45);
                final.Add(45, 50);
                final.Add(50, 54);
                final.Add(54, 59);
            }else if(game == 1){
                final.Add(6, 12);
                final.Add(12, 6);
            }else if(game == 2){
                final.Add(26, 53);
                final.Add(53, 26);
            }else if(game == 3){
                final.Add(19, 2);
                final.Add(3, 1);
                final.Add(52, 3);
                final.Add(58, 10);
            }
            return final;
        }
    }
}
