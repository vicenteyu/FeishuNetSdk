// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1JobsByJobIdManagersBatchUpdateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新职位相关人员 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新职位相关人员 响应体
/// <para>更新职位相关人员。</para>
/// <para>接口ID：7098334044387475484</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob-manager%2fbatch_update</para>
/// </summary>
public record PostHireV1JobsByJobIdManagersBatchUpdateResponseDto
{
    /// <summary>
    /// <para>职位负责人</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_manager")]
    public PostHireV1JobsByJobIdManagersBatchUpdateResponseDtoJobManager? JobManager { get; set; }

    /// <summary>
    /// <para>职位负责人</para>
    /// </summary>
    public record PostHireV1JobsByJobIdManagersBatchUpdateResponseDtoJobManager
    {
        /// <summary>
        /// <para>职位ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618209327096</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>招聘负责人ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：1612209227096</para>
        /// </summary>
        [JsonPropertyName("recruiter_id")]
        public string RecruiterId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用人经理ID列表</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("hiring_manager_id_list")]
        public string[] HiringManagerIdList { get; set; } = Array.Empty<string>();

        /// <summary>
        /// <para>协助人ID列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("assistant_id_list")]
        public string[]? AssistantIdList { get; set; }
    }
}
