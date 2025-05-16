namespace FeishuNetSdk.Base.Dtos;

/// <summary>
/// 人员类型记录
/// <para>作为请求参数使用，仅支持 id 参数作为入参。</para>
/// </summary>
/// <param name="Id">人员的用户 ID，支持 open_id、union_id 和 user_id</param>
/// <param name="Name">人员名称，不支持通过写接口传入</param>
/// <param name="AvatarUrl">人员头像链接，不支持通过写接口传入</param>
/// <param name="EnName">人员英文名称，不支持通过写接口传入</param>
/// <param name="Email">人员邮箱，不支持通过写接口传入</param>
public record UserRecord(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("name")] string? Name = null,
    [property: JsonPropertyName("avatar_url")] string? AvatarUrl = null,
    [property: JsonPropertyName("en_name")] string? EnName = null,
    [property: JsonPropertyName("email")] string? Email = null) : IBitableRecord;
