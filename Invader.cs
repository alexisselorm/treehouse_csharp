namespace TreehouseDefense{
  class Invader{

    private int _pathStep = 0;
    private readonly Path _path;

    // Readonly property
  protected virtual int stepSize { get;} =1;
    
    // Accessor Methods. Getters and setters
    // Syntactic sugar for getters and setters
    // Other class will get the invader's location on the map, but they can't set it. This will allow only the invader itself to set its new location
        // Get the invader's current location. This is a computed property.
    public MapLocation Location => _path.GetLocationAt(_pathStep);

    // Create a health property for the invader. Its getter is public so that users may see its health. but the setter is private. If other classes want to change the value or health, they can use the 'DecreaseHealth' method
    public virtual int Health { get; protected set; } = 2;

    // If invader has reached the end of the path
    public bool HasScored {
      get { return _pathStep >= _path.Length; }
      }
// Return true if invaders Health is less than or equal to 0
    public bool IsNeutralized => Health <=0;

    public bool IsActive => !(IsNeutralized || HasScored);

    // Since the setter is private we can only set the location of an invader in its class
    public Invader (Path path) {
      _path = path;
    }
    public virtual void Move() => _pathStep+=stepSize;

    public virtual void DecreaseHealth(int factor) =>   Health -= factor;
    
  }
}