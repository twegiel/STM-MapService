using System;
using System.Drawing;

namespace MapService
{
    internal static class MapCalculationUtilities
    {
        public static Size GetImageSize(string pathToImage)
        {
            var img = Image.FromFile(pathToImage);
            return new Size(img.Width, img.Height);
        }

        public static Point GetPointOnOriginalSize(Size originalSize, Size thumbnailSize, int x, int y)
        {
            var newX = ((double)x / thumbnailSize.Width) * originalSize.Width;
            var newY = ((double)y / thumbnailSize.Height) * originalSize.Height;

            return new Point((int)newX, (int)newY);
        }
    }
}
