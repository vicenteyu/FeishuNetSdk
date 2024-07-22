// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1JobsByJobIdManagersBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新职位相关人员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新职位相关人员 请求体
/// <para>更新职位相关人员。</para>
/// <para>接口ID：7098334044387475484</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob-manager%2fbatch_update</para>
/// </summary>
public record PostHireV1JobsByJobIdManagersBatchUpdateBodyDto
{
    /// <summary>
    /// <para>招聘负责人 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_e6139117c300506837def50545420c6a</para>
    /// </summary>
    [JsonPropertyName("recruiter_id")]
    public string? RecruiterId { get; set; }

    /// <summary>
    /// <para>招聘协助人 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_efk39117c300506837def50545420c6a</para>
    /// </summary>
    [JsonPropertyName("assistant_id_list")]
    public string[]? AssistantIdList { get; set; }

    /// <summary>
    /// <para>用人经理 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_efk39117c300506837def50545420c6a</para>
    /// </summary>
    [JsonPropertyName("hiring_manager_id_list")]
    public string[]? HiringManagerIdList { get; set; }

    /// <summary>
    /// <para>更新的人员类型，可选值：1=招聘负责人; 2=招聘协助人; 3=用人经理；</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("update_option_list")]
    public int[] UpdateOptionList { get; set; } = Array.Empty<int>();

    /// <summary>
    /// <para>操作者 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_efk39117c300506837def50545420c6a</para>
    /// </summary>
    [JsonPropertyName("creator_id")]
    public string? CreatorId { get; set; }
}
