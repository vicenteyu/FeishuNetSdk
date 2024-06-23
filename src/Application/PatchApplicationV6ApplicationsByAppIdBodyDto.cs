// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchApplicationV6ApplicationsByAppIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新应用分组信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 更新应用分组信息 请求体
/// <para>更新应用的分组信息（分组会影响应用在工作台中的分类情况，请谨慎更新）</para>
/// <para>接口ID：6989432329400270849</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/application/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication%2fpatch</para>
/// </summary>
public record PatchApplicationV6ApplicationsByAppIdBodyDto
{
    /// <summary>
    /// <para>应用分类的国际化描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：["办公效率"]</para>
    /// <para>最大长度：3</para>
    /// </summary>
    [JsonPropertyName("common_categories")]
    public string[]? CommonCategories { get; set; }
}
