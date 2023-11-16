namespace FeishuNetSdk.Contact;
/// <summary>
/// 创建单位 请求体
/// <para>该接口用于创建单位。注意：单位功能属于旗舰版付费功能，企业需开通对应版本才可以创建单位，不同版本请参考[飞书版本对比](https://www.feishu.cn/service)。</para>
/// <para>接口ID：7023995901275242499</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2fcreate</para>
/// </summary>
public record PostContactV3UnitBodyDto
{
    /// <summary>
    /// <para>单位ID。可自定义，不传时默认自动生成。1-64字节范围大小，需为数字字母</para>
    /// <para>必填：否</para>
    /// <para>示例值：BU121</para>
    /// </summary>
    [JsonPropertyName("unit_id")]
    public string? UnitId { get; set; }

    /// <summary>
    /// <para>单位的名字，长度范围为1-100个字符</para>
    /// <para>必填：是</para>
    /// <para>示例值：消费者事业部</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>单位类型，长度范围为1-100个字符，创建后不可修改</para>
    /// <para>必填：是</para>
    /// <para>示例值：子公司</para>
    /// </summary>
    [JsonPropertyName("unit_type")]
    public string UnitType { get; set; } = string.Empty;
}
