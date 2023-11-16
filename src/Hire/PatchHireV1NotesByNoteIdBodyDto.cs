namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新备注 请求体
/// <para>根据备注 ID 更新备注信息。</para>
/// <para>接口ID：6950644745484402715</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/note/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fnote%2fpatch</para>
/// </summary>
public record PatchHireV1NotesByNoteIdBodyDto
{
    /// <summary>
    /// <para>备注内容</para>
    /// <para>必填：是</para>
    /// <para>示例值：111</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;
}
