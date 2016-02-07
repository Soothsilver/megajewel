using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Megajewel
{
    public abstract class RecognitionStrategy
    {
        public static List<RecognitionStrategy> AllStrategies = new List<RecognitionStrategy>();
        static RecognitionStrategy()
        {
            AllStrategies.Add(new NoRecognitionStrategy());
        }
        public abstract GemColor GetColor(Gem gem);
    }
    public class NoRecognitionStrategy : RecognitionStrategy
    {
        public override GemColor GetColor(Gem gem)
        {
            return GemColor.Unrecognized;
        }
        public override string ToString()
        {
            return "Recognize Nothing";
        }
    }
    public class NearestHistogramStrategy : RecognitionStrategy
    {
        List<Gem> Database;
        public NearestHistogramStrategy(List<Gem> database)
        {
            Database = database;
        }
        public override GemColor GetColor(Gem gem)
        {
            if (Database.Count == 0) return GemColor.Unrecognized;
            Gem nearestGem = Database[0];
            int smallestDistance = Int32.MaxValue;
            foreach (Gem datagem in Database)
            {
                int dist = Histograms.GetDistance(gem.Histograms, datagem.Histograms);
                if (dist < smallestDistance)
                {
                    smallestDistance = dist;
                    nearestGem = datagem;
                }
            }
            gem.Inaccuracy = smallestDistance;
            return nearestGem.GemColor;
        }
        public override string ToString()
        {
            return "Nearest Histogram";
        }
    }
}
