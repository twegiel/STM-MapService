﻿using System;
using MapService.CommandObjects;
using System.IO;
using System.Drawing;
using MapService.Helpers;

namespace MapService
{
    public class MapService : IMapService
    {
        private readonly Size _thumbnailSize;
        private readonly XmlDatabaseReader _databaseReader;

        public MapService()
        {
            _databaseReader = new XmlDatabaseReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Maps"));
            _thumbnailSize = new Size(500, 500);
        }
        
        public bool GetDetailedMapByCoordinates(string mapName, double latitude, double longitude)
        {
            throw new NotImplementedException();
        }

        public GetDetailedMapByPixelLocationResponse GetDetailedMapByPixelLocation(string mapName, int x1, int y1, int x2, int y2)
        {
            return ServiceProcessorWrapper.Wrap(() =>
            {
                MapMetadata mapMetadata = _databaseReader.GetMapMetadata(mapName);

                var originalSize = MapCalculationUtilities.GetImageSize(mapMetadata.PathToMap);

                var upLeftPoint = MapCalculationUtilities.GetPointOnOriginalSize(originalSize, _thumbnailSize, x1, y1);
                var downRightPoint = MapCalculationUtilities.GetPointOnOriginalSize(originalSize, _thumbnailSize, x2, y2);

                byte[] detailedImage = new MapConverter(mapMetadata.PathToMap)
                    .CropImage(upLeftPoint.X, upLeftPoint.Y, downRightPoint.X, downRightPoint.Y)
                    .GetBytesOfTransformedImage();

                GetDetailedMapByPixelLocationResponse response = new GetDetailedMapByPixelLocationResponse
                {
                    DetailedImage = Convert.ToBase64String(detailedImage),
                    
                };

                return response;
            });
        }

        public GetMapThumbnailResponse GetMapThumbnail(string mapName)
        {
            return ServiceProcessorWrapper.Wrap(() =>
            {
                MapMetadata mapMetadata = _databaseReader.GetMapMetadata(mapName);

                byte[] thumbnailImageBytes = new MapConverter(mapMetadata.PathToMap)
                    .TransformToThumbnail(_thumbnailSize)
                    .GetBytesOfTransformedImage();

                GetMapThumbnailResponse response = new GetMapThumbnailResponse
                {
                    Thumbnail = Convert.ToBase64String(thumbnailImageBytes),
                    MapName = mapMetadata.MapName,
                    LatitudeMax = mapMetadata.LatitudeMax,
                    LatitudeMin = mapMetadata.LatitudeMin,
                    LongitudeMax = mapMetadata.LongitudeMax,
                    LongitudeMin = mapMetadata.LongitudeMin
                };

                return response;
            });
        }
    }
}
