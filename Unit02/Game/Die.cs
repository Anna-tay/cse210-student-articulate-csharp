using System;


namespace Unit02.Game
{
    /// <summary>
    /// A small cube with a different number of spots on each of its six sides.
    /// 
    /// The responsibility of Die is to keep track of its currently rolled value and the points its
    /// worth.
    /// </summary> 
    
    public class Die
    {
        public int points; 
        public int value;
        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
        public Die()
        {
            points = 0;
            value = 1;
        }

        /// Generates a new random value and calculates the points for the die. Fives are 
        /// worth 50 points, ones are worth 100 points, everything else is worth 0 points
        public void Roll()
        {
            Random randomGenerator = new Random();
            value = randomGenerator.Next(1,7);

            points = 0;
            if (value == 1)
            {
                points = 100;

            }
            else if (value == 5)
            {
                points = 50;
            }

        }

    }


    
}