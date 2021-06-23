using System;

namespace FindBus
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRoute route122 = new BusRoute(122, "Nugegoda", "Colombo");
            BusRoute route46 = new BusRoute(46, "Wattala", "Maharagama");

            //BusRoute[] routes =
            //{
            //    route122,
            //    route46,
            //    new BusRoute(100, "University", "Boralesgamuwa"),
            //    new BusRoute(55, "Anuradhapura", "Colombo")
            //};

            //foreach (BusRoute route in routes)
            //{
            //    Console.WriteLine(route);
            //}

            BusRoute[] routes = new BusRoute[4];

            routes[0] = route122;
            routes[1] = route46;
            routes[2] = new BusRoute(100, "University", "Boralesgamuwa");
            routes[3] = new BusRoute(55, "Anuradhapura", "Colombo");

            Console.WriteLine("Looking up individual elements:");
            Console.WriteLine($"The third route is {routes[2]}");
            BusRoute lastRoute = routes[^1];  // or routes[routes.Length-1];
            Console.WriteLine($"The last route is {lastRoute}");

            Console.WriteLine("\r\nEnumerating with for");
            for (int i = 0; i < routes.Length; i++)
                Console.WriteLine($"{i}: {routes[i]}");

        }
    }
}
