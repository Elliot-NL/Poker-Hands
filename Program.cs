using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_Hands
{
    class Program
    {
        public static SimpleDealer currcards = new SimpleDealer();
        public static Random rnd = new Random();
        public static List<Card> Player1;
        public static List<Card> Player2;
        
        static void Main(string[] args)
        {
            //Retrieves all cards for user
            Console.WriteLine("Poker Hands, press Enter to random the flop...");
            var response_1 = Console.ReadLine();
            if (response_1 != null)
            {
                //Flop Card
                List<Card> Flop = new List<Card>();
                for (int i = 0; i < 3; i++)
                {
                    Flop.Add(currcards.DealCard());
                }
                foreach (Card cd in Flop)
                {
                    Console.WriteLine(cd.DisplayValue());
                }
                
                Console.WriteLine("Press Enter again to random the turn...");
                var response_2 = Console.ReadLine();
                if(response_2 != null)
                {
                    //Turn Card
                    List<Card> Turn = new List<Card>();
                    for (int i = 0; i < 1; i++)
                    {
                        Turn.Add(currcards.DealCard());
                    }
                    foreach(Card cd in Turn)
                    {
                        Console.WriteLine(cd.DisplayValue());
                    }
                }

                Console.WriteLine("Press Enter again to random the river...");
                var response_3 = Console.ReadLine();
                if(response_3 != null)
                {
                    //River Card
                    List<Card> River = new List<Card>();
                    for (int i = 0; i < 1; i++ )
                    {
                        River.Add(currcards.DealCard());
                    }
                    foreach(Card cd in River)
                    {
                        Console.WriteLine(cd.DisplayValue());
                    }
                }

                Console.WriteLine("Press Enter again to random Player 1 Cards...");
                var response_4 = Console.ReadLine();
                if (response_4 != null)
                {
                    //Player1 Card
                    List<Card> Player1 = new List<Card>();
                    for (int i = 0; i < 1; i++)
                    {
                        Player1.Add(currcards.DealCard());
                    }
                    foreach (Card cd in Player1)
                    {
                        Console.WriteLine(cd.DisplayValue());
                    }
                }

            }
            Console.ReadLine();
        }
    }
               
}

