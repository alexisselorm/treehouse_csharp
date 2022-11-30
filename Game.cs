using System;
using TreehouseDefense;

  class Game
  {
    public static void Main(){
      Console.WriteLine("Hello");

      Map map = new Map(8,5);

      MapLocation x = new MapLocation(4,2);
      bool isOnMap = map.OnMap(x);
      Console.WriteLine(isOnMap);
      x = new MapLocation(8,5);
      isOnMap = map.OnMap(x);
      Console.WriteLine(isOnMap);
      Console.WriteLine(x.DistanceTo(5,5));

      // Type checks
      Console.WriteLine(x is MapLocation);
      Console.WriteLine(x is Point);
      Point point = new Point(3,3);
      Console.WriteLine(point is MapLocation);
      
    }
  }
