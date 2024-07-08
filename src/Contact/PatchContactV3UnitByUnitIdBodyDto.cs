// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchContactV3UnitByUnitIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改单位信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 修改单位信息 请求体
/// <para>调用该接口修改指定单位的名字。</para>
/// <para>接口ID：7023995901275258883</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2fpatch</para>
/// </summary>
public record PatchContactV3UnitByUnitIdBodyDto
{
    /// <summary>
    /// <para>单位名字。</para>
    /// <para>**数据校验规则**： 1 ~ 100 个字符。</para>
    /// <para>**注意**：</para>
    /// <para>- 请求时该参数必填，请忽略 **必填** 列的 **否**。</para>
    /// <para>- 相同单位类型下，设置的单位名称不能重复。</para>
    /// <para>必填：否</para>
    /// <para>示例值：消费者事业部</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
