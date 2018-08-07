namespace CrowsCauldronDefense
{
  class Map
  {
    //Accessibility levels determine which fields can be used outside of its class, and by what.
    //Private fields are only accessible to metods in the class they're declared in.
    //Public fields can be accessed by any method in any field.
    public int Width;
    public int Height;
    //Constructor methods call constructors when an object is created.
    //Any parameters added must be provided for the object to be constructed.
    Map(int width, int height)
    {
      Width = width;
      Height = height;
    }
  }
}
