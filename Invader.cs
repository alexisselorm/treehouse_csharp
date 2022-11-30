namespace TreehouseDefense{
  class Invader{

    private int _pathStep = 0;
    private readonly Path _path;
    // Accessor Methods. Getters and setters
    // Syntactic sugar for getters and setters
    // Other class will get the invader's location on the map, but they can't set it. This will allow only the invader itself to set its new location
    public MapLocation Location
    {
      get{
        // Get the invader's current location. This is a computed property.
      return _path.GetLocationAt(_pathStep);
    } 
     private set; }

    // Since the setter is private we can only set the location of an invader in its class
    public Invader (Path path) {
      _path = path
    }
    public void Move()
    {
      _pathStep+=1;
      
    }
  }
}