// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-10
//
// Last Modified By : yxr
// Last Modified On : 2025-09-10
// ************************************************************************
// <copyright file="PostCompensationV1ArchivesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建薪资档案 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 创建薪资档案 请求体
/// <para>- 该接口适用于员工入职定薪、调薪或者更正档案场景，通过创建调薪任务的方式，为员工生成对应薪资档案数据。</para>
/// <para>- 当员工在调薪生效日期存在档案数据时，则是对该档案进行更正操作。</para>
/// <para>接口ID：7451269641491939329</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/archive/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2farchive%2fcreate</para>
/// </summary>
public record PostCompensationV1ArchivesBodyDto
{
    /// <summary>
    /// <para>外部幂等id，表示操作的唯一标识，避免重复发起，格式为标准的UUIDV4（32 个十六进制字符 + 4 个连字符）</para>
    /// <para>必填：是</para>
    /// <para>示例值：123e4567-e89b-42d3-a456-426614174000</para>
    /// </summary>
    [JsonPropertyName("unique_id")]
    public string UniqueId { get; set; } = string.Empty;

    /// <summary>
    /// <para>操作人ID，具体类型由入参中的 user_id_type 指定，选择应用身份鉴权时，该参数不能为空</para>
    /// <para>必填：否</para>
    /// <para>示例值：7337149697626801708</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public string? OperatorId { get; set; }

    /// <summary>
    /// <para>员工id，具体类型由入参中的 user_id_type 指定</para>
    /// <para>必填：是</para>
    /// <para>示例值：7337149697626801708</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>生效时间，日期格式为 YYYY-MM-DD，字符长度为10</para>
    /// <para>必填：是</para>
    /// <para>示例值：2024-11-12</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string EffectiveTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>币种ID，通过[查询货币信息](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-currency/search?appId=cli_a63f5fc01866100c)接口可获得</para>
    /// <para>必填：是</para>
    /// <para>示例值：6863329932261459464</para>
    /// </summary>
    [JsonPropertyName("currency_id")]
    public string CurrencyId { get; set; } = string.Empty;

    /// <summary>
    /// <para>薪资方案ID，通过[批量查询薪资方案](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/plan/list)接口可获得</para>
    /// <para>必填：是</para>
    /// <para>示例值：7431430313074247212</para>
    /// </summary>
    [JsonPropertyName("plan_id")]
    public string PlanId { get; set; } = string.Empty;

    /// <summary>
    /// <para>薪资方案TID，通过[批量查询薪资方案](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/plan/list)可获得</para>
    /// <para>必填：是</para>
    /// <para>示例值：7431430313074279980</para>
    /// </summary>
    [JsonPropertyName("plan_tid")]
    public string PlanTid { get; set; } = string.Empty;

    /// <summary>
    /// <para>调薪原因ID，通过[批量查询定调薪原因](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/change_reason/list)接口可获得</para>
    /// <para>必填：是</para>
    /// <para>示例值：7125907336899888684</para>
    /// </summary>
    [JsonPropertyName("change_reason_id")]
    public string ChangeReasonId { get; set; } = string.Empty;

    /// <summary>
    /// <para>- 薪资项值集合，所填薪资项信息必须是该方案中的薪资项</para>
    /// <para>- 仅需填写方案中可编辑的薪资项即可，不可编辑的薪资项不能传入，否则会校验报错。</para>
    /// <para>- 根据参数plan_id，可通过[批量查询薪资方案](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/plan/list)接口获得对应的具体方案信息</para>
    /// <para>必填：是</para>
    /// <para>最大长度：2147483647</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("item_value_lists")]
    public ArchiveItemValue[] ItemValueLists { get; set; } = Array.Empty<ArchiveItemValue>();

    /// <summary>
    /// <para>- 薪资项值集合，所填薪资项信息必须是该方案中的薪资项</para>
    /// <para>- 仅需填写方案中可编辑的薪资项即可，不可编辑的薪资项不能传入，否则会校验报错。</para>
    /// <para>- 根据参数plan_id，可通过[批量查询薪资方案](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/plan/list)接口获得对应的具体方案信息</para>
    /// </summary>
    public record ArchiveItemValue
    {
        /// <summary>
        /// <para>薪资项ID，具体值可通过接口查询[批量查询薪资项](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/item/list)</para>
        /// <para>必填：是</para>
        /// <para>示例值：7244131355509917228</para>
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; } = string.Empty;

        /// <summary>
        /// <para>- 薪资项的值，该值的单位取决于入参currency_id对应的币种</para>
        /// <para>- 字符串为数字格式，且长度最大不超过18个字符，最小长度为1个字符，不支持负数，不允许为空</para>
        /// <para>必填：是</para>
        /// <para>示例值：200.00</para>
        /// </summary>
        [JsonPropertyName("item_value")]
        public string ItemValue { get; set; } = string.Empty;

        /// <summary>
        /// <para>- 员工转正后薪资项的值，该值的单位取决于入参currency_id对应的币种。字符串为数字格式，且长度不超过18个字符，不支持负数</para>
        /// <para>- 当员工处于试用期且入参plan_id对应的薪资方案已开启试用期时，才能填写该值。</para>
        /// <para>- 所有可编辑薪资项的转正值要么都为空，要么都不为空，否则会报错。</para>
        /// <para>必填：否</para>
        /// <para>示例值：600.00</para>
        /// </summary>
        [JsonPropertyName("item_value_regular")]
        public string? ItemValueRegular { get; set; }
    }

    /// <summary>
    /// <para>调薪说明，长度不超过1000字符</para>
    /// <para>必填：否</para>
    /// <para>示例值：因2024年Q2绩效优秀，对该同学调薪10%</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>更正说明，长度不超过1000字符，如果本次操作为更正员工薪资档案时，该字段即为更正调薪的说明。</para>
    /// <para>必填：否</para>
    /// <para>示例值：更正2024年Q2绩效调薪金额</para>
    /// </summary>
    [JsonPropertyName("edit_remark")]
    public string? EditRemark { get; set; }
}
