namespace CrowsCauldronDefense
{
  class Map
  {
    //Accessibility levels determine which fields can be used outside of its class, and by what.
    //Private fields are only accessible to metods in the class they're declared in.
    //Public fields can be accessed by any method in any field.
    public readonly int Width;
    public readonly int Height;
    
    //Constructor methods call constructors when an object is created.
    //Any parameters added must be provided for the object to be constructed.
    public Map(int width, int height)
    {
      Width = width;
      Height = height;
    }
    
    public bool OnMap(Point point)
    {
      return point.X >= 0 && point.X < Width &&
             point.Y >= 0 && point.Y < Height;
      
      //bool inBounds = !(point.X < 0 || point.X >= Width || point.Y < 0 || point.Y >= Height);
      
      //return inBounds;
    }
  }
}
