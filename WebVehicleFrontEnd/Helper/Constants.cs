namespace WebVehicleFrontEnd.Helper
{
    public static class Constants
    {
        public struct UriApi
        {
            public const string UriDatabase = "https://localhost:7202/";
            public const string VehicleEndPoint = "vehicle";
            public const string StorageLocationEndPoint = "storagelocation";
        }

        public struct MessageInfo
        {
            public const string SaveSuccess = "Data berhasil disimpan";
            public const string ErrorFillData = "Silahkan lengkapi data";
        }
    }
}
