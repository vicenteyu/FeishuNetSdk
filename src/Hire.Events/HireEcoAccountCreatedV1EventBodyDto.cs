// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="HireEcoAccountCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>账号绑定 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire.Events;
/// <summary>
/// 账号绑定 事件体
/// <para>飞书招聘客户在「飞书招聘」-「设置」-「生态对接」-「笔试/背景调查」添加三方服务商账号时，系统会推送「账号绑定」事件给服务商。服务商可通过本事件获取客户添加的**账号类型**、**飞书招聘账号 ID** 和 **账号自定义字段信息**，并根据这些信息识别出客户在服务商处的身份，从而完成客户的服务商账号和飞书招聘账号之间的绑定。之后服务商可依据账号绑定关系向客户推送对应的背调套餐或试卷列表。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=hire&amp;version=v1&amp;resource=eco_account&amp;event=created)</para>
/// <para>接口ID：7195815979079417857</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_account/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_account%2fevents%2fcreated</para>
/// </summary>
public record HireEcoAccountCreatedV1EventBodyDto() : EventBodyDto("hire.eco_account.created_v1")
{
    /// <summary>
    /// <para>账号类型</para>
    /// <para>**可选值有**：</para>
    /// <para>1:背调账号,2:笔试账号</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：背调账号</item>
    /// <item>2：笔试账号</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("scope")]
    public int? Scope { get; set; }

    /// <summary>
    /// <para>账号 ID，招聘系统内唯一</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("account_id")]
    public string? AccountId { get; set; }

    /// <summary>
    /// <para>账号名称</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("account_name")]
    public string? AccountName { get; set; }

    /// <summary>
    /// <para>账号适用范围</para>
    /// <para>**可选值有**：</para>
    /// <para>* `1`：社招</para>
    /// <para>* `2`：校招</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>* `1`：社招</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("usage_list")]
    public int[]? UsageList { get; set; }

    /// <summary>
    /// <para>自定义字段键值对</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_field_list")]
    public EcoAccountCustomFieldEventData[]? CustomFieldList { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record EcoAccountCustomFieldEventData
    {
        /// <summary>
        /// <para>自定义字段的标识。通过[创建账号自定义字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_account_custom_field/create)接口推送到招聘系统内</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// <para>客户填写的自定义字段的值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }
}
