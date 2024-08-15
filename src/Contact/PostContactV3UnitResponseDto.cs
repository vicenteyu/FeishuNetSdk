// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3UnitResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建单位 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 创建单位 响应体
/// <para>调用该接口创建一个单位。</para>
/// <para>## 前提条件</para>
/// <para>单位属于付费功能，企业需要开通对应的飞书版本才可以使用。了解更多，可参见[单位管理](https://www.feishu.cn/hc/zh-CN/articles/333548009177)。</para>
/// <para>## 使用限制</para>
/// <para>单租户内单位总数上限为 1,000。</para>
/// <para>接口ID：7023995901275242499</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2fcreate</para>
/// </summary>
public record PostContactV3UnitResponseDto
{
    /// <summary>
    /// <para>单位 ID。后续可使用该 ID 对单位进行修改、删除、查询以及绑定部门等操作。</para>
    /// <para>必填：是</para>
    /// <para>示例值：BU121</para>
    /// </summary>
    [JsonPropertyName("unit_id")]
    public string UnitId { get; set; } = string.Empty;
}
