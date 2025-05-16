namespace FeishuNetSdk.Base.Dtos;

/// <summary>
/// 地理位置类型的记录
/// </summary>
/// <param name="Address">详细地址</param>
/// <param name="Adname">区</param>
/// <param name="Cityname">市</param>
/// <param name="FullAddress">完整地址</param>
/// <param name="Location">经纬度</param>
/// <param name="Name">地名</param>
/// <param name="Pname">省</param>
public record LocationRecord(
    [property: JsonPropertyName("address")] string Address,
    [property: JsonPropertyName("adname")] string Adname,
    [property: JsonPropertyName("cityname")] string Cityname,
    [property: JsonPropertyName("full_address")] string FullAddress,
    [property: JsonPropertyName("location")] string Location,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("pname")] string Pname) : IBitableRecord;
