using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 终止背调订单 请求体
/// <para>调用此接口将会将系统订单状态变成已终止， 已终止订单将不会响应[「更新背调进度」](https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check/update_progress)和[「回传背调订单的最终结果」](https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check/update_result)。 建议在回调终止背调订单之前，推送账号进度为「已终止」</para>
/// <para>接口ID：7195815979079598081</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check/cancel</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check%2fcancel</para>
/// </summary>
public record PostHireV1EcoBackgroundChecksCancelBodyDto
{
    /// <summary>
    /// <para>背调 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：6931286400470354183</para>
    /// </summary>
    [JsonProperty("background_check_id")]
    public string BackgroundCheckId { get; set; } = string.Empty;
}
