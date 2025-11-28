// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-07-02
// ************************************************************************
// <copyright file="PostTaskV2TasksByTaskGuidAddMembersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加任务成员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 添加任务成员 请求体
/// <para>添加任务的负责人或者关注人。一次性可以添加多个成员。返回任务的实体中会返回最终任务成员的列表。</para>
/// <para>* 关于member的格式，详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？”章节。</para>
/// <para>* 成员的角色支持"assignee"和"follower"。</para>
/// <para>* 成员类型支持"user"和"app"。</para>
/// <para>* 如果要添加的成员已经在任务中，则自动被忽略。</para>
/// <para>接口ID：7255580838154584092</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/task/add_members</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fadd_members</para>
/// </summary>
public record PostTaskV2TasksByTaskGuidAddMembersBodyDto
{
    /// <summary>
    /// <para>要添加的members列表，单请求支持最大50个成员（去重后)。关于member的格式，详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？”章节。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("members")]
    public Member[] Members { get; set; } = [];

    /// <summary>
    /// <para>要添加的members列表，单请求支持最大50个成员（去重后)。关于member的格式，详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？”章节。</para>
    /// </summary>
    public record Member
    {
        /// <summary>
        /// <para>表示member的id</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>成员类型, 可选值</para>
        /// <para>* user</para>
        /// <para>* app</para>
        /// <para>必填：否</para>
        /// <para>示例值：user</para>
        /// <para>默认值：user</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>成员的角色，可选值</para>
        /// <para>* assignee</para>
        /// <para>* follower</para>
        /// <para>必填：是</para>
        /// <para>示例值：assignee</para>
        /// <para>最大长度：20</para>
        /// </summary>
        [JsonPropertyName("role")]
        public string Role { get; set; } = string.Empty;

        /// <summary>
        /// <para>成员名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：张明德（明德）</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    /// <summary>
    /// <para>幂等token，如果提供则实现幂等行为。详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 幂等调用 ”章节。</para>
    /// <para>必填：否</para>
    /// <para>示例值：6d99f59c-4d7d-4452-98d6-3d0556393cf6</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：10</para>
    /// </summary>
    [JsonPropertyName("client_token")]
    public string? ClientToken { get; set; }
}
