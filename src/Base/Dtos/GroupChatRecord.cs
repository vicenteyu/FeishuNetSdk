namespace FeishuNetSdk.Base.Dtos;

/// <summary>
/// 群组类型的记录
/// </summary>
/// <param name="AvatarUrl">群组头像链接</param>
/// <param name="Id">群组的 ID</param>
/// <param name="Name">群组名称</param>
public record GroupChatRecord(
    [property: JsonPropertyName("avatar_url")] string AvatarUrl,
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("name")] string Name) : IBitableRecord;
