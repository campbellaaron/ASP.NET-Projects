using System;
namespace TowerDefense
{
    public class TowerDefenseException : Exception
    {
        public TowerDefenseException(){
            
        }

        public TowerDefenseException(string v)
        {
        }
    }

    class OutOfBoundsException : TowerDefenseException
    {
		public OutOfBoundsException()
		{

		}

        public OutOfBoundsException(string v) : base(v)
        {
        }
    }
}
