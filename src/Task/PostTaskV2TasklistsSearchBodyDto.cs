// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="PostTaskV2TasklistsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索清单 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 搜索清单 请求体
/// <para>通过清单关键词搜索清单的信息，包括清单名称、清单ID、清单链接、清单描述</para>
/// <para>接口ID：7645347118866549703</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist%2fsearch</para>
/// </summary>
public record PostTaskV2TasklistsSearchBodyDto
{
    /// <summary>
    /// <para>query</para>
    /// <para>必填：否</para>
    /// <para>示例值：测试任务清单</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// <para>过滤参数，包括创建时间，创建人，不设置时不过滤</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("filter")]
    public TasklistSearchFilter? Filter { get; set; }

    /// <summary>
    /// <para>过滤参数，包括创建时间，创建人，不设置时不过滤</para>
    /// </summary>
    public record TasklistSearchFilter
    {
        /// <summary>
        /// <para>清单的创建时间，start_time应该小于end_time</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public TimeRange? CreateTime { get; set; }

        /// <summary>
        /// <para>清单的创建时间，start_time应该小于end_time</para>
        /// </summary>
        public record TimeRange
        {
            /// <summary>
            /// <para>范围内的起始时间 (ISO 8601)</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-03-21T16:15:30+08:00</para>
            /// <para>最大长度：32</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>范围内的结束时间 (ISO 8601)</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-03-21T16:15:30+08:00</para>
            /// <para>最大长度：32</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string? EndTime { get; set; }
        }

        /// <summary>
        /// <para>创建人 IDs，与 user_id_type 类型一致</para>
        /// <para>必填：否</para>
        /// <para>最大长度：500</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string[]? UserId { get; set; }
    }
}
