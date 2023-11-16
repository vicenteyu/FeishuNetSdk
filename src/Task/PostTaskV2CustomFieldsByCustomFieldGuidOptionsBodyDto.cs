namespace FeishuNetSdk.Task;
/// <summary>
/// 创建自定义任务选项 请求体
/// <para>为单选或多选字段添加一个自定义选项。一个单选/多选字段最大支持100个选项。</para>
/// <para>新添加的选项如果不隐藏，其名字不能和已存在的不隐藏选项的名字重复。</para>
/// <para>接口ID：7270765454292287490</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field-option/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcustom_field-option%2fcreate</para>
/// </summary>
public record PostTaskV2CustomFieldsByCustomFieldGuidOptionsBodyDto
{
    /// <summary>
    /// <para>选项名称，最大50个字符。</para>
    /// <para>必填：否</para>
    /// <para>示例值：高优</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>颜色索引值，支持0～54中的一个数字。如果不填写，则会随机选一个。</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonPropertyName("color_index")]
    public int? ColorIndex { get; set; }

    /// <summary>
    /// <para>要放到某个option之前的option_guid</para>
    /// <para>必填：否</para>
    /// <para>示例值：2bd905f8-ef38-408b-aa1f-2b2ad33b2913</para>
    /// </summary>
    [JsonPropertyName("insert_before")]
    public string? InsertBefore { get; set; }

    /// <summary>
    /// <para>要放到某个option之后的option_guid</para>
    /// <para>必填：否</para>
    /// <para>示例值：b13adf3c-cad6-4e02-8929-550c112b5633</para>
    /// </summary>
    [JsonPropertyName("insert_after")]
    public string? InsertAfter { get; set; }

    /// <summary>
    /// <para>是否隐藏</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("is_hidden")]
    public bool? IsHidden { get; set; }
}
