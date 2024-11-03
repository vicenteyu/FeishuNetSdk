// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-03
//
// Last Modified By : yxr
// Last Modified On : 2024-11-03
// ************************************************************************
// <copyright file="PostCorehrV2LocationsByLocationIdAddressesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加地点地址 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 添加地点地址 响应体
/// <para>添加地点地址</para>
/// <para>接口ID：7420421437192912899</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/location-address/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2flocation-address%2fcreate</para>
/// </summary>
public record PostCorehrV2LocationsByLocationIdAddressesResponseDto
{
    /// <summary>
    /// <para>地址 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6862995757234914824</para>
    /// </summary>
    [JsonPropertyName("address_id")]
    public string? AddressId { get; set; }
}
