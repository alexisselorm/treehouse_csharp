namespace TreehouseDefense
{
  class MapLocation : Point
  {
// Constructor. Name your constructor the same as your class.
// base is the parent class, here it is Point
    public MapLocation(int x, int y, Map map) : base(x, y)
    {
// Using the map's onmap method to determine if the map location being constructed is on the map. 
// 'This' refers to the object that is being constructed. 'In this scope'
     if(!map.OnMap(this))
     {
       throw new OutOfBoundsException(this+ " is outside the boundaries of the map");
     }
    }

// Checks how far the invader is from the tower.
    public bool InRangeOf(MapLocation location, int range)
{
       return DistanceTo(location) <= range;
  }
    
  }
}