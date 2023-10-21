using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 上传文件 响应体
/// <para>上传文件。</para>
/// <para>接口ID：7076346346946543644</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/person/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fperson%2fupload</para>
/// </summary>
public record PostCorehrV1PersonsUploadResponseDto
{
    /// <summary>
    /// <para>上传文件ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：100</para>
    /// </summary>
    [JsonProperty("id")]
    public string? Id { get; set; }
}
