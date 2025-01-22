using System.Net.Http.Json;

using Camara.Web.Data.VereadoresDTO;

namespace Camara.Web.Services;

public class VereadorAPI
{
    private readonly HttpClient _httpClient;
    public VereadorAPI(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("API");
    }

    public async Task<ICollection<ReadVereadorDTO>?> GetVereadoresAsysnc()
    {
        return await _httpClient.GetFromJsonAsync<ICollection<ReadVereadorDTO>>("api/vereador");
    }
}
