// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PostCorehrV2CustomOrgsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建自定义组织 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 创建自定义组织 响应体
/// <para>使用指定信息创建自定义组织，接口内会做相关规则校验。</para>
/// <para>接口ID：7358017162446503940</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/custom_org/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcustom_org%2fcreate</para>
/// </summary>
public record PostCorehrV2CustomOrgsResponseDto
{
    /// <summary>
    /// <para>自定义组织的 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6862995757234914824</para>
    /// </summary>
    [JsonPropertyName("org_id")]
    public string? OrgId { get; set; }
}
