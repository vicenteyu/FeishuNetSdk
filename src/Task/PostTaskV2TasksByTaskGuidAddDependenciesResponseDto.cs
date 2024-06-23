// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostTaskV2TasksByTaskGuidAddDependenciesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加依赖 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 添加依赖 响应体
/// <para>为一个任务添加一个或多个依赖。可以添加任务的前置依赖和后置依赖。存在依赖关系的任务如果在同一个清单，可以通过清单的甘特图来展示其依赖关系。</para>
/// <para>本接口也可以用于修改一个现有依赖的类型（前置改为后置或者后置改为前置）。</para>
/// <para>注意：添加的依赖的`task_guid`不能重复，也不能添加当前任务为自己的依赖。尝试添加一个已经存在的依赖会被自动忽略。</para>
/// <para>接口ID：7277445986133458947</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/add_dependencies</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fadd_dependencies</para>
/// </summary>
public record PostTaskV2TasksByTaskGuidAddDependenciesResponseDto
{
    /// <summary>
    /// <para>被添加后任务的所有依赖</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("dependencies")]
    public TaskDependency[]? Dependencies { get; set; }

    /// <summary>
    /// <para>被添加后任务的所有依赖</para>
    /// </summary>
    public record TaskDependency
    {
        /// <summary>
        /// <para>依赖类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：next</para>
        /// <para>可选值：<list type="bullet">
        /// <item>prev：前置依赖</item>
        /// <item>next：后置依赖</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>依赖任务的GUID</para>
        /// <para>必填：是</para>
        /// <para>示例值：93b7bd05-35e6-4371-b3c9-6b7cbd7100c0</para>
        /// </summary>
        [JsonPropertyName("task_guid")]
        public string TaskGuid { get; set; } = string.Empty;
    }
}
