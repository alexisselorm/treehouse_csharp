namespace TreehouseDefense{
  class Invader{
    
    private MapLocation _location;
    
    // Accessor Methods. Getters and setters
    // Syntactic sugar for getters and setters
    public MapLocation Location{
      get{
        return _location;
      }
      set{
        _location = value
      }
    }
  }
}