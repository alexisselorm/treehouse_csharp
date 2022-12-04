using System;
namespace TreehouseDefense{
  class Tower{
    private readonly MapLocation _location;
       // Constant readonly variables
    protected virtual int Range{get;}=1;
    protected virtual int Power {get;}=1;
    protected virtual double Accuracy {get;}= .75;

    private static readonly Random _random = new Random();

    public Tower(MapLocation location)
    {
      _location = location;
    }

    public bool IsSuccessfulShot(){
      // The chance that a tower hits an invader is 75%(.75) so if the random number generated is less than .75, the shot hit the target, miss otherwise.
      return _random.NextDouble() < Accuracy;
    }
    
    public void FireOnInvaders(Invader[] invaders)
    {
   
      
      foreach(Invader invader in invaders){
        // Do something with invader
        if(invader.IsActive && _location.InRangeOf(invader.Location,Range))
        {
          if(IsSuccessfulShot()){
            
           invader.DecreaseHealth(Power);
            Console.WriteLine("Shot at and hit an invader");

            if(invader.IsNeutralized){
              Console.WriteLine("Neutralized an invader");
            }
          }
          else
          {
            Console.WriteLine("Shot at and missed an invader");
            
          }
// Forcefully end the loop after the tower shoots one invader once.
          break;
        }
      }
    }
  }
}