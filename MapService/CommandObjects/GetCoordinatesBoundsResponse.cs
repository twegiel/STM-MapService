namespace MapService.CommandObjects
{
    public class GetCoordinatesBoundsResponse : BaseResponse
    {
        public double LatitudeMin { get; set; }
        public double LatitudeMax { get; set; }

        public double LongitudeMin { get; set; }
        public double LongitudeMax { get; set; }
    }
}
