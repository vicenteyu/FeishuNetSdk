// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2026-05-29
// ************************************************************************
// <copyright file="GetTaskV2TasklistsByTasklistGuidResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取清单详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 获取清单详情 响应体
/// <para>获取一个清单的详细信息，包括清单名，所有者，清单成员等。</para>
/// <para>接口ID：7255580838154666012</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/tasklist/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist%2fget</para>
/// </summary>
public record GetTaskV2TasklistsByTasklistGuidResponseDto
{
    /// <summary>
    /// <para>清单详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tasklist")]
    public TasklistSuffix? Tasklist { get; set; }

    /// <summary>
    /// <para>清单详情</para>
    /// </summary>
    public record TasklistSuffix
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
        /// <para>清单所有者</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("owner")]
        public Member? Owner { get; set; }

        /// <summary>
        /// <para>清单协作成员</para>
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
