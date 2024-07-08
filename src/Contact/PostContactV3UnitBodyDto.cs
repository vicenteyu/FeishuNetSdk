// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3UnitBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建单位 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 创建单位 请求体
/// <para>调用该接口创建一个单位。</para>
/// <para>接口ID：7023995901275242499</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2fcreate</para>
/// </summary>
public record PostContactV3UnitBodyDto
{
    /// <summary>
    /// <para>自定义单位 ID，租户内唯一，创建后不可修改。</para>
    /// <para>**数据校验规则：** 1 ~ 64 个字符，仅支持字母、数字。</para>
    /// <para>**默认值**：空，若不传值则由系统自动生成一个默认 ID。</para>
    /// <para>必填：否</para>
    /// <para>示例值：BU121</para>
    /// </summary>
    [JsonPropertyName("unit_id")]
    public string? UnitId { get; set; }

    /// <summary>
    /// <para>单位名字。</para>
    /// <para>**数据校验规则：** 1 ~ 100 个字符。</para>
    /// <para>**注意**：在租户内，传入的 name 和 unit_type 不允许同时重复。例如，已存在一个名字 `A`、类型 `A`的单位，此时再创建一个名字 `A`、类型 `A` 的单位将会创建失败。</para>
    /// <para>必填：是</para>
    /// <para>示例值：消费者事业部</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义单位类型，创建后不可修改。</para>
    /// <para>**数据校验规则：** 1 ~ 100 个字符。</para>
    /// <para>**注意**：在租户内，传入的 name 和 unit_type 不允许同时重复。例如，已存在一个名字 `A`、类型 `A`的单位，此时再创建一个名字 `A`、类型 `A` 的单位将会创建失败。</para>
    /// <para>必填：是</para>
    /// <para>示例值：子公司</para>
    /// </summary>
    [JsonPropertyName("unit_type")]
    public string UnitType { get; set; } = string.Empty;
}
