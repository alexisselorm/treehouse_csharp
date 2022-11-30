namespace TreehouseDefense{
  class Path{

    private readonly MapLocation[] _path;
    
    public Path(MapLocation[] path)
    {
      _path = path;
    }
    public GetLocationAtl(int pathStep)
    {
      //If a path step isn't in the range of our map location, return null; If you can, avoid using exceptions.
      if(pathStep < _path.Length)
      {
      return _path[pathStep];
      }
      else
      {
        return null;
      }
    }
    
  }
}