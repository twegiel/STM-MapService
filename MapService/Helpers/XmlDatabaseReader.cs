using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace MapService.Helpers
{
    internal class XmlDatabaseReader
    {
        private readonly string _mapFolderPath;

        public XmlDatabaseReader(string mapFolderPath)
        {
            _mapFolderPath = mapFolderPath;
        }

        public MapMetadata GetMapMetadata(string mapName)
        {
            string pathToMetadataFile = Path.Combine(_mapFolderPath, "mapMetadata.xml");
            XElement xElement = XElement.Load(pathToMetadataFile);
            IEnumerable<XElement> mapElements = xElement.Elements();

            XElement map = mapElements.FirstOrDefault(m => m.Attribute("name").Value == mapName);

            if (map == null)
                throw new ArgumentException("Map not found in database.");

            XElement longitude = map.Elements().First(e => e.Name == "longitude");
            XElement latitude = map.Elements().First(e => e.Name == "latitude");

            MapMetadata metadata = new MapMetadata()
            {
                MapName = map.Attribute("name").Value,
                FileName = map.Attribute("filename").Value,
                LatitudeMin = GetLocationAsDouble(latitude.Attribute("min").Value),
                LatitudeMax = GetLocationAsDouble(latitude.Attribute("max").Value),
                LongitudeMin = GetLocationAsDouble(longitude.Attribute("min").Value),
                LongitudeMax = GetLocationAsDouble(longitude.Attribute("max").Value)
            };

            metadata.PathToMap = Path.Combine(_mapFolderPath, metadata.FileName);

            return metadata;
        }

        public double GetLocationAsDouble(string stringValue)
        {
            return double.Parse(stringValue, CultureInfo.InvariantCulture);
        }
    }
}
