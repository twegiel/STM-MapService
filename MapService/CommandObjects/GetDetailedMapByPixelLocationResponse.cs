namespace MapService.CommandObjects
{
    public class GetDetailedMapByPixelLocationResponse : BaseResponse
    {
        public string MapName { get; set; }
        public string DetailedImage { get; set; }
    }
}
