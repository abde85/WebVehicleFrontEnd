using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebVehicleFrontEnd.Helper;
using WebVehicleFrontEnd.Models;

namespace WebVehicleFrontEnd.Controllers
{
    public class VehicleController : Controller
    {
        HttpClientHandler _clientHandler = new HttpClientHandler();
        public VehicleController()
        {
            _clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyError) => { return true; };
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SaveVehicle(Bpkb bpkb)
        {
            var content = new StringContent(JsonConvert.SerializeObject(bpkb), Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.PostAsync($"{Constants.UriApi.UriDatabase}{Constants.UriApi.VehicleEndPoint}", content))
                {
                    if (response.StatusCode != System.Net.HttpStatusCode.NoContent)
                    {
                        bpkb.Success = false;
                        bpkb.ErrorMessage = Constants.MessageInfo.ErrorFillData;
                    }
                    else
                    {
                        bpkb.Success = true;
                        bpkb.SuccessMessage = Constants.MessageInfo.SaveSuccess;
                    }
                }
            }

            return Ok(bpkb);
        }

    }
}
