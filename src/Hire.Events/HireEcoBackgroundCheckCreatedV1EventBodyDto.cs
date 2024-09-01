// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="HireEcoBackgroundCheckCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建背调 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire.Events;
/// <summary>
/// 创建背调 事件体
/// <para>飞书招聘客户在招聘系统给候选人安排背调后，系统会推送「创建背调」事件给对应的背调服务商。服务商可根据此事件获取该背调的候选人、委托人和自定义字段等信息，并根据这些信息完成内部的背调订单的创建和绑定，之后可通过[更新背调订单进度](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check/update_progress)、[回传背调订单的最终结果](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check/update_result)将背调信息回传给招聘系统。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=hire&amp;version=v1&amp;resource=eco_background_check&amp;event=created)</para>
/// <para>接口ID：7195815979079516161</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check%2fevents%2fcreated</para>
/// </summary>
public record HireEcoBackgroundCheckCreatedV1EventBodyDto() : EventBodyDto("hire.eco_background_check.created_v1")
{
    /// <summary>
    /// <para>背调 ID，招聘系统内唯一。服务商可将此 ID与内部的背调订单绑定</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("background_check_id")]
    public string? BackgroundCheckId { get; set; }

    /// <summary>
    /// <para>账号 ID，招聘系统内唯一。可通过[账号绑定](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_account/events/created)事件获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("account_id")]
    public string? AccountId { get; set; }

    /// <summary>
    /// <para>套餐 ID，通过[创建背调套餐和附加调查项](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check_package/create)传入</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("package_id")]
    public string? PackageId { get; set; }

    /// <summary>
    /// <para>附件调查项 ID 列表，通过[创建背调套餐和附加调查项](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check_package/create)传入</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("additional_item_id_list")]
    public string[]? AdditionalItemIdList { get; set; }

    /// <summary>
    /// <para>备注</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// <para>候选人信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("candidate_info")]
    public EcoBackgroundCheckCreateEventCandidateInfo? CandidateInfo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record EcoBackgroundCheckCreateEventCandidateInfo
    {
        /// <summary>
        /// <para>候选人姓名</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>候选人手机号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("mobile")]
        public EcoBackgroundCheckCreateEventMobile? Mobile { get; set; }

        /// <summary>
        /// <para>候选人邮箱</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>名字</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// <para>姓氏</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }
    }

    /// <summary>
    /// <para>联系人（委托人）信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("client_contact_info")]
    public EcoBackgroundCheckCreateEventContactInfo? ClientContactInfo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record EcoBackgroundCheckCreateEventContactInfo
    {
        /// <summary>
        /// <para>联系人姓名</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>联系人手机号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("mobile")]
        public EcoBackgroundCheckCreateEventMobile? Mobile { get; set; }

        /// <summary>
        /// <para>联系人邮箱</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public record EcoBackgroundCheckCreateEventMobile
    {
        /// <summary>
        /// <para>电话国家区号，遵循国际统一标准，可参考 [国际长途电话区号表](https://baike.baidu.com/item/%E5%9B%BD%E9%99%85%E9%95%BF%E9%80%94%E7%94%B5%E8%AF%9D%E5%8C%BA%E5%8F%B7%E8%A1%A8/12803495)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>手机号码</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("number")]
        public string? Number { get; set; }
    }

    /// <summary>
    /// <para>自定义字段键值对</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_field_list")]
    public EcoBackgroundCheckCreateEventCustomKv[]? CustomFieldList { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record EcoBackgroundCheckCreateEventCustomKv
    {
        /// <summary>
        /// <para>自定义字段标识，由[创建背调自定义字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check_custom_field/create)接口传入</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// <para>自定义字段值，用户在发起背调时填入，详情可参考[创建背调自定义字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check_custom_field/create)传入的自定义字段类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }
}
