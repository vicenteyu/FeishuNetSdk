// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsByFieldIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新表单问题 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 更新表单问题 响应体
/// <para>更新表单中的问题项。</para>
/// <para>接口ID：7112628058154893314</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/form/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-form-field%2fpatch</para>
/// </summary>
public record PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsByFieldIdResponseDto
{
    /// <summary>
    /// <para>更新后的表单问题项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("field")]
    public AppTableFormPatchedField? Field { get; set; }

    /// <summary>
    /// <para>更新后的表单问题项</para>
    /// </summary>
    public record AppTableFormPatchedField
    {
        /// <summary>
        /// <para>要更新的表单问题的前一个表单问题的 `field_id`，用于更新当前表单问题的位置。若该字段为空字符串，则表示将该表单问题的顺序排至首个位置。</para>
        /// <para>必填：否</para>
        /// <para>示例值：fldjX7dUj5</para>
        /// </summary>
        [JsonPropertyName("pre_field_id")]
        public string? PreFieldId { get; set; }

        /// <summary>
        /// <para>表单问题</para>
        /// <para>必填：否</para>
        /// <para>示例值：任务名称</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>问题描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：请概述该任务</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>是否必填</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// <para>是否可见，当值为 false 时，不允许更新其他字段。</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("visible")]
        public bool? Visible { get; set; }
    }
}
