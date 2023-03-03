using Data;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var downloader = new CachedDataDownloader();
        using var reader = downloader.GetReaderFromUrl(EletricVehiclePopulationData.URL);
        Assert.True(reader.CanRead);
        var vehicles = EletricVehiclePopulationCsvParser.ReadFromCsv(reader);
        Assert.NotEmpty(vehicles);
    }
}