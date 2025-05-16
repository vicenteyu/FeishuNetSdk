namespace FeishuNetSdk.Base.Dtos;

/// <summary>
/// 附件类型记录
/// </summary>
/// <param name="FileToken">附件的 token</param>
/// <param name="Name">附件名称</param>
/// <param name="Size">附件大小。单位：字节</param>
/// <param name="TmpUrl">生成附件临时下载链接的 url 链接，需 access token 鉴权</param>
/// <param name="Type">附件的 mime 类型, 如: image/png</param>
/// <param name="Url">附件 url 链接，需 access token 鉴权</param>
public record AttachmentRecord(
    [property: JsonPropertyName("file_token")] string FileToken,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("size")] long Size,
    [property: JsonPropertyName("tmp_url")] string TmpUrl,
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("url")] string Url) : IBitableRecord;
