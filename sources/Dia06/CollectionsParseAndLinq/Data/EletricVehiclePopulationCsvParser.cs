using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace Data;

public static class EletricVehiclePopulationCsvParser
{
    public static IEnumerable<EletricVehiclePopulationData> ReadFromCsv(FileStream stream)
    {
        var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
        {
            HasHeaderRecord = false,
            Delimiter = ",",
        };


        var reader = new StreamReader(stream);
        using var csvReader = new CsvReader(reader, csvConfig);
        csvReader.Context.RegisterClassMap<ElectricVehicle>();
        var isFirstRow = true;
        while (csvReader.Read())
        {
            if (isFirstRow)
            {
                isFirstRow = false;
                continue;
            }
            var vehicle = csvReader.GetRecord<EletricVehiclePopulationData>();
            yield return vehicle;
        }
    }

    //private static EletricVehiclePopulationData GetRow(CsvReader reader)
    //{
    //    reader.TryGetField<string>(0, out var vin);
    //    reader.TryGetField<string>(1, out var county);
    //    reader.TryGetField<string>(2, out var city);
    //    return new EletricVehiclePopulationData
    //    {
    //        Vin = vin,
    //        County = county,
    //        City = city,

    //    };
    //}
}

public sealed class ElectricVehicle : ClassMap<EletricVehiclePopulationData>
{
    public ElectricVehicle()
    {
        AutoMap(CultureInfo.InvariantCulture);
        Map(m => m.Vin).NameIndex(0);
        Map(m => m.County).NameIndex(1);
        Map(m => m.City).NameIndex(2);
        Map(m => m.State).NameIndex(3);
        Map(m => m.PostalCode).NameIndex(4);
        Map(m => m.ModelYear).NameIndex(5);
        Map(m => m.Make).NameIndex(6);
        Map(m => m.Model).NameIndex(7);
        Map(m => m.ElectricVehicleType).NameIndex(8);
        Map(m => m.CleanAlternativeFuelVehicleEligibility).NameIndex(9);
        Map(m => m.EletricRange).NameIndex(10);
        Map(m => m.BaseMSRP).NameIndex(11);
        Map(m => m.LegislativeDistrict).NameIndex(12);
        Map(m => m.DOLVehicleId).NameIndex(13);
        Map(m => m.VehicleLocation).NameIndex(14);
        Map(m => m.ElectricUtility).NameIndex(15);
        Map(m => m.CensusTract2020).NameIndex(16);
        // VIN (1-10)	County	City	State	Postal Code	Model Year	Make	Model	Electric Vehicle Type	Clean Alternative Fuel Vehicle (CAFV) Eligibility	Electric Range	Base MSRP	Legislative District	DOL Vehicle ID	Vehicle Location	Electric Utility	2020 Census Tract

    }
}