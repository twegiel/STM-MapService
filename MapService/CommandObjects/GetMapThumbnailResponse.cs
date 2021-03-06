﻿namespace MapService.CommandObjects
{
    public class GetMapThumbnailResponse : BaseResponse
    {
        public string Thumbnail { get; set; }
        public string MapName { get; set; }

        public double LatitudeMin { get; set; }
        public double LatitudeMax { get; set; }

        public double LongitudeMin { get; set; }
        public double LongitudeMax { get; set; }
    }
}
