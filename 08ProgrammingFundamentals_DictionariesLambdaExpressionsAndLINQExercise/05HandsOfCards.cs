using System;
using System.Collections.Generic;
using System.Linq;

namespace _05HandsOfCards
{
    class Program
    {        
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> cardsInPlayers = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "JOKER")
            {
                string[] playerAndCards = input.Split(':');
                string player = playerAndCards[0];
                string[] cards = playerAndCards[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (!cardsInPlayers.ContainsKey(player))
                {
                    cardsInPlayers[player] = new Dictionary<string, int>();
                }

                foreach (string card in cards)
                {
                    if (!cardsInPlayers[player].ContainsKey(card))
                    {
                        int value = GetCardValue(card);
                        cardsInPlayers[player].Add(card, value);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> cardsInPlayer in cardsInPlayers)
            {
                Console.WriteLine("{0}: {1}", cardsInPlayer.Key, cardsInPlayer.Value.Values.Sum());
            }
        }

        private static int GetCardValue(string card)
        {
            int value = 0;
            char power = card[0];
            char type = card[card.Length - 1];
            switch (power)
            {
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    value += power - 48;
                    break;
                case '1':
                    value += 10;
                    break;
                case 'J':
                    value += 11;
                    break;
                case 'Q':
                    value += 12;
                    break;
                case 'K':
                    value += 13;
                    break;
                case 'A':
                    value += 14;
                    break;
            }

             switch (type)
            {
                case 'C':
                    value *= 1;
                    break;
                case 'D':
                    value *= 2;
                    break;
                case 'H':
                    value *= 3;
                    break;
                case 'S':
                    value *= 4;
                    break;
            }

            return value;
        }
    }
}
