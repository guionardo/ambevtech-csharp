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

        while (csvReader.Read())
        {
            var vehicle = csvReader.GetRecord<EletricVehiclePopulationData>();
            yield return vehicle;
        }
    }
}