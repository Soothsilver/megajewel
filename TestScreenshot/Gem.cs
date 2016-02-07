using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Megajewel
{
    [Serializable]
    public class Gem
    {
        public Color Color
        {
            get
            {
                switch(GemColor)
                {
                    case GemColor.Purple: return Color.Purple;
                    case GemColor.Blue: return Color.Blue;
                    case GemColor.Green: return Color.Green;
                    case GemColor.IrrelevantArtifact: return Color.Black;
                    case GemColor.Dirt: return Color.Maroon;
                    case GemColor.Hypercube: return Color.HotPink;
                    case GemColor.Orange: return Color.Orange;
                    case GemColor.Red: return Color.Red;
                    case GemColor.White: return Color.White;
                    case GemColor.Yellow: return Color.Yellow;
                    case GemColor.Unrecognized: return Color.DarkRed;
                    default: return Color.DarkRed;
                }
            }
        }

        internal bool IsUnmovable()
        {
            return GemColor == GemColor.Dirt || GemColor == GemColor.Unrecognized || GemColor == GemColor.IrrelevantArtifact;
        }

        public GemColor GemColor;
        public GemAuxiliaryInfo GemAuxiliaryInfo;
        [NonSerialized]
        public Bitmap Bitmap;
        public byte[] BitmapData;
        public Histograms Histograms;
        public int Inaccuracy;
        public int X;
        public int Y;

        public Direction SuggestedDirection;
        public int SuggestedPower;

        public void Preserialization()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                BitmapData = ms.ToArray();
            }
        }
        public void Postdeserialization()
        {
            MemoryStream ms = new MemoryStream(BitmapData);
            Bitmap = new Bitmap(ms);
            // Intentional memory leak, see http://stackoverflow.com/a/1053123/1580088
        }

        public Gem(GemColor gemColor, Bitmap bitmap, int x = 0, int y = 0)
        {
            Bitmap = bitmap;
            X = x;
            Y = y;
            GemColor = gemColor;
            Histograms = Histograms.Calculate(bitmap);
        }
        internal static Gem Unknown()
        {
            return new Gem(GemColor.Unrecognized, new Bitmap(112,112));
        }
    }
    [Serializable]
    public enum GemColor
    {
        Yellow,
        Green,
        Purple,
        White,
        Red,
        Orange,
        Blue,
        Unrecognized,
        IrrelevantArtifact,
        Hypercube,
        Dirt
    }
    [Serializable]
    public enum GemAuxiliaryInfo
    {
        Plain,
        Dark,
        Stone,
        DarkStone,
        Gold,
        DarkGold,
        Artifact,
        BonusFire,
        BonusStar

    }
    [Serializable]
    public enum Direction
    {
        Left,
        Right,
        Up,
        Down,
        None
    }
}
