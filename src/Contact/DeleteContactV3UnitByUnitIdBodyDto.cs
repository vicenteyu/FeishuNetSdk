// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DeleteContactV3UnitByUnitIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除单位 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 删除单位 请求体
/// <para>使用该接口删除单位，需要有更新单位的权限。注意：如果单位的单位类型被其它的业务使用，不允许删除。</para>
/// <para>接口ID：7023995901275275267</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2fdelete</para>
/// </summary>
public record DeleteContactV3UnitByUnitIdBodyDto
{
}
