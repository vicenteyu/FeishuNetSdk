// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-30
//
// Last Modified By : yxr
// Last Modified On : 2026-05-30
// ************************************************************************
// <copyright file="Member.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>成员信息</summary>
// ************************************************************************
namespace FeishuNetSdk.Core;

/// <summary>
/// <para>成员信息</para>
/// </summary>
public record Member
{
    /// <summary>
    /// <para>表示member的id</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// <para>成员的类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：user</para>
    /// <para>默认值：user</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// <para>成员角色</para>
    /// <para>必填：否</para>
    /// <para>示例值：creator</para>
    /// <para>最大长度：20</para>
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>
    /// <para>成员名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：张明德（明德）</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

