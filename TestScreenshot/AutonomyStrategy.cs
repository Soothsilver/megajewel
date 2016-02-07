using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using ManagedWinapi;

namespace Megajewel
{
    public abstract class AutonomyStrategy
    {
        public static List<AutonomyStrategy> AllStrategies = new List<AutonomyStrategy>();
        static AutonomyStrategy()
        {
            AllStrategies.Add(new DoNothingStrategy());
            AllStrategies.Add(new RandomMovementStrategy());
            AllStrategies.Add(new RandomSingleMoveStrategy());
            AllStrategies.Add(new RandomManyMovesStrategy());
            AllStrategies.Add(new SlowBestStrategy());
            AllStrategies.Add(new AllBestFastStrategy());
            AllStrategies.Add(new DiamondMineStrategy());
            AllStrategies.Add(new RegularMovesStrategy());
        }
        public abstract void Tick(MegajewelForm form);
    }
    public class DoNothingStrategy : AutonomyStrategy
    {
        public override void Tick(MegajewelForm form)
        {
            // Do nothing.
        }

        public override string ToString()
        {

            return "Autonomy: Do Nothing";
        }
    }
    public class AllBestFastStrategy : AutonomyStrategy
    {
        int ticksMissed;
        Random rgen = new Random();
        public override void Tick(MegajewelForm form)
        {
            
            var grid = form.Processing.Grid;

            List<Gem> bestGems = new List<Gem>();
            int bestPower = 1;
            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                {
                    Gem gem = grid[x, y];
                    if (gem.SuggestedPower == bestPower)
                    {
                        bestGems.Add(gem);
                    }
                    else if (gem.SuggestedPower > bestPower)
                    {
                        bestPower = gem.SuggestedPower;
                        bestGems.Clear();
                        bestGems.Add(gem);
                    }
                }
            if (bestGems.Count > 0)
            {
                foreach (Gem randomBestGem in bestGems)
                {
                    Point from = new Point(randomBestGem.X, randomBestGem.Y);
                    Point to = Predictor.MoveInDirection(from, randomBestGem.SuggestedDirection);
                    Point fromReal = form.CurrentMode.GetGemCenter(from.X, from.Y);
                    Point toReal = form.CurrentMode.GetGemCenter(to.X, to.Y);
                    Controller.MoveTo(fromReal.X, fromReal.Y);
                    Controller.HoldLeft();
                    Controller.MoveTo(toReal.X, toReal.Y);
                    Controller.ReleaseLeft();
                }
            }
        }
    }
    public class DiamondMineStrategy : AutonomyStrategy
    {
        int ticksMissed;
        Random rgen = new Random();
        public override void Tick(MegajewelForm form)
        {
            if (form.Processing.DiamondMineCleared) return;
            var grid = form.Processing.Grid;

            List<Gem> bestGems = new List<Gem>();
            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                {
                    Gem gem = grid[x, y];
                    if (gem.SuggestedPower >= 3)
                    {
                        bestGems.Add(gem);
                    }
                }
            if (bestGems.Count > 0)
            {
                foreach (Gem randomBestGem in bestGems)
                {
                    Point from = new Point(randomBestGem.X, randomBestGem.Y);
                    Point to = Predictor.MoveInDirection(from, randomBestGem.SuggestedDirection);
                    Point fromReal = form.CurrentMode.GetGemCenter(from.X, from.Y);
                    Point toReal = form.CurrentMode.GetGemCenter(to.X, to.Y);
                    Controller.MoveTo(fromReal.X, fromReal.Y);
                    Controller.HoldLeft();
                    Controller.MoveTo(toReal.X, toReal.Y);
                    Controller.ReleaseLeft();
                }
            }
        }
    }

