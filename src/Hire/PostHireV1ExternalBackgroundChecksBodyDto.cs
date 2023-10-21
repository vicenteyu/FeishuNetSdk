using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建外部背调 请求体
/// <para>导入来自其他系统的背调信息，创建为外部背调。</para>
/// <para>接口ID：6992822583076372483</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_background_check%2fcreate</para>
/// </summary>
public record PostHireV1ExternalBackgroundChecksBodyDto
{
    /// <summary>
    /// <para>外部系统背调主键 （仅用于幂等）</para>
    /// <para>必填：否</para>
    /// <para>示例值：123</para>
    /// </summary>
    [JsonProperty("external_id")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// <para>外部投递 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：1234111</para>
    /// </summary>
    [JsonProperty("external_application_id")]
    public string ExternalApplicationId { get; set; } = string.Empty;

    /// <summary>
    /// <para>背调日期</para>
    /// <para>必填：否</para>
    /// <para>示例值：1626602069393</para>
    /// </summary>
    [JsonProperty("date")]
    public int? Date { get; set; }

    /// <summary>
    /// <para>背调名字</para>
    /// <para>必填：否</para>
    /// <para>示例值：测试.pdf</para>
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>背调结果</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonProperty("result")]
    public string? Result { get; set; }

    /// <summary>
    /// <para>背调附件ID列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：6989181065243969836</para>
    /// </summary>
    [JsonProperty("attachment_id_list")]
    public string[]? AttachmentIdList { get; set; }
}
