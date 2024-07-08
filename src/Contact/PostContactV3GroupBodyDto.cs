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
/// <para>调用该接口创建一个用户组。用户组是飞书通讯录中基础实体之一，在用户组内可添加用户或部门资源。各类业务权限管控可以与用户组关联，从而实现高效便捷的成员权限管控。</para>
/// <para>接口ID：7008085931593089027</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup%2fcreate</para>
/// </summary>
public record PostContactV3GroupBodyDto
{
    /// <summary>
    /// <para>用户组名字，长度不能超过 100 字符。</para>
    /// <para>**说明**：用户组名称企业内唯一，如重复设置则会创建失败。</para>
    /// <para>必填：是</para>
    /// <para>示例值：IT 外包组</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>用户组描述，长度不能超过 500 字符。</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// <para>示例值：IT服务人员的集合</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>用户组的类型。默认取值 `1`，表示普通用户组。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：普通用户组</item>
    /// <item>2：暂不支持使用该值</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }

    /// <summary>
    /// <para>自定义用户组 ID。</para>
    /// <para>**数据校验规则：**</para>
    /// <para>- 最大长度：64 字符</para>
    /// <para>- 校验规则：数字、大小写字母的组合，不能包含空格</para>
    /// <para>**默认值**：空，由系统生成一个默认 ID。</para>
    /// <para>必填：否</para>
    /// <para>示例值：g122817</para>
    /// </summary>
    [JsonPropertyName("group_id")]
    public string? GroupId { get; set; }
}
