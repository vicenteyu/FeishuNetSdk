// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostTaskV2CustomFieldsByCustomFieldGuidRemoveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>将自定义字段移出资源 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 将自定义字段移出资源 请求体
/// <para>将自定义字段从资源中移出。移除后，该资源将无法再使用该字段。目前资源的类型支持"tasklist"。</para>
/// <para>如果要移除自定义字段本来就不存在于资源，本接口将正常返回。</para>
/// <para>注意自定义字段是通过清单来实现授权的，如果将自定义字段从所有关联的清单中移除，就意味着任何调用身份都无法再访问改自定义字段。</para>
/// <para>接口ID：7270765454292205570</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/custom_field/remove</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcustom_field%2fremove</para>
/// </summary>
public record PostTaskV2CustomFieldsByCustomFieldGuidRemoveBodyDto
{
    /// <summary>
    /// <para>要从某个资源移除自定义字段的资源类型，目前只支持清单。</para>
    /// <para>必填：是</para>
    /// <para>示例值：tasklist</para>
    /// </summary>
    [JsonPropertyName("resource_type")]
    public string ResourceType { get; set; } = string.Empty;

    /// <summary>
    /// <para>要从某个资源移除自定义字段的资源id，`resource_type`为"tasklist"时，需填写清单的GUID。</para>
    /// <para>必填：是</para>
    /// <para>示例值：0110a4bd-f24b-4a93-8c1a-1732b94f9593</para>
    /// </summary>
    [JsonPropertyName("resource_id")]
    public string ResourceId { get; set; } = string.Empty;
}
