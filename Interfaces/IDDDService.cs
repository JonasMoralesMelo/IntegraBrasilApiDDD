using artigotech_integra_brasilapi.Dtos;

namespace artigotech_integra_brasilapi.Interfaces
{
    public interface IDDDService
    {
        Task<ResponseGenerico<DDDResponse>> BuscarDDD(int ddd);
    }
}