    public class SlowBestStrategy : AutonomyStrategy
    {
        int ticksMissed;
        Random rgen = new Random();
        public override void Tick(MegajewelForm form)
        {

            ticksMissed++;
            if (ticksMissed < 5) return;
            ticksMissed = 0;
            var grid = form.Processing.Grid;

            List<Gem> bestGems = new List<Gem>();
            int bestPower = 1;
            for (int x= 0;x<8;x++)
                for (int y = 0; y< 8;y++)
                {
                    Gem gem = grid[x, y];
                    if (gem.SuggestedPower == bestPower)
                    {
                        bestGems.Add(gem);
                    }
                    else if (gem.SuggestedPower > bestPower)
                    {
                        bestPower = gem.SuggestedPower;
                        bestGems.Clear();
                        bestGems.Add(gem);
                    }
                }
            if (bestGems.Count > 0)
            {
                Gem randomBestGem = bestGems[rgen.Next(bestGems.Count)];
                Point from = new Point(randomBestGem.X, randomBestGem.Y);
                Point to = Predictor.MoveInDirection(from, randomBestGem.SuggestedDirection);
                Point fromReal = form.CurrentMode.GetGemCenter(from.X, from.Y);
                Point toReal = form.CurrentMode.GetGemCenter(to.X, to.Y);
                Controller.MoveTo(fromReal.X, fromReal.Y);
                Controller.HoldLeft();
                Controller.MoveTo(toReal.X, toReal.Y);
                Controller.ReleaseLeft();
            }
        }
    }
    public class RandomSingleMoveStrategy : AutonomyStrategy
    {
        public Random rgen = new Random();
        public override void Tick(MegajewelForm form)
        {
            int x = rgen.Next(7);
            int y = rgen.Next(7);
            Point p = form.CurrentMode.GetGemCenter(x, y);
            Point p2 = form.CurrentMode.GetGemCenter(x + 1, y);
            Controller.MoveTo(p.X, p.Y);
            Controller.HoldLeft();
            Controller.MoveTo(p2.X, p2.Y);
            Controller.ReleaseLeft();
        }

        public override string ToString()
        {
            return "Random Single Move";
        }
    }
    public class RandomManyMovesStrategy : AutonomyStrategy
    {
        public Random rgen = new Random();
        public override void Tick(MegajewelForm form)
        {
            for (int i = 0; i < 10; i++)
            {
                int x = rgen.Next(8);
                int y = rgen.Next(7);
                Point p = form.CurrentMode.GetGemCenter(x, y);
                Point p2 = form.CurrentMode.GetGemCenter(x, y + 1);
                Controller.MoveTo(p.X, p.Y);
                Controller.HoldLeft();
                Controller.MoveTo(p2.X, p2.Y);
                Controller.ReleaseLeft();
            }
        }

        public override string ToString()
        {
            return "Random Many Moves";
        }
    }
    public class RegularMovesStrategy : AutonomyStrategy
    {
        public Random rgen = new Random();
        int tick = 0;
        public override void Tick(MegajewelForm form)
        {
           tick++;
            if (tick % 2 == 0)
            {
                // Down
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y += 2)
                    {
                        Point p = form.CurrentMode.GetGemCenter(x, y);
                        Point p2 = form.CurrentMode.GetGemCenter(x, y + 1);
                        Controller.MoveTo(p.X, p.Y);
                        Controller.HoldLeft();
                        Controller.MoveTo(p2.X, p2.Y);
                        Controller.ReleaseLeft();
                    }
                }
            }
            else
            {
                // Right
                for (int y = 0; y < 8; y++)
                {
                    for (int x = 0; x < 8; x += 2)
                    {
                        Point p = form.CurrentMode.GetGemCenter(x, y);
                        Point p2 = form.CurrentMode.GetGemCenter(x + 1, y);
                        Controller.MoveTo(p.X, p.Y);
                        Controller.HoldLeft();
                        Controller.MoveTo(p2.X, p2.Y);
                        Controller.ReleaseLeft();
                    }
                }
            }
        }
    }
    public class RandomMovementStrategy : AutonomyStrategy
    {
        public Random rgen = new Random();
        public override void Tick(MegajewelForm form)
        {
            Controller.MoveTo(rgen.Next(0, 1680), rgen.Next(0, 1050));
        }

        public override string ToString()
        {
            return "Autonomy: Random Movement, No Click";
        }
    }
}
