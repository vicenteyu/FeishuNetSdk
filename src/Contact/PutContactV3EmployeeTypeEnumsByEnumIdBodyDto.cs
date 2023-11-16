namespace FeishuNetSdk.Contact;
/// <summary>
/// 更新人员类型 请求体
/// <para>更新自定义人员类型。</para>
/// <para>接口ID：6985055606752460828</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/employee_type_enum/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2femployee_type_enum%2fupdate</para>
/// </summary>
public record PutContactV3EmployeeTypeEnumsByEnumIdBodyDto
{
    /// <summary>
    /// <para>枚举内容</para>
    /// <para>必填：是</para>
    /// <para>示例值：专家</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// <para>类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：2</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：内置类型</item>
    /// <item>2：自定义</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("enum_type")]
    public int EnumType { get; set; }

    /// <summary>
    /// <para>使用状态</para>
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
    /// <para>i18n定义</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("i18n_content")]
    public I18nContent[]? I18nContents { get; set; }

    /// <summary>
    /// <para>i18n定义</para>
    /// </summary>
    public record I18nContent
    {
        /// <summary>
        /// <para>语言版本</para>
        /// <para>必填：否</para>
        /// <para>示例值：zh_cn</para>
        /// </summary>
        [JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// <para>字段名</para>
        /// <para>必填：否</para>
        /// <para>示例值：专家（中文）</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }
}
