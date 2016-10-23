using System.Drawing;

namespace MapService
{
    public struct Coordinates
    {
        public Coordinates(double x, double y)
        {
            Latitude = x;
            Longitude = y;
        }

        public readonly double Latitude;
        public readonly double Longitude;
    }

    public struct GeographicSize
    {
        public GeographicSize(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public readonly double Width;
        public readonly double Height;
    }

    internal class MapCalculator
    {
        protected Size originalImageSize;
        
        public MapCalculator(string pathToImage)
        {
            originalImageSize = GetImageSize(pathToImage);
        }

        protected static Size GetImageSize(string pathToImage)
        {
            var img = Image.FromFile(pathToImage);
            return new Size(img.Width, img.Height);
        }

        public Point GetPointOnOriginalSize(Size thumbnailSize, int x, int y)
        {
            var newX = ((double)x / thumbnailSize.Width) * originalImageSize.Width;
            var newY = ((double)y / thumbnailSize.Height) * originalImageSize.Height;

            return new Point((int)newX, (int)newY);
        }

        public Point GetPointOnOriginalSizeUsingCoordinates(MapMetadata mapMetadata, GeographicSize geographicOriginalSize, Coordinates coordinates)
        {

            var newX = ((coordinates.Longitude - mapMetadata.LongitudeMin) / mapMetadata.MapWidth)*1000;
            var newY = (1-((coordinates.Latitude - mapMetadata.LatitudeMin) / mapMetadata.MapHeight))*1000;
            return new Point((int)newX, (int)newY);
        }
    }
}
