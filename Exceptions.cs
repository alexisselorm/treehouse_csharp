namespace TreehouseDefense{
  // All custom exceptions must inherit from System.Exception
  class TreehouseDefenseException : System.Exception
  {
// Default constructors
  public TreehouseDefenseException(){}

  public TreehouseDefenseException(string message) : base(message)
     {
        
     }
    
  }
// The outofboundsexception is a subclass of the treehousedefenseexception
  class OutOfBoundsException : TreehouseDefenseException 
  {
// Default constructors automatically call the default constructor of its base class
  public OutOfBoundsException(){}

   public OutOfBoundsException(string message) : base(message)
   {

   }
  }
}