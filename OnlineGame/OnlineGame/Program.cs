using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGame
{
    class Program
    {
        static void Main(string[] args)
        {
           int games = Convert.ToInt32(Console.ReadLine());
           int wins = Convert.ToInt32(Console.ReadLine());

            Player player1 = new Player();
            player1.games = games;
            player1.wins = wins;

            player1.GetWinRate();
            Console.ReadKey();
            }
        class Player{
            public int games;
            public int wins;
            private int winrate;

            public int Winrate{
                get {return winrate;}
                set {winrate = value;}
                }

            public void GetWinRate(){
               winrate = (wins*100/games);
                Console.WriteLine(winrate);
                }
            }
     }
   
}

