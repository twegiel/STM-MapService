using MapService.CommandObjects;
using System.ServiceModel;

namespace MapService
{
    [ServiceContract(Namespace = "http://stm.eti.gda.pl/stm")]
    public interface IMapService
    {
        [OperationContract]
        GetMapThumbnailResponse GetMapThumbnail();

        [OperationContract]
        GetDetailedMapByPixelLocationResponse GetDetailedMapByPixelLocation(int x1, int y1, int x2, int y2);

        [OperationContract]
        bool GetDetailedMapByCoordinates(double latitude, double longitude);
    }
}
