using Refit;
using System.Threading.Tasks;
using Transportation.Dtos;

namespace Transportation.Mobile.Services
{
    public interface IRouteDataService
    {
        [Get("/routes/transportation-route")]
        Task<TransportationRouteDto> GetTransportationRoute(int transportationId);
    }
}
