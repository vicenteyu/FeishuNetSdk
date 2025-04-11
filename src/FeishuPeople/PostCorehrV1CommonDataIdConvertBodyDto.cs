// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV1CommonDataIdConvertBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>ID 转换 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// ID 转换 请求体
/// <para>该接口用来进行飞书人事和飞书通讯录、people admin 的各种 ID 转换（仅适用于飞书人事新链路租户）</para>
/// <para>接口ID：7338765273649348612</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/common_data-id/convert</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcommon_data-id%2fconvert</para>
/// </summary>
public record PostCorehrV1CommonDataIdConvertBodyDto
{
    /// <summary>
    /// <para>ID 列表（最多传入 100 个 ID，ID 长度限制 50 个字符）</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("ids")]
    public string[] Ids { get; set; } = Array.Empty<string>();
}
