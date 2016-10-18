using MapService.CommandObjects;
using System.ServiceModel;

namespace MapService
{
    [ServiceContract(Namespace = "http://stm.eti.gda.pl/stm")]
    public interface IMapService
    {
        [OperationContract]
        GetMapThumbnailResponse GetMapThumbnail(string mapName);

        [OperationContract]
        GetDetailedMapByPixelLocationResponse GetDetailedMapByPixelLocation(string mapName, int x1, int y1, int x2, int y2);

        [OperationContract]
        bool GetDetailedMapByCoordinates(string mapName, double latitude, double longitude);
    }
}
