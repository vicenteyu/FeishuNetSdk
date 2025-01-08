// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-01-11
//
// Last Modified By : yxr
// Last Modified On : 2025-01-11
// ************************************************************************
// <copyright file="PostCorehrV2EnumsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询枚举信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询枚举信息 请求体
/// <para>根据枚举的APIName查询枚举详细信息，用于BPM等场景获取枚举选项。</para>
/// <para>接口ID：7457854043681603588</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/enum/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fenum%2fsearch</para>
/// </summary>
public record PostCorehrV2EnumsSearchBodyDto
{
    /// <summary>
    /// <para>枚举apiname列表（不传值查询结果为空）</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("enum_apiname_lists")]
    public string[]? EnumApinameLists { get; set; }
}
