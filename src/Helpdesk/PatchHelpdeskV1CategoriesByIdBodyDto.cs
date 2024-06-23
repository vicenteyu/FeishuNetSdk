// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchHelpdeskV1CategoriesByIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新知识库分类详情 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 更新知识库分类详情 请求体
/// <para>该接口用于更新知识库分类详情。</para>
/// <para>接口ID：6955768699895595010</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/faq-management/category/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fcategory%2fpatch</para>
/// </summary>
public record PatchHelpdeskV1CategoriesByIdBodyDto
{
    /// <summary>
    /// <para>名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：创建团队和邀请成员</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>父知识库分类ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("parent_id")]
    public string? ParentId { get; set; }
}
