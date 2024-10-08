// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3EmployeeTypeEnumsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增人员类型 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 新增人员类型 请求体
/// <para>调用该接口新增一个自定义的人员类型。人员类型是用户属性之一，用于灵活标记用户的身份类型。</para>
/// <para>## 使用限制</para>
/// <para>自定义的人员类型数量上限为 255，其中创建后又删除的自定义人员类型也会计入数量限制内。</para>
/// <para>接口ID：6985055606752575516</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/employee_type_enum/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2femployee_type_enum%2fcreate</para>
/// </summary>
public record PostContactV3EmployeeTypeEnumsBodyDto
{
    /// <summary>
    /// <para>人员类型的选项内容。</para>
    /// <para>必填：是</para>
    /// <para>示例值：专家</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// <para>人员类型的选项类型。新增人员类型时固定取值为 `2` 即可。</para>
    /// <para>必填：是</para>
    /// <para>示例值：2</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：内置类型，只读。新增人员类型时不支持选择该类型。</item>
    /// <item>2：自定义。</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("enum_type")]
    public int EnumType { get; set; }

    /// <summary>
    /// <para>人员类型的选项激活状态。只有已激活的选项可以用于配置用户属性。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：激活</item>
    /// <item>2：未激活</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("enum_status")]
    public int EnumStatus { get; set; }

    /// <summary>
    /// <para>选项内容的国际化配置。</para>
    /// <para>**说明**：在飞书客户端查看用户人员类型时，系统会根据客户端语言环境，自动展示相匹配的选项语言。如果相应语言不在选项国际化配置当中，则会展示默认选项内容（即 content 字段）。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("i18n_content")]
    public I18nContent[]? I18nContents { get; set; }

    /// <summary>
    /// <para>选项内容的国际化配置。</para>
    /// <para>**说明**：在飞书客户端查看用户人员类型时，系统会根据客户端语言环境，自动展示相匹配的选项语言。如果相应语言不在选项国际化配置当中，则会展示默认选项内容（即 content 字段）。</para>
    /// </summary>
    public record I18nContent
    {
        /// <summary>
        /// <para>语言版本。例如：</para>
        /// <para>- zh_cn：中文</para>
        /// <para>- en_us：英文</para>
        /// <para>- ja_jp：日文</para>
        /// <para>必填：否</para>
        /// <para>示例值：zh_cn</para>
        /// </summary>
        [JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// <para>语言版本对应的内容。</para>
        /// <para>**数据校验规则：**</para>
        /// <para>长度范围：`1` 字符 ～ `100` 字符</para>
        /// <para>必填：否</para>
        /// <para>示例值：专家（中文）</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }
}
