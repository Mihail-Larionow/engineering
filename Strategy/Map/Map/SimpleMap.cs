using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    //Класс SimpleMap
    internal class SimpleMap
    {
        StrategyRoute strategy;
        string[] places;

        //Конструктор SimpleMap
        public SimpleMap(StrategyRoute strategy, string[] places)
        {
            this.strategy = strategy;
            this.places = places;
        }

        //Метод Route
        public void Route()
        {
            strategy.FindRoute(places);
        }

        //Метод ShowMap
        public void ShowMap()
        {
            Console.WriteLine();
            Console.WriteLine("Карта: ");
            for (int i = 0; i < places.Length-1; i++)
                Console.Write(places[i] + " ---- ");
            Console.Write(places[places.Length - 1]);
            Console.WriteLine();
        }

        //Метод ShowRoute
        public void ShowRoute()
        {
            Console.WriteLine();
            Console.WriteLine(strategy.ToString());
            for (int i = 0; i < places.Length-1; i++)
                if(places[i] != "")
                    Console.Write(places[i] + " ---> ");
            Console.Write(places[places.Length - 1]);
            Console.WriteLine();
        }
    }
}
