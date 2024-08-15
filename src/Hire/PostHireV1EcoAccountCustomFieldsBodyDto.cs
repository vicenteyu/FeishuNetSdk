// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1EcoAccountCustomFieldsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建账号自定义字段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建账号自定义字段 请求体
/// <para>飞书招聘的背调或笔试服务商，可通过此接口创建账号自定义字段，用来标识飞书招聘客户在服务商处的身份（比如客户在服务商处的租户 ID、账号 ID等字段）。</para>
/// <para>## 使用流程</para>
/// <para>客户在「飞书招聘」-「设置」-「生态对接」-「笔试/背景调查」添加服务商账号时，需填写本接口创建的自定义字段，之后系统将通过[账号绑定](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_account/events/created)事件将客户填入的自定义字段值推送给服务商，服务商可据此识别和绑定飞书招聘客户，并以此来[创建背调套餐和附加调查项](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check_package/create)或[创建试卷列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_exam_paper/create)等。</para>
/// <para>详细的接入步骤可参考 [背调/笔试生态接入概览文档](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/ecological-docking/summary)。</para>
/// <para>接口ID：7195815979079581697</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_account_custom_field/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_account_custom_field%2fcreate</para>
/// </summary>
public record PostHireV1EcoAccountCustomFieldsBodyDto
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
        /// <para>自定义字段的标识。在同一`scope`内须唯一</para>
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
            /// <para>中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：账号token</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文名称</para>
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
