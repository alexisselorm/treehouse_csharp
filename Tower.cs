namespace TreehouseDefense{
  class Tower{
    private readonly MapLocation _location;

    public Tower(MapLocation location)
    {
      _location = location;
    }
    public void FireOnInvaders(Invader[] invaders)
    {
      foreach(Invader invader in invaders){
        // Do something with invader
        if(invader.IsActive && _location.InRangeOf(invader.Location,1))
        {
          invader.DecreaseHealth(1);
// Forcefully end the loop after the tower shoots one invader
          break;
        }
      }
    }
  }
}