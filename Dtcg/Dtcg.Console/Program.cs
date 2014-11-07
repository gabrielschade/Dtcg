using Otcg.Library.Cards;
using Otcg.Library.Player;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otcg.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Dados\GitHub\Otcg\Otcg\Otcg.Library\CardFiles\Deck1.js";

            JArray deckJson = JArray.Parse(File.ReadAllText(path));
            List<Creature> creatures = deckJson.ToObject<List<Creature>>();
            List<Card> deck = new List<Card>();

            foreach (Creature creature in creatures)
                deck.Add(creature);

            Card[] deck2 = new Card[deck.Count];
            deck.CopyTo(deck2);
            Otcg.Library.Game.Main game = new Library.Game.Main();

            Hero player1 = new Hero(deck);
            Hero player2 = new Hero(deck2.ToList() );

            game.Execute(player1, player2);

            //game.Execute()

        }
    }
}
