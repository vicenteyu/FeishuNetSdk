// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostTaskV2TasklistsByTasklistGuidRemoveMembersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>移除清单成员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 移除清单成员 请求体
/// <para>移除清单的一个或多个协作成员。通过设置`members`字段表示要移除的成员信息。关于member的格式，详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？”章节。</para>
/// <para>清单中同一个成员只能有一个角色，通过的member的id和type可以唯一确定一个成员，因此请求参数中对于要删除的成员，不需要填写"role"字段。</para>
/// <para>如果要移除的成员不在清单中，则被自动忽略，接口返回成功。</para>
/// <para>该接口不能用于移除清单所有者。如果要移除的成员是清单所有者，则会被自动忽略。如要设置清单所有者，需要调用[更新清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/patch)接口。</para>
/// <para>接口ID：7255580838154846236</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/remove_members</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist%2fremove_members</para>
/// </summary>
public record PostTaskV2TasklistsByTasklistGuidRemoveMembersBodyDto
{
    /// <summary>
    /// <para>要移除的member列表。关于member的格式，详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？”章节。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：500</para>
    /// </summary>
    [JsonPropertyName("members")]
    public Member[] Members { get; set; } = Array.Empty<Member>();

    /// <summary>
    /// <para>要移除的member列表。关于member的格式，详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？”章节。</para>
    /// </summary>
    public record Member
    {
        /// <summary>
        /// <para>表示member的id</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>成员的类型，支持：</para>
        /// <para>&lt;md-enum&gt;</para>
        /// <para>&lt;md-enum-item key="user" &gt;普通用户，此时member的id是一个表示用户的ID，比如open_id。具体格式取决于user_id_type参数&lt;/md-enum-item&gt;</para>
        /// <para>&lt;md-enum-item key="chat" &gt;群组，此时member的id是一个Open Chat ID&lt;/md-enum-item&gt;</para>
        /// <para>&lt;md-enum-item key="app" &gt;应用，此时member的id是一个应用的ID&lt;/md-enum-item&gt;</para>
        /// <para>&lt;/md-enum&gt;</para>
        /// <para>必填：否</para>
        /// <para>示例值：user</para>
        /// <para>默认值：user</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>清单角色。移除清单成员时该字段不需要填写。</para>
        /// <para>必填：否</para>
        /// <para>示例值：editor</para>
        /// <para>最大长度：20</para>
        /// </summary>
        [JsonPropertyName("role")]
        public string? Role { get; set; }
    }
}
