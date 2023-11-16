namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取附件预览信息 响应体
/// <para>根据人才简历附件 ID 获取附件预览信息,可通过[获取人才信息](https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/get-2)接口获取人才的简历附件</para>
/// <para>接口ID：6964631863168647171</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/attachment/preview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fattachment%2fpreview</para>
/// </summary>
public record GetHireV1AttachmentsByAttachmentIdPreviewResponseDto
{
    /// <summary>
    /// <para>预览链接</para>
    /// <para>必填：是</para>
    /// <para>示例值：链接</para>
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;
}
