using System.Collections.Immutable;
using Data;

var downloader = new CachedDataDownloader();
using var reader = downloader.GetReaderFromUrl(EletricVehiclePopulationData.URL);
var vehicles = EletricVehiclePopulationCsvParser.ReadFromCsv(reader);

var tesla = vehicles.Where(v => v.Make == "TESLA").ToImmutableArray();

foreach (var vehicle in tesla)
{
    Console.WriteLine(vehicle);
    
}
// foreach (var vehicle in vehicles)
// {
//     Console.WriteLine(vehicle);
// }
