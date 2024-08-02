// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-18
//
// Last Modified By : yxr
// Last Modified On : 2024-07-18
// ************************************************************************
// <copyright file="GetHireV1WebsitesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取招聘官网列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取招聘官网列表 响应体
/// <para>获取招聘官网列表，返回信息包括官网名称、官网ID、招聘渠道ID等。</para>
/// <para>接口ID：6990661791098699779</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite%2flist</para>
/// </summary>
public record GetHireV1WebsitesResponseDto
{
    /// <summary>
    /// <para>官网列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Website[]? Items { get; set; }

    /// <summary>
    /// <para>官网列表</para>
    /// </summary>
    public record Website
    {
        /// <summary>
        /// <para>官网ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1213213123123</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>官网名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>官网名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>官网中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：校招官网</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>官网英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：campus recruitment site</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>流程类型</para>
        /// <para>- 1: 社招</para>
        /// <para>- 2: 校招</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("process_type_list")]
        public int[]? ProcessTypeList { get; set; }

        /// <summary>
        /// <para>招聘渠道ID，每个官网拥有唯一的招聘渠道ID，可用于[职位发布至官网](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/advertisement/publish)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1213213123123</para>
        /// </summary>
        [JsonPropertyName("job_channel_id")]
        public string? JobChannelId { get; set; }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ==</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
