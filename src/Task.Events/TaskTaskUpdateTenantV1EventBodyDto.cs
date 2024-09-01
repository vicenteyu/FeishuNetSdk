// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="TaskTaskUpdateTenantV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>任务信息变更（租户维度） 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task.Events;
/// <summary>
/// 任务信息变更（租户维度） 事件体
/// <para>APP 订阅此事件后可接收到该 APP 所在租户的所有来源接口创建的任务的变更事件。事件体为发生变更任务的相关用户的 open_id，可用此 open_id ，通过 获取任务列表接口获取与该用户相关的所有任务。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=task&amp;version=v1&amp;resource=task&amp;event=update_tenant)</para>
/// <para>接口ID：7044355281854087196</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task/events/update_tenant</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask%2fevents%2fupdate_tenant</para>
/// </summary>
public record TaskTaskUpdateTenantV1EventBodyDto() : EventBodyDto("task.task.update_tenant_v1")
{
    /// <summary>
    /// <para>用户 ID 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_id_list")]
    public UserIdListSuffix? UserIdList { get; set; }

    /// <summary></summary>
    public record UserIdListSuffix
    {
        /// <summary>
        /// <para>用户 ID 列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id_list")]
        public UserIdSuffix[]? UserIdList { get; set; }
    }

    /// <summary>
    /// <para>任务的id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }

    /// <summary>
    /// <para>变更的数据类型，可选值：</para>
    /// <para>"task"，"collaborator"，"follower"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("object_type")]
    public string? ObjectType { get; set; }

    /// <summary>
    /// <para>事件类型，可选值：</para>
    /// <para>"create"，"delete"，"update"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("event_type")]
    public string? EventType { get; set; }
}
