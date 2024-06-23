// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAdminV1BadgeImagesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传勋章图片 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Admin;
/// <summary>
/// 上传勋章图片 响应体
/// <para>通过该接口可以上传勋章详情图、挂饰图的文件，获取对应的文件key。</para>
/// <para>接口ID：7104154222309130243</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/admin-v1/badge/badge/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fadmin-v1%2fbadge_image%2fcreate</para>
/// </summary>
public record PostAdminV1BadgeImagesResponseDto
{
    /// <summary>
    /// <para>图片的key</para>
    /// <para>必填：否</para>
    /// <para>示例值：f02a98aa-1413-4af6-93ab-431ba9e5f2cg</para>
    /// </summary>
    [JsonPropertyName("image_key")]
    public string? ImageKey { get; set; }
}
