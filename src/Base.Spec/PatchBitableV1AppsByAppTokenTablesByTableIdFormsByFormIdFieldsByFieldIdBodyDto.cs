// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsByFieldIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新表单问题 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base.Spec;
/// <summary>
/// 更新表单问题 请求体
/// <para>该接口用于更新表单中的问题项</para>
/// <para>接口ID：7112628058154893314</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/form/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-form-field%2fpatch</para>
/// </summary>
public record PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsByFieldIdBodyDto
{
    /// <summary>
    /// <para>上一个表单问题 ID，用于支持调整表单问题的顺序，通过前一个表单问题的 field_id 来确定位置；如果 pre_field_id 为空字符串，则说明要排到首个表单问题</para>
    /// <para>**示例值**："fldjX7dUj5"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("pre_field_id")]
    public string? PreFieldId { get; set; }

    /// <summary>
    /// <para>表单问题</para>
    /// <para>**示例值**："多行文本"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// <para>问题描述</para>
    /// <para>**示例值**："多行文本描述"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>是否必填</para>
    /// <para>**示例值**：true</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>
    /// <para>是否可见，当值为 false 时，不允许更新其他字段。</para>
    /// <para>**示例值**：true</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("visible")]
    public bool? Visible { get; set; }
}
