namespace FeishuNetSdk.Task;
/// <summary>
/// 将自定义字段加入资源 请求体
/// <para>将自定义字段加入一个资源。目前资源类型支持清单tasklist。一个自定义字段可以加入多个清单中。加入后，该清单可以展示任务的该字段的值，同时基于该字段实现筛选，分组等功能。</para>
/// <para>如果自定义字段的设置被更新，字段加入的所有字段都能收到这个更新，并进行相应的展示。</para>
/// <para>接口ID：7270765454292189186</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/add</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcustom_field%2fadd</para>
/// </summary>
public record PostTaskV2CustomFieldsByCustomFieldGuidAddBodyDto
{
    /// <summary>
    /// <para>要将自定义字段添加到一个资源的资源类型。目前只支持tasklist</para>
    /// <para>必填：是</para>
    /// <para>示例值：tasklist</para>
    /// </summary>
    [JsonPropertyName("resource_type")]
    public string ResourceType { get; set; } = string.Empty;

    /// <summary>
    /// <para>要将自定义字段添加到的资源id，目前只支持tasklist_guid</para>
    /// <para>必填：是</para>
    /// <para>示例值：0110a4bd-f24b-4a93-8c1a-1732b94f9593</para>
    /// </summary>
    [JsonPropertyName("resource_id")]
    public string ResourceId { get; set; } = string.Empty;
}
