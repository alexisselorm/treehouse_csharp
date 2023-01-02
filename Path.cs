namespace TreehouseDefense{
  class Path{

    private readonly MapLocation[] _path;

    // Returns the path's length
    public int Length => _path.Length;
    
    public Path(MapLocation[] path)
    {
      _path = path;
    }
    public MapLocation GetLocationAt(int pathStep)
    {
      //If a path step isn't in the range of our map location, return null; If you can, avoid using exceptions.
    return (pathStep < _path.Length) ? _path[pathStep] : null;
      
    }
    public bool IsOnPath(MapLocation location){
      foreach (var pathLocation in _path)
      {
        // Object equality
        if(location == pathLocation){
        return true;
        }
      }
      return false;
    }
  }
} 