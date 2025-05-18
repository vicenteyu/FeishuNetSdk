namespace FeishuNetSdk.Base.Dtos;

/// <summary>
/// 文本类型记录
/// </summary>
/// <param name="Type">文本展示类型，可选值有：<list type="bullet">
/// <item>text：纯文本类型</item>
/// <item>mention：提及人或提及云文档类型</item>
/// <item>url：超链接类型</item>
/// </list></param>
/// <param name="Text">文本内容</param>
/// <param name="Link">链接。当 type 字段为 url 时，该字段有效</param>
/// <param name="Token">当 type 字段为 mention 时，该字段有效。<list type="bullet">
/// <item>当 mentionType 为 User 时，token 为用户 ID</item>
/// <item>当 mentionType 为 Docx 时，token 为文档的 document_id</item>
/// <item>当 mentionType 为 Sheet 时，token 为电子表格的 spreadsheet_token</item>
/// <item>当 mentionType 为 Bitable时，token 为多维表格的 app_token</item>
/// </list></param>
/// <param name="Name">提及的用户名称。当 type 字段为 mention 且 mentionType 字段为 User 时，该字段有效</param>
/// <param name="MentionType">当 type 字段为 mention 时，该字段有效，可选值有：<list type="bullet">
/// <item>User：提及用户</item>
/// <item>Docx：提及文档</item>
/// <item>Sheet：提及电子表格</item>
/// <item>Bitable：提及多维表格</item>
/// </list></param>
/// <param name="MentionNotify">当 type 字段为 mention 且 mentionType 字段为 User 时，该字段有效。可选值有：<list type="bullet">
/// <item>false：不提及该用户</item>
/// <item>true：提及该用户</item>
/// </list></param>
public record TextRecord(
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("text")] string Text,
    [property: JsonPropertyName("link")] string? Link = null,
    [property: JsonPropertyName("token")] string? Token = null,
    [property: JsonPropertyName("name")] string? Name = null,
    [property: JsonPropertyName("mentionType")] string? MentionType = null,
    [property: JsonPropertyName("mentionNotify")] bool? MentionNotify = null) : IBitableRecord;
