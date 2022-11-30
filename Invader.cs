namespace TreehouseDefense{
  class Invader{

    // Accessor Methods. Getters and setters
    // Syntactic sugar for getters and setters
    // Other class will get the invader's location on the map, but they can't set it. This will allow only the invader itself to set its new location
    public MapLocation Location{ get; private set; }
  }
}