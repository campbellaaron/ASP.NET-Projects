using System;
namespace TowerDefense
{
    public class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.OnMap(this)){
                throw new OutOfBoundsException(x + "," + y + " is outside the boundary of the map.");
            }
        }
    }
}
