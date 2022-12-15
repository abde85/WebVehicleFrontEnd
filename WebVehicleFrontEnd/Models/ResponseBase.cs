namespace WebVehicleFrontEnd.Models
{
    public class ResponseBase
    {
        public bool Success { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
    }
}
