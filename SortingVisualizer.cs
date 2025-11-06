using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    public class SortingVisualizer
    {
        private readonly Panel panel;
        private readonly int delay = 100;
        private readonly Brush defaultBrush = Brushes.SkyBlue;
        private readonly Brush compareBrush = Brushes.OrangeRed;

        public SortingVisualizer(Panel panel)
        {
            this.panel = panel;
        }

        public async Task DrawCirclesAsync(int[] array, int indexA, int indexB)
        {
            using (Graphics g = panel.CreateGraphics())
            {
                g.Clear(Color.White);
                int circleSize = Math.Max(20, panel.Width / (array.Length * 2));
                int centerY = panel.Height / 2;
                int startX = (panel.Width - (array.Length * (circleSize + 5))) / 2;

                for (int i = 0; i < array.Length; i++)
                {
                    int x = startX + i * (circleSize + 5);
                    int y = centerY - circleSize / 2;

                    Brush brush = (i == indexA || i == indexB) ? compareBrush : defaultBrush;
                    g.FillEllipse(brush, x, y, circleSize, circleSize);

                    var sf = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    g.DrawString(array[i].ToString(), SystemFonts.DefaultFont, Brushes.Black, new RectangleF(x, y, circleSize, circleSize), sf);
                }
            }
            await Task.Delay(delay);
        }

        public async Task DrawBarsAsync(int[] array, int indexA, int indexB)
        {
            using (Graphics g = panel.CreateGraphics())
            {
                g.Clear(Color.White);

                int barWidth = Math.Max(5, panel.Width / (array.Length + 1));
                float scale = (float)panel.Height / array.Max();

                var font = new Font("Segoe UI", 8);

                for (int i = 0; i < array.Length; i++)
                {
                    int barHeight = (int)(array[i] * scale * 0.85);
                    int x = i * barWidth;
                    int y = panel.Height - barHeight;

                    Brush brush = (i == indexA || i == indexB) ? compareBrush : defaultBrush;
                    g.FillRectangle(brush, x, y, barWidth - 2, barHeight);
                    string value = array[i].ToString();
                    SizeF size = g.MeasureString(value, font);
                    g.DrawString(value, font, Brushes.Black, x + (barWidth - size.Width) / 2, y - size.Height - 2);
                }
            }
            await Task.Delay(delay);
        }
    }
}
