// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-11
//
// Last Modified By : yxr
// Last Modified On : 2024-07-11
// ************************************************************************
// <copyright file="GetHireV1WebsitesByWebsiteIdChannelsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取招聘官网推广渠道列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取招聘官网推广渠道列表 响应体
/// <para>根据官网 ID 获取推广渠道列表，支持分页查询。</para>
/// <para>接口ID：7097130725263441921</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/list-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-channel%2flist</para>
/// </summary>
public record GetHireV1WebsitesByWebsiteIdChannelsResponseDto
{
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
    /// <para>示例值：eyJvZmZzZXQiOjEwLCJ0aW1NTUyMjM2NzIsImlkIjpudWxsfQ</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>官网推广渠道列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("website_channel_list")]
    public WebsiteChannelInfo[]? WebsiteChannelLists { get; set; }

    /// <summary>
    /// <para>官网推广渠道列表</para>
    /// </summary>
    public record WebsiteChannelInfo
    {
        /// <summary>
        /// <para>推广渠道 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7085989097067563300</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>推广渠道名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：微信推广渠道</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>推广渠道链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：http://recrui-demo.jobs.xxx.cn/485083/?spread=A1KM6A5</para>
        /// </summary>
        [JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// <para>推广渠道推广码</para>
        /// <para>必填：否</para>
        /// <para>示例值：A1KM6A5</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }
    }
}
