// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-28
//
// Last Modified By : yxr
// Last Modified On : 2024-08-28
// ************************************************************************
// <copyright file="PatchHireV1InterviewersByInterviewerIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新面试官信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新面试官信息 请求体
/// <para>用于更新面试官认证信息</para>
/// <para>接口ID：7372229724359852033</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/recruitment-related-configuration/interview-settings/interviewer/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterviewer%2fpatch</para>
/// </summary>
public record PatchHireV1InterviewersByInterviewerIdBodyDto
{
    /// <summary>
    /// <para>面试官信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("interviewer")]
    public PatchHireV1InterviewersByInterviewerIdBodyDtoInterviewer Interviewer { get; set; } = new();

    /// <summary>
    /// <para>面试官信息</para>
    /// </summary>
    public record PatchHireV1InterviewersByInterviewerIdBodyDtoInterviewer
    {
        /// <summary>
        /// <para>认证状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：未认证</item>
        /// <item>2：已认证</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("verify_status")]
        public int? VerifyStatus { get; set; }
    }
}
