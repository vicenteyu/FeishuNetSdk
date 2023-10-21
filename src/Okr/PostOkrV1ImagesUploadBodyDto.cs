using Newtonsoft.Json;
namespace FeishuNetSdk.Okr;
/// <summary>
/// 上传进展记录图片 请求体
/// <para>上传进展记录图片。</para>
/// <para>接口ID：7047048928294174722</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/progress_record/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fimage%2fupload</para>
/// </summary>
public record PostOkrV1ImagesUploadBodyDto
{
    /// <summary>
    /// <para>图片的目标ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：6974586812998174252</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("target_id")]
    public string TargetId { get; set; } = string.Empty;

    /// <summary>
    /// <para>图片使用的目标类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>2：okr的O</item>
    /// <item>3：okr的KR</item>
    /// </list></para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("target_type")]
    public int TargetType { get; set; }
}
