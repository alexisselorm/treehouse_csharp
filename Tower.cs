namespace TreehouseDefense{
  class Tower{
    private readonly MapLocation _location;
       // Constant variables
    private const int _range=1;
    private const int _power =1;

    public Tower(MapLocation location)
    {
      _location = location;
    }
    public void FireOnInvaders(Invader[] invaders)
    {
   
      
      foreach(Invader invader in invaders){
        // Do something with invader
        if(invader.IsActive && _location.InRangeOf(invader.Location,_range))
        {
          invader.DecreaseHealth(_power);
// Forcefully end the loop after the tower shoots one invader once.
          break;
        }
      }
    }
  }
}