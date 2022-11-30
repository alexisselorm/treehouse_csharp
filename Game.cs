using System;
using TreehouseDefense;

  class Game
  {
    public static void Main(){

      Map map = new Map(8,5);

      try{
        
      MapLocation maplocation = new MapLocation(40,20,map);
      }
      catch (Exception){
        Console.WriteLine("That map location is not on map");
      }
     
      
    }
  }
