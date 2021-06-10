using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Stacks
{
    public class FloodFill
    {
        public int[][] FloodFillMethod(int[][] image, int sr, int sc, int newColor)
        {
            int currentPixel = image[sr][sc];
            if(currentPixel != newColor)
            {
                DFS(image, sr, sc, newColor, currentPixel);
            }
            return image;

        }

        public void DFS(int[][] image,int r,int c,int newColor,int currentPixel)
        {
            if(image[r][c]== currentPixel)
            {
                image[r][c] = newColor;
                if (r >= 1) DFS(image, r - 1, c, newColor, currentPixel);
                if (c >= 1) DFS(image, r, c - 1, newColor, currentPixel);
                if (r +1 < image.Length) DFS(image, r + 1,c, newColor, currentPixel);
                if (c+1 < image[0].Length) DFS(image, r, c + 1, newColor, currentPixel);
            }
        }

        public void fill(int[][] image, int r, int c, int newColor, int currentPixel)
        {
            if (r < 0 || c < 0 || r >= image.Length || c>=image[0].Length || image[r][c]!= currentPixel)
            {
                return;
            }
            image[r][c] = newColor;
            fill(image, r - 1, c, newColor, currentPixel);
            fill(image, r , c-1, newColor, currentPixel);
            fill(image, r + 1, c, newColor, currentPixel);
            fill(image, r, c +1 , newColor, currentPixel);

        }
    }
}
