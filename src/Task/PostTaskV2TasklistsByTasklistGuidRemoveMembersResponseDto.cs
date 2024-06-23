// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostTaskV2TasklistsByTasklistGuidRemoveMembersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>移除清单成员 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 移除清单成员 响应体
/// <para>移除清单的一个或多个协作成员。通过设置`members`字段表示要移除的成员信息。关于member的格式，详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？”章节。</para>
/// <para>清单中同一个成员只能有一个角色，通过的member的id和type可以唯一确定一个成员，因此请求参数中对于要删除的成员，不需要填写"role"字段。</para>
/// <para>如果要移除的成员不在清单中，则被自动忽略，接口返回成功。</para>
/// <para>该接口不能用于移除清单所有者。如果要移除的成员是清单所有者，则会被自动忽略。如要设置清单所有者，需要调用[更新清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/patch)接口。</para>
/// <para>接口ID：7255580838154846236</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/remove_members</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist%2fremove_members</para>
/// </summary>
public record PostTaskV2TasklistsByTasklistGuidRemoveMembersResponseDto
{
    /// <summary>
    /// <para>修改完成后的清单实体</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tasklist")]
    public PostTaskV2TasklistsByTasklistGuidRemoveMembersResponseDtoTasklist? Tasklist { get; set; }

    /// <summary>
    /// <para>修改完成后的清单实体</para>
    /// </summary>
    public record PostTaskV2TasklistsByTasklistGuidRemoveMembersResponseDtoTasklist
    {
        /// <summary>
        /// <para>清单的全局唯一ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：cc371766-6584-cf50-a222-c22cd9055004</para>
        /// </summary>
        [JsonPropertyName("guid")]
        public string? Guid { get; set; }

        /// <summary>
        /// <para>清单名</para>
        /// <para>必填：否</para>
        /// <para>示例值：年会总结工作任务清单</para>
        /// <para>最大长度：300</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>清单创建者</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("creator")]
        public Member? Creator { get; set; }

        /// <summary>
        /// <para>清单创建者</para>
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
            /// <para>成员类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：user</para>
            /// <para>默认值：user</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>成员角色</para>
            /// <para>必填：否</para>
            /// <para>示例值：creator</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonPropertyName("role")]
            public string? Role { get; set; }
        }

        /// <summary>
        /// <para>清单所有者</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("owner")]
        public Member? Owner { get; set; }

        /// <summary>
        /// <para>清单协作成员列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("members")]
        public Member[]? Members { get; set; }

        /// <summary>
        /// <para>该清单分享的applink</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/todo/task_list?guid=b45b360f-1961-4058-b338-7f50c96e1b52</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>清单创建时间戳(ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// <para>清单最后一次更新时间戳（ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }
    }
}
