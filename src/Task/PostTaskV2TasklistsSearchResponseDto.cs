// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="PostTaskV2TasklistsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索清单 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 搜索清单 响应体
/// <para>通过清单关键词搜索清单的信息，包括清单名称、清单ID、清单链接、清单描述</para>
/// <para>接口ID：7645347118866549703</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist%2fsearch</para>
/// </summary>
public record PostTaskV2TasklistsSearchResponseDto : IPageableResponse<PostTaskV2TasklistsSearchResponseDto.TasklistSearchItem>
{
    /// <summary>
    /// <para>items</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("items")]
    public TasklistSearchItem[] Items { get; set; } = [];

    /// <summary>
    /// <para>items</para>
    /// </summary>
    public record TasklistSearchItem
    {
        /// <summary>
        /// <para>任务清单 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：123456789</para>
        /// <para>最大长度：64</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>包含任务清单基本信息的卡片，用户搜索关键词命中的文本片段，使用&lt;h&gt;&lt;/h&gt;标签包裹标注</para>
        /// <para>必填：否</para>
        /// <para>示例值：任务清单&lt;h&gt;搜索&lt;/h&gt;</para>
        /// <para>最大长度：128</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("display_info")]
        public string? DisplayInfo { get; set; }

        /// <summary>
        /// <para>任务清单元信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("meta_data")]
        public TasklistSearchMeta? MetaData { get; set; }

        /// <summary>
        /// <para>任务清单元信息</para>
        /// </summary>
        public record TasklistSearchMeta
        {
            /// <summary>
            /// <para>任务清单的 AppLink</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://applink.feishu.cn/client/todo/detail?guid=ed03112a-0a25-451e-8453-ba1d80cc1b7e</para>
            /// <para>最大长度：1024</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("app_link")]
            public string? AppLink { get; set; }

            /// <summary>
            /// <para>任务清单头像</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://p3-lark-file.byteimg.com/img/lark-avatar-staging/default-avatar_44ae0ca3-e140-494b-956f-78091e348435~100x100.jpg</para>
            /// <para>最大长度：1024</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("avatar")]
            public string? Avatar { get; set; }

            /// <summary>
            /// <para>任务清单描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：这是一个用来测试的任务清单</para>
            /// <para>最大长度：128</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }
        }
    }

    /// <summary>
    /// <para>total</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
