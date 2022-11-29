using System;
using TreehouseDefense;

  class Game
  {
    public static void Main(){
      Console.WriteLine("Hello");
    
    Tower tower = new Tower();
      Map map = new Map();
      map.Width = 8;
      map.Height= 5;
      int area  = map.Width * map.Height;
    }
  }
