// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAcsV1RuleExternalResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建或更新权限组 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Acs;
/// <summary>
/// 创建或更新权限组 响应体
/// <para>创建或更新权限组</para>
/// <para>接口ID：7321978105899122716</para>
/// <para>文档地址：https://open.feishu.cn/document/acs-v1/rule_external/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2frule_external%2fcreate</para>
/// </summary>
public record PostAcsV1RuleExternalResponseDto
{
    /// <summary>
    /// <para>权限组id</para>
    /// <para>必填：是</para>
    /// <para>示例值：7298933941867135276</para>
    /// <para>最大长度：128</para>
    /// </summary>
    [JsonPropertyName("rule_id")]
    public string RuleId { get; set; } = string.Empty;
}
