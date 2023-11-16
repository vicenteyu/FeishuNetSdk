namespace FeishuNetSdk.Hire;
/// <summary>
/// 删除账号自定义字段 请求体
/// <para>删除用户在服务商处的身份标示字段（如用户在服务商处的租户 ID）。删除后，不影响已添加帐号对应的自定义字段的值。但在添加新帐号时，将不能再使用此自定义字段。删除不支持撤销，对应的 key 将无法再次复用。</para>
/// <para>接口ID：7195815976042545154</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_account_custom_field/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_account_custom_field%2fbatch_delete</para>
/// </summary>
public record PostHireV1EcoAccountCustomFieldsBatchDeleteBodyDto
{
    /// <summary>
    /// <para>适用范围</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：背调</item>
    /// <item>2：笔试</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("scope")]
    public int? Scope { get; set; }

    /// <summary>
    /// <para>要删除的自定义字段的 key 列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：123</para>
    /// </summary>
    [JsonPropertyName("custom_field_key_list")]
    public string[]? CustomFieldKeyList { get; set; }
}
