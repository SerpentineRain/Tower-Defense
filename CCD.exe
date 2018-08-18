using System;
namespace CrowsCauldronDefense
{
    class Game
    {
        public static void Main()
        {
          Map map = new Map(8, 5);
          
          Point point = new Point(4, 2); 
          bool isOnMap = map.OnMap(point);
          Console.WriteLine(isOnMap);
          
          point = new Point(8, 5);
          isOnMap = map.OnMap(point);
          Console.WriteLine(isOnMap);
        }
    }
}

/*Notes:
Static methods can be called directly onto the class(Ex.Console.WriteLine();). 

While constructing a class, the Capital name is used for public variables outside
of the constructor. Within the constructor you use camelCase <-. Usually anything
past the main variables that are going to be used outside of the class wil be lowercase. 

If a method is not static, then you have to construct a new instance of it before using it.

The main method has to be a static method because it allows the main method to be called 
without first creating a game method. 

Instance method like .OnMap or .DistanceTo have to be called on an object (an instance of a class).

Math.Sqrt and Game.Main are static methods.
