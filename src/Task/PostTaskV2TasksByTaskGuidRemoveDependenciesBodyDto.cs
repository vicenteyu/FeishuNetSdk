// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostTaskV2TasksByTaskGuidRemoveDependenciesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>移除依赖 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 移除依赖 请求体
/// <para>从一个任务移除一个或者多个依赖。移除时只需要输入要移除的`task_guid`即可。</para>
/// <para>注意，如果要移除的依赖非当前任务的依赖，会被自动忽略。接口会返回成功。</para>
/// <para>接口ID：7277445986133442563</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/remove_dependencies</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fremove_dependencies</para>
/// </summary>
public record PostTaskV2TasksByTaskGuidRemoveDependenciesBodyDto
{
    /// <summary>
    /// <para>要移除的依赖</para>
    /// <para>必填：是</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("dependencies")]
    public TaskDependency[] Dependencies { get; set; } = Array.Empty<TaskDependency>();

    /// <summary>
    /// <para>要移除的依赖</para>
    /// </summary>
    public record TaskDependency
    {
        /// <summary>
        /// <para>依赖任务的GUID</para>
        /// <para>必填：是</para>
        /// <para>示例值：93b7bd05-35e6-4371-b3c9-6b7cbd7100c0</para>
        /// </summary>
        [JsonPropertyName("task_guid")]
        public string TaskGuid { get; set; } = string.Empty;
    }
}
