using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新背调订单进度 请求体
/// <para>更新指定背调的进展信息和阶段报告， 进度信息将会被展示在背调卡片上，用以推送背调进度、阶段报告。用以告知用户目前系统订单的流转状态。 当订单状态已完成时，将无法通过此接口更新阶段报告、更新进度事件信息。</para>
/// <para>接口ID：7195815979079483393</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check/update_progress</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check%2fupdate_progress</para>
/// </summary>
public record PostHireV1EcoBackgroundChecksUpdateProgressBodyDto
{
    /// <summary>
    /// <para>背调 ID，招聘侧的 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：6931286400470354183</para>
    /// </summary>
    [JsonProperty("background_check_id")]
    public string BackgroundCheckId { get; set; } = string.Empty;

    /// <summary>
    /// <para>阶段 ID，同一背调订单此 ID 不能重复</para>
    /// <para>必填：是</para>
    /// <para>示例值：6931286400470354183</para>
    /// </summary>
    [JsonProperty("stage_id")]
    public string StageId { get; set; } = string.Empty;

    /// <summary>
    /// <para>背调阶段英文名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：stage report</para>
    /// </summary>
    [JsonProperty("stage_en_name")]
    public string? StageEnName { get; set; }

    /// <summary>
    /// <para>背调阶段名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：阶段报告</para>
    /// </summary>
    [JsonProperty("stage_name")]
    public string StageName { get; set; } = string.Empty;

    /// <summary>
    /// <para>阶段进度更新时间。 毫秒级时间戳，每次调用此字段应严格递增</para>
    /// <para>必填：是</para>
    /// <para>示例值：1660123456789</para>
    /// </summary>
    [JsonProperty("stage_time")]
    public string StageTime { get; set; } = string.Empty;

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