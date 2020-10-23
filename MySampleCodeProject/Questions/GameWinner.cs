﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MySampleCodeProject.Questions
{
    public class GameWinner
    {
        //Time Complexity - O(N), traversing through each pieces
        //Space Complexity - O(1)
        public string gameWinner(string colors)
        {
            //declaring counters for bob and wendy
            int bobCounter = 0;
            int wendyCounter = 0;
            int count = 1;

            //Iterating through each character of the string
            for (int i = 1; i < colors.Length; i++)
            {
                //if the current color is equals to previous one, increment the counter
                if (colors[i] == colors[i - 1])
                    count++;
                //if the colors does not match or we are at the end of the string(where we cannot find the i-1)
                //then check whose previous color is before and taking the chance of play from the counter (>=3)
                if (colors[i] != colors[i - 1] || i == colors.Length - 1)
                {
                    if (count >= 3)
                    {
                        //if the color is w, then calcultating the chance for wendy
                        if (colors[i - 1] == 'w')
                            wendyCounter += count - 2;
                        //else calculate for bob
                        else
                            bobCounter += count - 2;
                    }
                    //resetting the counter
                    count = 1;
                }
            }

            //return the game winner by calculating who has the chance to win by comparing the both players counter
            return wendyCounter > bobCounter ? "wendy" : "bob";
        }

    }
}
