using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Megajewel
{
    class Predictor
    {
        internal static void Predict(Gem[,] grid)
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y= 0; y < 8; y++)
                {
                    Gem originalMe = grid[x, y];
                    originalMe.SuggestedDirection = Direction.None;
                    originalMe.SuggestedPower = 0;
                    if (originalMe.IsUnmovable()) continue;
                    Point source = new Point(x, y);
                    foreach (Direction direction in Directions)
                    {
                        Point target = MoveInDirection(source, direction);
                        if (target.X < 0 || target.Y < 0 || target.X >= 8 || target.Y >= 8) continue;
                        Gem originalHim = grid[target.X, target.Y];
                        if (originalHim.IsUnmovable()) continue;
                        if (originalHim.GemColor == GemColor.Hypercube)
                        {
                            originalMe.SuggestedDirection = direction;
                            originalMe.SuggestedPower = 3;
                            break;
                        }
                        
                        // Test switch
                        grid[x, y] = originalHim;
                        grid[target.X, target.Y] = originalMe;

                        int i = target.X - 1;
                        int j = target.Y;
                        int left = 0;
                        int right = 0;
                        int up = 0;
                        int down = 0;
                        while (i >= 0 && grid[i, j].GemColor == originalMe.GemColor) { i--; left++; }
                        i = target.X + 1;
                        while (i < 8 && grid[i, j].GemColor == originalMe.GemColor) { i++; right++; }

                        int leftRightPower = left + 1 + right;
                        if (leftRightPower >= 3 && leftRightPower > originalMe.SuggestedPower)
                        {
                            originalMe.SuggestedDirection = direction;
                            originalMe.SuggestedPower = leftRightPower;
                        }

                        i = target.X;
                        j = target.Y - 1;
                        while (j >= 0 && grid[i,j].GemColor == originalMe.GemColor) { j--; up++; }
                        j = target.Y + 1;
                        while (j < 8 && grid[i, j].GemColor == originalMe.GemColor) { j++; down++; }

                        int upDownpower = up + 1 + down;
                        if (upDownpower >= 3 && upDownpower > originalMe.SuggestedPower)
                        {
                            originalMe.SuggestedDirection = direction;
                            originalMe.SuggestedPower = upDownpower;
                        }

                        // Back to normal
                        grid[x, y] = originalMe;
                        grid[target.X, target.Y] = originalHim;
                    }
                }
            }
        }

        internal static Point MoveInDirection(Point from, Direction direction)
        {
            switch(direction)
            {
                case Direction.Down: return new Point(from.X, from.Y + 1);
                case Direction.Up: return new Point(from.X, from.Y - 1);
                case Direction.Left: return new Point(from.X - 1, from.Y);
                case Direction.Right: return new Point(from.X + 1, from.Y);
            }
            return from;
        }

        internal static Direction[] Directions = new Direction[]
        {
            Direction.Left, Direction.Right, Direction.Up,Direction.Down
        };
    }
}
