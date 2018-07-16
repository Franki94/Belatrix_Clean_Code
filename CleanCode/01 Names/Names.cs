using System.Drawing;

namespace CleanCode.Names
{
    public class GraficWriter
    {
        public Bitmap WriteInImage(string fileName)
        {
            var bitmapFile = new Bitmap(fileName);
            var graficImage = Graphics.FromImage(bitmapFile);
            graficImage.DrawString("a", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 0));
            graficImage.DrawString("b", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 20));
            graficImage.DrawString("c", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 30));
            return bitmapFile;
        }
    }
}
