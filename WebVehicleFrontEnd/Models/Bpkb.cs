namespace WebVehicleFrontEnd.Models
{
    public class Bpkb : ResponseBase
    {
        public string Agreement_Number { get; set; }
        public string Bpkb_No { get; set; }
        public string Branch_Id { get; set; }
        public DateTime Bpkb_Date { get; set; }
        public string Faktur_No { get; set; }
        public DateTime Faktur_Date { get; set; }
        public string Location_Id { get; set; }
        public string Police_No { get; set; }
        public DateTime Bpkb_Date_In { get; set; }
    }
}
