namespace Data
{
    public static class ElectricVehicleExtensionClass
    {
        public static string MakerAndModel(this EletricVehiclePopulationData vehichle)
        {
            return $"{vehichle.Make}/{vehichle.Model}";
        }
    }
}
