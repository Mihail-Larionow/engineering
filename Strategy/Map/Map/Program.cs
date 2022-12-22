using Map;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Массив мест на карте
            string[] places_1 = { "Точка А", "Остановка Майора Грома", "Эрмитаж", "Пятерочка", "Остановка Генерала Якамото", "Биг-бен", "Магнит", 
                "Остановка Пр.Стачек", "Нотр-Дам", "ВашДом", "Гипермаркет Метро", "Собор Парижской Богоматери", "Точка Б"};
            string[] places_2 = { "Точка А", "Остановка Майора Грома", "Эрмитаж", "Пятерочка", "Остановка Генерала Якамото", "Биг-бен", "Магнит",
                "Остановка Пр.Стачек", "Нотр-Дам", "ВашДом", "Гипермаркет Метро", "Собор Парижской Богоматери", "Точка Б"};
            string[] places_3 = { "Точка А", "Остановка Майора Грома", "Эрмитаж", "Пятерочка", "Остановка Генерала Якамото", "Биг-бен", "Магнит",
                "Остановка Пр.Стачек", "Нотр-Дам", "ВашДом", "Гипермаркет Метро", "Собор Парижской Богоматери", "Точка Б"};
            string[] places_4 = { "Точка А", "Остановка Майора Грома", "Эрмитаж", "Пятерочка", "Остановка Генерала Якамото", "Биг-бен", "Магнит",
                "Остановка Пр.Стачек", "Нотр-Дам", "ВашДом", "Гипермаркет Метро", "Собор Парижской Богоматери", "Точка Б"};
            string[] places_5 = { "Точка А", "Остановка Майора Грома", "Эрмитаж", "Пятерочка", "Остановка Генерала Якамото", "Биг-бен", "Магнит",
                "Остановка Пр.Стачек", "Нотр-Дам", "ВашДом", "Гипермаркет Метро", "Собор Парижской Богоматери", "Точка Б"};

            //Экземпляры класса StrategyRoute
            StrategyRoute route_1 = new CarRoute();
            StrategyRoute route_2 = new BicycleRoute();
            StrategyRoute route_3 = new BusRoute();
            StrategyRoute route_4 = new SightRoute();
            StrategyRoute route_5 = new FootRoute();

            SimpleMap map = new SimpleMap(route_1, places_1); //Экземпляр класса Map
            map.ShowMap(); //Вызов метода ShowMap
            map.Route(); //Вызов метода Route
            map.ShowRoute(); //Вызов метода ShowRoute

            map = new SimpleMap(route_2, places_2);
            map.Route();
            map.ShowRoute();

            map = new SimpleMap(route_3, places_3);
            map.Route();
            map.ShowRoute();

            map = new SimpleMap(route_4, places_4);
            map.Route();
            map.ShowRoute();

            map = new SimpleMap(route_5, places_5);
            map.Route();
            map.ShowRoute();
        }
    }
}