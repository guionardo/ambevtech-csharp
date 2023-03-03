using System.Collections.Immutable;
using Data;

var downloader = new CachedDataDownloader();
using var reader = downloader.GetReaderFromUrl(EletricVehiclePopulationData.URL);
var vehicles = EletricVehiclePopulationCsvParser.ReadFromCsv(reader);

var teslaCars = vehicles
    .Where(v => v.Make == "TESLA").ToList();

var allTelsaCarsRunsMoreThan100Miles = teslaCars
    .All(v => v.EletricRange > 100);

Console.WriteLine(allTelsaCarsRunsMoreThan100Miles);

var minimumEletricRange = teslaCars.Min(n => n.EletricRange);

Console.WriteLine(minimumEletricRange);

var models = teslaCars
    .DistinctBy(t => t.Model)
    .Select(t => t.Model)
    .ToList();

foreach (var model in models)
{
    Console.WriteLine(model);
}
