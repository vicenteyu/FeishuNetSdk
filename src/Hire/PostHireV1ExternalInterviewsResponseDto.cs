// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-09
// ************************************************************************
// <copyright file="PostHireV1ExternalInterviewsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建外部面试 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建外部面试 响应体
/// <para>导入来自其他系统的面试信息，创建为外部面试。</para>
/// <para>接口ID：6992822583076339715</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/create-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_interview%2fcreate</para>
/// </summary>
public record PostHireV1ExternalInterviewsResponseDto
{
    /// <summary>
    /// <para>外部面试信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("external_interview")]
    public PostHireV1ExternalInterviewsResponseDtoExternalInterview? ExternalInterview { get; set; }

    /// <summary>
    /// <para>外部面试信息</para>
    /// </summary>
    public record PostHireV1ExternalInterviewsResponseDtoExternalInterview
    {
        /// <summary>
        /// <para>外部投递 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6960663240925956437</para>
        /// </summary>
        [JsonPropertyName("external_application_id")]
        public string ExternalApplicationId { get; set; } = string.Empty;

        /// <summary>
        /// <para>外部面试 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956436</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>参与状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：未参与</item>
        /// <item>2：参与</item>
        /// <item>3：爽约</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("participate_status")]
        public int? ParticipateStatus { get; set; }

        /// <summary>
        /// <para>开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618500278638</para>
        /// </summary>
        [JsonPropertyName("begin_time")]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618500278639</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public long? EndTime { get; set; }
    }
}
