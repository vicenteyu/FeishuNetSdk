// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-11
//
// Last Modified By : yxr
// Last Modified On : 2024-07-11
// ************************************************************************
// <copyright file="PutHireV1WebsitesByWebsiteIdChannelsByChannelIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新招聘官网推广渠道 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新招聘官网推广渠道 响应体
/// <para>根据招聘官网 ID 和推广渠道 ID 更改推广渠道，仅支持修改推广渠道名称。</para>
/// <para>接口ID：7097130725263491073</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-channel%2fupdate</para>
/// </summary>
public record PutHireV1WebsitesByWebsiteIdChannelsByChannelIdResponseDto
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
