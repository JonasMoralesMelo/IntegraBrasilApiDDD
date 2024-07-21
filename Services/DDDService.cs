using artigotech_integra_brasilapi.Dtos;
using artigotech_integra_brasilapi.Interfaces;
using AutoMapper;

namespace artigotech_integra_brasilapi.Services
{
    public class DDDService : IDDDService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;
        
        public DDDService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }
        public async Task<ResponseGenerico<DDDResponse>> BuscarDDD(int ddd)
        {
            var endereco = await _brasilApi.BuscarPorCodigoDDD(ddd);

            return _mapper.Map<ResponseGenerico<DDDResponse>>(endereco);
        }
    }
 }
