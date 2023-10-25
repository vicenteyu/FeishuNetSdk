using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 回传背调订单的最终结果 请求体
/// <para>回传背调的最终结果，终版报告。 回传背调结果后，若租户未启用报告审批功能，则背调订单状态将会变成已完成。 若启用报告审批功能，则在管理员审批通过终版报告后，订单状态流转为已完成。</para>
/// <para>接口ID：7195815979079499777</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check/update_result</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check%2fupdate_result</para>
/// </summary>
public record PostHireV1EcoBackgroundChecksUpdateResultBodyDto
{
    /// <summary>
    /// <para>背调 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：6931286400470354183</para>
    /// </summary>
    [JsonProperty("background_check_id")]
    public string BackgroundCheckId { get; set; } = string.Empty;

    /// <summary>
    /// <para>背调结果</para>
    /// <para>必填：是</para>
    /// <para>示例值：无差异</para>
    /// </summary>
    [JsonProperty("result")]
    public string Result { get; set; } = string.Empty;

    /// <summary>
    /// <para>背调结果时间</para>
    /// <para>必填：是</para>
    /// <para>示例值：1660123456789</para>
    /// </summary>
    [JsonProperty("result_time")]
    public string ResultTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>报告列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("report_file_list")]
    public EcoBackgroundCheckReportFile[]? ReportFileLists { get; set; }

    /// <summary>
    /// <para>报告列表</para>
    /// </summary>
    public record EcoBackgroundCheckReportFile
    {
        /// <summary>
        /// <para>报告名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：阶段报告.pdf</para>
        /// </summary>
        [JsonProperty("report_name")]
        public string ReportName { get; set; } = string.Empty;

        /// <summary>
        /// <para>报告地址</para>
        /// <para>必填：是</para>
        /// <para>示例值：https://xxxxx/xxxxxx/xxxx.pdf</para>
        /// </summary>
        [JsonProperty("report_url")]
        public string ReportUrl { get; set; } = string.Empty;
    }
}
