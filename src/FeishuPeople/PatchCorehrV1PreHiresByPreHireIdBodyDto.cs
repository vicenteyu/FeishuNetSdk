// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchCorehrV1PreHiresByPreHireIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新待入职信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 更新待入职信息（不推荐） 请求体
/// <para>更新待入职信息接口，本接口只是会更新待入职数据，不会校验数据规则，推荐使用新接口[【更新待入职信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/patch)。</para>
/// <para>接口ID：7072977543561461762</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/pre_hire/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fpre_hire%2fpatch</para>
/// </summary>
public record PatchCorehrV1PreHiresByPreHireIdBodyDto
{
    /// <summary>
    /// <para>招聘投递 ID ，详细信息可以通过招聘的【获取投递信息】接口查询获得（仅部分租户可用）</para>
    /// <para>必填：否</para>
    /// <para>示例值：4719168654814483759</para>
    /// </summary>
    [JsonPropertyName("ats_application_id")]
    public string? AtsApplicationId { get; set; }

    /// <summary>
    /// <para>入职日期</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonPropertyName("hire_date")]
    public string? HireDate { get; set; }

    /// <summary>
    /// <para>雇佣类型</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employee_type")]
    public Enum? EmployeeType { get; set; }

    /// <summary>
    /// <para>雇佣类型</para>
    /// </summary>
    public record Enum
    {
        /// <summary>
        /// <para>枚举值</para>
        /// <para>必填：是</para>
        /// <para>示例值：type_1</para>
        /// </summary>
        [JsonPropertyName("enum_name")]
        public string EnumName { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>人员编号</para>
    /// <para>必填：否</para>
    /// <para>示例值：1245646</para>
    /// </summary>
    [JsonPropertyName("worker_id")]
    public string? WorkerId { get; set; }

    /// <summary>
    /// <para>雇佣类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：正式</para>
    /// </summary>
    [JsonPropertyName("employee_type_id")]
    public string? EmployeeTypeId { get; set; }

    /// <summary>
    /// <para>引用Person ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：656464648662</para>
    /// </summary>
    [JsonPropertyName("person_id")]
    public string? PersonId { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_fields")]
    public ObjectFieldData[]? CustomFields { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// </summary>
    public record ObjectFieldData
    {
        /// <summary>
        /// <para>字段名</para>
        /// <para>必填：是</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
        /// <para>必填：是</para>
        /// <para>示例值：\"Sandy\"</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>成本中心分摊信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("cost_center_rate")]
    public SupportCostCenterItem[]? CostCenterRates { get; set; }

    /// <summary>
    /// <para>成本中心分摊信息</para>
    /// </summary>
    public record SupportCostCenterItem
    {
        /// <summary>
        /// <para>支持的成本中心id</para>
        /// <para>必填：否</para>
        /// <para>示例值：6950635856373745165</para>
        /// </summary>
        [JsonPropertyName("cost_center_id")]
        public string? CostCenterId { get; set; }

        /// <summary>
        /// <para>分摊比例</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("rate")]
        public int? Rate { get; set; }
    }

    /// <summary>
    /// <para>入职状态</para>
    /// <para>- 待入职(preboarding)</para>
    /// <para>- 已删除(deleted)</para>
    /// <para>- 准备就绪(day_one)</para>
    /// <para>- 已撤销(withdrawn)</para>
    /// <para>- 已完成(completed)</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("onboarding_status")]
    public Enum OnboardingStatus { get; set; } = new();
}
