// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="PatchTaskV2TasklistsByTasklistGuidBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新清单 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 更新清单 请求体
/// <para>更新清单，可以更新清单的名字和所有者。</para>
/// <para>更新清单时，将`update_fields`字段中填写所有要修改的清单字段名，同时在`tasklist`字段中填写要修改的字段的新值即可。更新调用规范详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 关于资源的更新”章节。</para>
/// <para>支持更新的字段包括:</para>
/// <para>* `name` - 清单名字</para>
/// <para>* `owner` - 清单所有者</para>
/// <para>更新清单所有者（owner）时，如果该成员已经是清单的“可编辑”或者“可阅读”角色，则该成员将直接升级为所有者角色，自动从清单的成员列表中消失。这是因为同一个用户在同一个清单中只能有一个角色。同时，支持使用`origin_owner_to_role`字段将原有所有者变为可编辑/可阅读角色或者直接退出清单。</para>
/// <para>该接口不能用于更新清单的成员和增删清单中的任务。</para>
/// <para>* 如要增删清单中的成员，可以使用[添加清单成员](/ssl:ttdoc:/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/add_members)和[移除清单成员](/ssl:ttdoc:/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/remove_members)接口。</para>
/// <para>* 如要增删清单中的任务，可以使用[任务加入清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/add_tasklist)和[任务移出清单]( https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/remove_tasklist)接口。</para>
/// <para>接口ID：7255580838154682396</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/tasklist/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist%2fpatch</para>
/// </summary>
public record PatchTaskV2TasklistsByTasklistGuidBodyDto
{
    /// <summary>
    /// <para>要更新清单的数据</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("tasklist")]
    public InputTasklist Tasklist { get; set; } = new();

    /// <summary>
    /// <para>要更新清单的数据</para>
    /// </summary>
    public record InputTasklist
    {
        /// <summary>
        /// <para>清单名称。如要更新，不能设为空。最大100个字符。</para>
        /// <para>必填：否</para>
        /// <para>示例值：年会工作任务清单</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>更新的清单所有者。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("owner")]
        public Member? Owner { get; set; }

        /// <summary>
        /// <para>更新的清单所有者。</para>
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
            /// <para>成员的类型，可以是"user"或者"app"。所有者的类型不可以是"chat"。</para>
            /// <para>必填：否</para>
            /// <para>示例值：user</para>
            /// <para>默认值：user</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>成员角色，此时必须是"owner"</para>
            /// <para>必填：否</para>
            /// <para>示例值：owner</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonPropertyName("role")]
            public string? Role { get; set; }
        }
    }

    /// <summary>
    /// <para>要更新的字段名，支持</para>
    /// <para>必填：是</para>
    /// <para>最小长度：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>name：更新清单名</item>
    /// <item>owner：更新清单所有者</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("update_fields")]
    public string[] UpdateFields { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>该字段表示如果更新了新的所有者，则将原所有者设为指定的新的角色。仅在更新清单所有者时生效。支持"editor", "viewer"和"none"。默认为"none"。</para>
    /// <para>如果不设置或设为"none"，原清单所有者将不具有任何清单的角色。如果没有通过其他渠道（比如通过协作群组间接授权），原清单所有者将失去对清单的所有权限。</para>
    /// <para>必填：否</para>
    /// <para>示例值：editor</para>
    /// <para>可选值：<list type="bullet">
    /// <item>editor：原所有者变为可编辑角色</item>
    /// <item>viewer：原所有者变为可阅读角色</item>
    /// <item>none：原所有者直接退出清单</item>
    /// </list></para>
    /// <para>默认值：none</para>
    /// </summary>
    [JsonPropertyName("origin_owner_to_role")]
    public string? OriginOwnerToRole { get; set; }
}
