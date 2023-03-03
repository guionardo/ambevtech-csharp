namespace Data;

/// <summary>
/// Dados de população de veículos elétricos
/// Disponível em https://catalog.data.gov/dataset/electric-vehicle-population-data
/// </summary>
public sealed record EletricVehiclePopulationData
{
    public const string URL = @"https://data.wa.gov/api/views/f6w7-q2d2/rows.csv?accessType=DOWNLOAD";

    /// <summary>
    /// VIN (1-10) : 5YJ3E1EA8J
    /// </summary>
    public string Vin;

    /// <summary>
    /// County : San Diego
    /// </summary>
    public string County;

    /// <summary>
    /// City : Oceanside
    /// </summary>
    public string City;

    /// <summary>
    /// State : CA
    /// </summary>
    public string State;

    /// <summary>
    /// Postal Code : 92051
    /// </summary>
    public string PostalCode;

    /// <summary>
    /// Model Year : 2018
    /// </summary>
    public int ModelYear;

    /// <summary>
    /// Make : TESLA
    /// </summary>
    public string Make;

    /// <summary>
    /// Model : MODEL 3
    /// </summary>
    public string Model;

    /// <summary>
    /// Electric Vehicle Type : Battery Electric Vehicle (BEV)
    /// </summary>
    public string ElectricVehicleType;

    /// <summary>
    /// Clean Alternative Fuel Vehicle (CAFV) Eligibility : Clean Alternative Fuel Vehicle Eligible
    /// </summary>
    public string CleanAlternativeFuelVehicleEligibility;

    /// <summary>
    /// Electric Range : 215
    /// </summary>
    public int EletricRange;

    /// <summary>
    /// Base MSRP : 0
    /// </summary>
    public int BaseMSRP;

    /// <summary>
    /// Legislative District : 153998050
    /// </summary>
    public string LegislativeDistrict;

    /// <summary>
    /// DOL Vehicle ID : 
    /// </summary>
    public string DOLVehicleId;

    /// <summary>
    /// Vehicle Location : POINT (-122.18384 47.8031)
    /// </summary>
    public string VehicleLocation;

    /// <summary>
    /// Electric Utility : PUGET SOUND ENERGY INC
    /// </summary>
    public string ElectricUtility;

    /// <summary>
    /// 2020 Census Tract : 53061051937
    /// </summary>
    public string CensusTract2020;
}