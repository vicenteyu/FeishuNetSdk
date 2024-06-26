// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2LocationsBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通过地点 ID 批量获取地点信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 通过地点 ID 批量获取地点信息 请求体
/// <para>通过地点 ID 批量获取地点信息</para>
/// <para>接口ID：7252157701853167644</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/location/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2flocation%2fbatch_get</para>
/// </summary>
public record PostCorehrV2LocationsBatchGetBodyDto
{
    /// <summary>
    /// <para>地点 ID 列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("location_ids")]
    public string[] LocationIds { get; set; } = Array.Empty<string>();
}
