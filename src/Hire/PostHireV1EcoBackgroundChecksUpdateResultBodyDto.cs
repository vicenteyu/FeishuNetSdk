// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1EcoBackgroundChecksUpdateResultBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>回传背调订单的最终结果 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 回传背调订单的最终结果 请求体
/// <para>回传背调的最终结果和终版报告。回传后，若租户未启用背调报告审批功能，则背调订单状态将会直接变成「已完成」。若启用背调报告审批功能，则在管理员审批通过后，订单状态流转为「已完成」。</para>
/// <para>接口ID：7195815979079499777</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check/update_result</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check%2fupdate_result</para>
/// </summary>
public record PostHireV1EcoBackgroundChecksUpdateResultBodyDto
{
    /// <summary>
    /// <para>背调 ID。可通过[创建背调](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check/events/created)事件获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6931286400470354183</para>
    /// </summary>
    [JsonPropertyName("background_check_id")]
    public string BackgroundCheckId { get; set; } = string.Empty;

    /// <summary>
    /// <para>背调结果</para>
    /// <para>必填：是</para>
    /// <para>示例值：无差异</para>
    /// </summary>
    [JsonPropertyName("result")]
    public string Result { get; set; } = string.Empty;

    /// <summary>
    /// <para>背调结果时间。毫秒时间戳</para>
    /// <para>必填：是</para>
    /// <para>示例值：1660123456789</para>
    /// </summary>
    [JsonPropertyName("result_time")]
    public string ResultTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>报告列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("report_file_list")]
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
        [JsonPropertyName("report_name")]
        public string ReportName { get; set; } = string.Empty;

        /// <summary>
        /// <para>报告地址；当report_url_type 为空或为 1 时需为可下载的 pdf 链接；为 2 时为预览型链接</para>
        /// <para>必填：是</para>
        /// <para>示例值：https://xxxxx/xxxxxx/xxxx.pdf</para>
        /// </summary>
        [JsonPropertyName("report_url")]
        public string ReportUrl { get; set; } = string.Empty;

        /// <summary>
        /// <para>报告地址类型；枚举值为空或 1 时为可下载的 pdf 链接，2 为预览型链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：可下载的链接</item>
        /// <item>2：外链型链接</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("report_url_type")]
        public int? ReportUrlType { get; set; }
    }
}
