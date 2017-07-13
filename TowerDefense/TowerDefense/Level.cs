using System;
namespace TowerDefense
{
    public class Level
    {
        private readonly Invader[] _invaders;

        public Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        //returns true if the player wins; otherwise it's false
        public bool Play()
        {
            //Run until all invaders are neutralized or an invader reaches end of path
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {
                //Each tower has the opportunity to fire on an invader
                foreach(Tower tower in Towers){
                    tower.FireOnInvaders(_invaders);
                }

                //Count and move the invaders that are still active
                remainingInvaders = 0;
                foreach(Invader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();

                        if(invader.HasScored)
                        {
                            return false;
                        }

                        remainingInvaders++;
                    }
                }
			}
            return true;
        }
    }
}
