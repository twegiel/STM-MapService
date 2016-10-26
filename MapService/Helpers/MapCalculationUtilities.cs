using System;
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

            var newX = ((coordinates.Longitude - mapMetadata.LongitudeMin) / mapMetadata.MapWidth) * 1000;
            var newY = (1 - ((coordinates.Latitude - mapMetadata.LatitudeMin) / mapMetadata.MapHeight)) * 1000;

            //var mapCenterLocation = GetTileLocation(51.4022, 21.1631);
            //var coordinatesLocation = GetTileLocation(coordinates.Latitude, coordinates.Longitude);

            //var deltaX = coordinatesLocation.Item1 - mapCenterLocation.Item1;
            //var deltaY = coordinatesLocation.Item2 - mapCenterLocation.Item2;

            //var newX = 500 + deltaX * 256;
            //var newY = 500 + deltaY * 256;

            return new Point((int)newX, (int)newY);
        }

        private double ToRadians(double value)
        {
            return (Math.PI * 180) * value;
        }

        private Tuple<double, double> GetTileLocation(double latitude, double longitude)
        {
            double zoom = 15;

            double lon_rad = ToRadians(longitude);
            double lat_rad = ToRadians(latitude);

            double n = Math.Pow(2.0, (int)zoom);

            double tileX = ((lon_rad + 180) / 360) * n;
            double tileY = (1 - (Math.Log(Math.Tan(lat_rad) + 1.0 / Math.Cos(lat_rad)) / Math.PI)) * n / 2.0;

            return new Tuple<double, double>(tileX, tileY);
        }
    }
}
