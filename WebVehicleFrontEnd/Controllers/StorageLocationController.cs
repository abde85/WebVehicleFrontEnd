using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebVehicleFrontEnd.Helper;
using WebVehicleFrontEnd.Models;

namespace WebVehicleFrontEnd.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StorageLocationController : ControllerBase
    {
        HttpClientHandler _clientHandler = new HttpClientHandler();
        public StorageLocationController()
        {
            _clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyError) => { return true; };
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StorageLocation>>> GetAllStorageLocations()
        {
            var storageLocations = new List<StorageLocation>();
            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.GetAsync($"{Constants.UriApi.UriDatabase}{Constants.UriApi.StorageLocationEndPoint}"))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    storageLocations = JsonConvert.DeserializeObject<List<StorageLocation>>(apiResponse);
                }
            }

            return storageLocations;
        }
    }
}
