// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-30
//
// Last Modified By : yxr
// Last Modified On : 2026-05-29
// ************************************************************************
// <copyright file="PostTaskV2TasksByTaskGuidSetAncestorTaskBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>设置父任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 设置父任务 请求体
/// <para>管理任务的父子关系，支持设置任务的父任务，或者将任务转为独立任务。</para>
/// <para>接口ID：7645220598528183484</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/set_ancestor_task</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fset_ancestor_task</para>
/// </summary>
public record PostTaskV2TasksByTaskGuidSetAncestorTaskBodyDto
{
    /// <summary>
    /// <para>父任务的guid，可从任务详情字段获取， 未设置时作用为转独立任务</para>
    /// <para>必填：否</para>
    /// <para>示例值：e297ddff-06ca-4166-b917-4ce57cd3a7a0</para>
    /// </summary>
    [JsonPropertyName("ancestor_guid")]
    public string? AncestorGuid { get; set; }

    /// <summary>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_id_type")]
    public string? UserIdType { get; set; }
}
