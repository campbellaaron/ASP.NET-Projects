﻿using System;
namespace TowerDefense
{
    class Game {
        public static void Main(){
            Map map = new Map(8,5);

            try {
				Path path = new Path(
	                new []{
						new MapLocation(0,2, map),
						new MapLocation(1,2, map),
						new MapLocation(2,2, map),
						new MapLocation(3,2, map),
						new MapLocation(4,2, map),
						new MapLocation(5,2, map),
						new MapLocation(6,2, map),
						new MapLocation(7,2, map)
					}
                );

            } 
            catch (OutOfBoundsException ex){
                Console.WriteLine(ex.Message);
            }
            catch (TowerDefenseException){
                Console.WriteLine("Unhandled TowerDefense Exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception" + ex);
            }

        }
    }
}