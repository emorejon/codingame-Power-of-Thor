using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/*The main thing to remember on this puzzle is that the top left coordinate is (0,0)
which means that if you go down, on the y axis you are increasing y (Thor's position)
instead of reducing it. it could be counter intuitive if you come with the mind set 
of your regular Calculus I graphics.*/


class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTX = int.Parse(inputs[2]); // Thor's starting X position
        int initialTY = int.Parse(inputs[3]); // Thor's starting Y position

        // game loop
        while (true)
        {
            //empty string to store direction values. 
            string directionX = "";
            string directionY = "";
            
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.
            
            /*If thor's position in the x-axis is more than light's x coordinates
            Move west and update Thor's position*/
            if(initialTX > lightX){
                directionX = "W";
                initialTX--;
            }
            /*If thor's position in the x-axis is less than light's x coordinates
            Move east and update Thor's position*/
            else if(initialTX < lightX){
                directionX = "E";
                initialTX++;
            }
            /*If thor's position in the y-axis is more than light's y coordinates
            Move north and update Thor's position*/
            if(initialTY > lightY){
                directionY = "N";
                initialTY--;
            }
            /*If thor's position in the y-axis is less than light's y coordinates
            Move south and update Thor's position*/
            else if(initialTY < lightY){
                directionY = "S";
                initialTY++;
            }
            //print Y direction and X direction.
            Console.WriteLine(directionY + directionX);
        }
    }
}
