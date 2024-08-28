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
/// <para>飞书招聘的背调或笔试服务商，可通过此接口更新账号自定义字段（比如客户在服务商处的租户 ID、账号 ID等）的名称和描述。</para>
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
        /// <para>当前`scope`下已存在的自定义字段的标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：account_token</para>
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// <para>自定义字段的名称。用户在「飞书招聘」-「设置」-「生态对接」-「笔试/背景调查」下添加账号时看到的表单控件标题</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n Name { get; set; } = new();

        /// <summary>
        /// <para>自定义字段的名称。用户在「飞书招聘」-「设置」-「生态对接」-「笔试/背景调查」下添加账号时看到的表单控件标题</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>自定义字段中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：账号token</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>自定义字段英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Account token</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>是否必填。</para>
        /// <para>**可选值有**：</para>
        /// <para>* `true`：必填</para>
        /// <para>* `false`：非必填</para>
        /// <para>**注意**：该字段在当前接口暂不生效</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_required")]
        public bool IsRequired { get; set; }

        /// <summary>
        /// <para>自定义字段的描述。用户在「飞书招聘」-「设置」-「生态对接」-「笔试/背景调查」下添加账号时看到的控件提示信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public I18n? Description { get; set; }
    }
}
