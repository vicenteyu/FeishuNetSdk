// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchHireV1EcoAccountCustomFieldsBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新账号自定义字段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新账号自定义字段 请求体
/// <para>更新用户在服务商处的身份标示字段（如用户在服务商处的租户 ID），此方法只会更新同一 scope 内 key 一致的自定义字段。</para>
/// <para>接口ID：7195815979079434241</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_account_custom_field/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_account_custom_field%2fbatch_update</para>
/// </summary>
public record PatchHireV1EcoAccountCustomFieldsBatchUpdateBodyDto
{
    /// <summary>
    /// <para>适用范围</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：背调</item>
    /// <item>2：笔试</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("scope")]
    public int Scope { get; set; }

    /// <summary>
    /// <para>自定义字段列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("custom_field_list")]
    public EcoAccountCustomFieldData[] CustomFieldLists { get; set; } = Array.Empty<EcoAccountCustomFieldData>();

    /// <summary>
    /// <para>自定义字段列表</para>
    /// </summary>
    public record EcoAccountCustomFieldData
    {
        /// <summary>
        /// <para>自定义字段的标识，同一 scope 内须唯一</para>
        /// <para>必填：是</para>
        /// <para>示例值：org_id</para>
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// <para>自定义字段的名称，用户在添加账号表单看到的控件标题</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n Name { get; set; } = new();

        /// <summary>
        /// <para>自定义字段的名称，用户在添加账号表单看到的控件标题</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：test</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>是否必填</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_required")]
        public bool IsRequired { get; set; }

        /// <summary>
        /// <para>自定义字段的描述，用户在添加账号表单看到的 place holder</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public I18n? Description { get; set; }
    }
}
