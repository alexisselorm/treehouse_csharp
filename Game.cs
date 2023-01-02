using System;
using TreehouseDefense;

  class Game
  {
    public static void Main(){

      Map map = new Map(8,5);

      try{
        Path path = new Path(
        new []  {
             new MapLocation(0,2,map),
             new MapLocation(1,2,map),
             new MapLocation(2,2,map),
             new MapLocation(3,2,map),
             new MapLocation(4,2,map),
             new MapLocation(5,2,map),
             new MapLocation(6,2,map),
             new MapLocation(7,2,map)
            }
        );

        MapLocation location = new MapLocation(0,2,map);
        if(path.IsOnPath(location)){
          Console.WriteLine($"{location} is on path");
          return;
        }


        Invader[] invaders = {
          new ShieldedInvader(path),
          new Invader(path),
          new Invader(path),
          new Invader(path)
          };

        Tower[] towers = {
          new Tower(new MapLocation(1,3,map)),
          new Tower(new MapLocation(3,3,map)),
          new Tower(new MapLocation(5,3,map))
        };
        
        Level level = new Level(invaders){
          // Assigning the towers property inline, as the object is being constructed
          Towers=towers
        };
        bool playerWon = level.Play();

        Console.WriteLine("Player " + (playerWon ? "won" :"lost"));
        
      // MapLocation location = path.GetLocationAt(5);
      //   if(location != null){
      // Console.WriteLine(location.X+ ","+location.Y);
      //   }
      }
      // The exception message received here comes from the constructor in mapLocation where the exception is first caught and a message is set.
      catch (OutOfBoundsException ex){
        Console.WriteLine(ex.Message);
      }
      catch (TreehouseDefenseException){
        Console.WriteLine("Unhandled TreeHouseDefenseException");
      }
      catch (Exception ex){
        Console.WriteLine("Unhandled Exception" +ex);
      }
     
      
    }
  }
