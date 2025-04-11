// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostApaasV1UserTasksByTaskIdRollbackPointsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询人工任务可退回的位置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 查询人工任务可退回的位置 响应体
/// <para>查询当前任务可以退回的位置</para>
/// <para>接口ID：7446337145820381188</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/rollback_points</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fuser_task%2frollback_points</para>
/// </summary>
public record PostApaasV1UserTasksByTaskIdRollbackPointsResponseDto
{
    /// <summary>
    /// <para>任务列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tasks")]
    public AllowedRollbaclkTaskItemType[]? Tasks { get; set; }

    /// <summary>
    /// <para>任务列表</para>
    /// </summary>
    public record AllowedRollbaclkTaskItemType
    {
        /// <summary>
        /// <para>任务ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1234</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>任务对应的名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("activity_label")]
        public I18n[]? ActivityLabels { get; set; }

        /// <summary>
        /// <para>任务对应的名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>多语Code</para>
            /// <para>必填：否</para>
            /// <para>示例值：2052</para>
            /// </summary>
            [JsonPropertyName("language_code")]
            public string? LanguageCode { get; set; }

            /// <summary>
            /// <para>多语对应的任务名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：人工任务名称</para>
            /// </summary>
            [JsonPropertyName("text")]
            public string? Text { get; set; }
        }

        /// <summary>
        /// <para>是否开始节点</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_start")]
        public bool? IsStart { get; set; }
    }
}
