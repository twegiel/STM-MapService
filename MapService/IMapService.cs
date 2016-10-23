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
        GetDetailedMapByPixelLocationResponse GetDetailedMapByCoordinates(string mapName, double latitude1, double longitude1, double latitude2, double longitude2);
    }
}
