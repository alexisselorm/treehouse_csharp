using System;
using TreehouseDefense;

  class Game
  {
    public static void Main(){

      Map map = new Map(8,5);

      try{
        
      MapLocation maplocation = new MapLocation(40,20,map);
      }
      // The exception message received here comes from the constructor in mapLocation where the exception is first caught and a message is set.
      catch (OutOfBoundsException ex){
        Console.WriteLine(ex.Message);
      }
      catch (TreehouseDefenseException){
        Console.WriteLine("Unhandled TreeHouseDefenseException");
      }
      catch (Exception){
        Console.WriteLine("Unhandled Exception");
      }
     
      
    }
  }
