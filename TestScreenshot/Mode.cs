using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Megajewel
{
    public abstract class Mode
    {
        public static List<Mode> AllModes = new List<Mode>();
        static Mode()
        {
            AllModes.Add(new ClassicMode());
            AllModes.Add(new DiamondMine());
            AllModes.Add(new LightningMode());
        }

        public abstract Rectangle GetField();
        internal abstract Point GetGemCenter(int x, int y);
    }
    public class ClassicMode : Mode
    {
        public override string ToString()
        {
            return "Classic Mode";
        }
        internal override Point GetGemCenter(int x, int y)
        {
            return new Point(598 + x * 112 + 56, 66 + y * 112 + 56);
        }
        public override Rectangle GetField()
        {
            return new Rectangle(598, 66, 896, 896);
        }
    }
    public class DiamondMine : Mode
    {
        public override string ToString()
        {
            return "Diamond Mine Mode";
        }
        internal override Point GetGemCenter(int x, int y)
        {
            return new Point(572 + x * 112 + 56, 115 + y * 112 + 56);
        }
        public override Rectangle GetField()
        {
            return new Rectangle(572, 115, 896, 896);
        }
    }
    public class LightningMode : Mode
    {
        public override string ToString()
        {
            return "Lightning Mode";
        }
        internal override Point GetGemCenter(int x, int y)
        {
            return new Point(598 + x * 112 + 56, 114 + y * 112 + 56);
        }
        public override Rectangle GetField()
        {
            return new Rectangle(598, 114, 896, 896);
        }
    }
}
