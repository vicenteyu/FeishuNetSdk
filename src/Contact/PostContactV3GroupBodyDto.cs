// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3GroupBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建用户组 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 创建用户组 请求体
/// <para>使用该接口创建用户组，请注意创建用户组时应用的通讯录权限范围需为“全部员工”，否则会创建失败，[点击了解通讯录权限范围](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>接口ID：7008085931593089027</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup%2fcreate</para>
/// </summary>
public record PostContactV3GroupBodyDto
{
    /// <summary>
    /// <para>用户组的名字，企业内唯一，最大长度：100 字符</para>
    /// <para>必填：是</para>
    /// <para>示例值：IT外包组</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>用户组描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：IT服务人员的集合</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>用户组的类型。默认为1表示普通用户组</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：普通用户组</item>
    /// <item>2：动态用户组</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }

    /// <summary>
    /// <para>自定义用户组ID，可在创建时自定义，不自定义则由系统自动生成，已创建用户组不允许修改 group_id 。</para>
    /// <para>自定义group_id数据校验规则：</para>
    /// <para>最大长度：64 字符</para>
    /// <para>校验规则：数字、大小写字母的组合，不能包含空格</para>
    /// <para>必填：否</para>
    /// <para>示例值：g122817</para>
    /// </summary>
    [JsonPropertyName("group_id")]
    public string? GroupId { get; set; }
}
