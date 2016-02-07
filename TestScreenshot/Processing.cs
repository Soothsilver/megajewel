using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Megajewel
{
    public class Processing
    {
        public Gem[,] Grid = new Gem[8, 8];
        public DateTime DiamondMineLastCleared = DateTime.Now;
        public bool DiamondMineCleared = false;


        MegajewelForm Form;
        public Processing(MegajewelForm form)
        {
            Form = form;
        }

        public void Process(Bitmap fullScreenshot)
        {
            Mode mode = Form.CurrentMode;
            Bitmap field = fullScreenshot.Clone(mode.GetField(), fullScreenshot.PixelFormat);
            if (Form.CurrentMode.GetType() == typeof(DiamondMine))
            {
                Bitmap cleared = fullScreenshot.Clone(new Rectangle(582, 788, 875, 6), fullScreenshot.PixelFormat);
                Color averageColor = Histograms.GetAverageColor(cleared);
                if (averageColor.R >= 200 && averageColor.G >= 200)
                {
                    DiamondMineCleared = true;
                    DiamondMineLastCleared = DateTime.Now;
                }
                else
                {
                    if (DiamondMineLastCleared.AddSeconds(1) < DateTime.Now)
                    {
                        DiamondMineCleared = false;
                    }
                }
                cleared.Dispose();
            }
            
            
            // Update Grid from image
            for (int x = 0; x < 8; x++)
            {
                for (int y= 0;y <8;y++)
                {
                    Bitmap thisGem = field.Clone(new Rectangle(x * 112, y * 112, 112, 112), field.PixelFormat);
                    Grid[x, y] = new Gem(GemColor.Unrecognized, thisGem, x, y);
                }
            }

            // Recognize
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Grid[x, y].GemColor = Form.RecognitionStrategy.GetColor(Grid[x, y]);
                }
            }

            // Find options
            Predictor.Predict(Grid);

            // Update Field Image
            if (Form.pictureBoxField.Image != null)
            {
                Form.pictureBoxField.Image.Dispose();
            }
            Form.pictureBoxField.Image = field;
            // Update Grid based on Grid
            Action a = () =>
            {
                Form.pictureBoxGrid.Refresh();
            };
            Form.pictureBoxGrid.Invoke(a);
            
        }
    }
}
