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
/// <para>更新职位相关人员，包含招聘负责人、招聘协助人、用人经理。</para>
/// <para>## 注意事项</para>
/// <para>接口将按照所选择的「更新人员类型」进行设置参数校验和更新。若设置的更新类型所对应字段更新时未填写内容，接口将报错无法完成更新。</para>
/// <para>接口ID：7098334044387475484</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob-manager%2fbatch_update</para>
/// </summary>
public record PostHireV1JobsByJobIdManagersBatchUpdateBodyDto
{
    /// <summary>
    /// <para>招聘负责人 ID，与入参`user_id_type`类型一致，当`update_option_list `包含`招聘负责人`时，该参数必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_e6139117c300506837def50545420c6a</para>
    /// </summary>
    [JsonPropertyName("recruiter_id")]
    public string? RecruiterId { get; set; }

    /// <summary>
    /// <para>招聘协助人 ID 列表，与入参`user_id_type`类型一致，当`update_option_list `包含`招聘协助人`时，该参数必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_efk39117c300506837def50545420c6a</para>
    /// </summary>
    [JsonPropertyName("assistant_id_list")]
    public string[]? AssistantIdList { get; set; }

    /// <summary>
    /// <para>用人经理 ID 列表，与入参`user_id_type`类型一致，当`update_option_list`包含`用人经理`时，该参数必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_efk39117c300506837def50545420c6a</para>
    /// </summary>
    [JsonPropertyName("hiring_manager_id_list")]
    public string[]? HiringManagerIdList { get; set; }

    /// <summary>
    /// <para>更新的人员类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：招聘负责人</item>
    /// <item>2：招聘协助人</item>
    /// <item>3：用人经理</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("update_option_list")]
    public int[] UpdateOptionList { get; set; } = [];

    /// <summary>
    /// <para>操作者 ID，与入参`user_id_type`类型一致，不填默认系统操作</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_efk39117c300506837def50545420c6a</para>
    /// </summary>
    [JsonPropertyName("creator_id")]
    public string? CreatorId { get; set; }
}
