namespace TreehouseDefense{
  class Map{
    // If scope is not specifiend, it is private by default;
    // Instance variables
    // To stop the user from changing the size of the map after it has been created, use the readonly modifier
    public readonly int Width;
    public readonly int Height;

    // Object instantiation, use constructors. Constructors don't return anything
    public Map(int width, int height){
      // method-level variables
      Width = width;
      Height = height;
    }
  }
}