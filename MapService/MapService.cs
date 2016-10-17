using System;
using MapService.CommandObjects;
using System.IO;
using System.Drawing;

namespace MapService
{
    public class MapService : IMapService
    {
        private string _pathToMapFolder;
        private string _mapFile;

        Size _thumbnailSize;

        public MapService()
        {
            _pathToMapFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Maps");
            _thumbnailSize = new Size(500, 500);

        }

        private string GetPathToRadomImage()
        {
            string radomPath = Path.Combine(_pathToMapFolder, "radom.png");

            return radomPath;
        }
        
        public bool GetDetailedMapByCoordinates(double latitude, double longitude)
        {
            throw new NotImplementedException();
        }

        public GetDetailedMapByPixelLocationResponse GetDetailedMapByPixelLocation(int x1, int y1, int x2, int y2)
        {
            return ServiceProcessorWrapper.Wrap(() =>
            {
                string pathToImage = GetPathToRadomImage();

                var originalSize = MapCalculationUtilities.GetImageSize(pathToImage);

                var upLeftPoint = MapCalculationUtilities.GetPointOnOriginalSize(originalSize, _thumbnailSize, x1, y1);
                var downRightPoint = MapCalculationUtilities.GetPointOnOriginalSize(originalSize, _thumbnailSize, x2, y2);

                byte[] detailedImage = new MapConverter(pathToImage)
                    .CropImage(upLeftPoint.X, upLeftPoint.Y, downRightPoint.X, downRightPoint.Y)
                    .GetBytesOfTransformedImage();

                GetDetailedMapByPixelLocationResponse response = new GetDetailedMapByPixelLocationResponse
                {
                    DetailedImage = Convert.ToBase64String(detailedImage)
                };

                return response;
            });
        }

        public GetMapThumbnailResponse GetMapThumbnail()
        {
            return ServiceProcessorWrapper.Wrap(() =>
            {
                string pathToImage = GetPathToRadomImage();

                byte[] thumbnailImageBytes = new MapConverter(pathToImage)
                    .TransformToThumbnail(_thumbnailSize)
                    .GetBytesOfTransformedImage();

                GetMapThumbnailResponse response = new GetMapThumbnailResponse
                {
                    Thumbnail = Convert.ToBase64String(thumbnailImageBytes)
                };

                return response;
            });
        }
    }
}
