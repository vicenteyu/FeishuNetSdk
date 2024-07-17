// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-11
//
// Last Modified By : yxr
// Last Modified On : 2024-07-11
// ************************************************************************
// <copyright file="PutHireV1WebsitesByWebsiteIdChannelsByChannelIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新招聘官网推广渠道 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新招聘官网推广渠道 请求体
/// <para>根据招聘官网 ID 和推广渠道 ID 更改推广渠道，仅支持修改推广渠道名称。</para>
/// <para>接口ID：7097130725263491073</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-channel%2fupdate</para>
/// </summary>
public record PutHireV1WebsitesByWebsiteIdChannelsByChannelIdBodyDto
{
    /// <summary>
    /// <para>推广渠道名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：微信推广渠道</para>
    /// </summary>
    [JsonPropertyName("channel_name")]
    public string ChannelName { get; set; } = string.Empty;
}
