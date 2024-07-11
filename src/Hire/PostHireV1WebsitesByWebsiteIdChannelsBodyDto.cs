// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-11
//
// Last Modified By : yxr
// Last Modified On : 2024-07-11
// ************************************************************************
// <copyright file="PostHireV1WebsitesByWebsiteIdChannelsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新建招聘官网推广渠道 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 新建招聘官网推广渠道 请求体
/// <para>根据招聘官网 ID 和推广渠道名称创建招聘官网推广渠道。</para>
/// <para>接口ID：7097130725263474689</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-channel%2fcreate</para>
/// </summary>
public record PostHireV1WebsitesByWebsiteIdChannelsBodyDto
{
    /// <summary>
    /// <para>推广渠道名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：小爱侧推广渠道</para>
    /// </summary>
    [JsonPropertyName("channel_name")]
    public string ChannelName { get; set; } = string.Empty;
}
