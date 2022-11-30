namespace TreehouseDefense{
  class Invader{
    
    private MapLocation _location;
    
    // Accessor Methods. Getters and setters
    public MapLocation GetLocation()
    {
      return _location;
    }
    public void SetLocation(MapLocation value)
    {
     _location = value; 
    }
  }
}