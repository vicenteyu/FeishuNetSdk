// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="PostCorehrV2CustomOrgEditEmpCustomOrgBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新人员自定义组织变更记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 更新人员自定义组织变更记录 请求体
/// <para>更新指定员工的某一条自定义组织变更记录</para>
/// <para>接口ID：7425878850969452548</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/employee-custom_org/edit_emp_custom_org</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee-custom_org%2fedit_emp_custom_org</para>
/// </summary>
public record PostCorehrV2CustomOrgEditEmpCustomOrgBodyDto
{
    /// <summary>
    /// <para>用户ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：00067</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义组织类型编码</para>
    /// <para>必填：是</para>
    /// <para>示例值：custom_org_03</para>
    /// </summary>
    [JsonPropertyName("object_api_name")]
    public string ObjectApiName { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义组织ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：7293841029445207596</para>
    /// </summary>
    [JsonPropertyName("job_data_custom_org_id")]
    public string JobDataCustomOrgId { get; set; } = string.Empty;

    /// <summary>
    /// <para>版本ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：7293841029445207593</para>
    /// </summary>
    [JsonPropertyName("version_id")]
    public string VersionId { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义组织列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("custom_org_with_rates")]
    public CustomOrgWithRate[] CustomOrgWithRates { get; set; } = [];

    /// <summary>
    /// <para>自定义组织列表</para>
    /// </summary>
    public record CustomOrgWithRate
    {
        /// <summary>
        /// <para>自定义组织id</para>
        /// <para>必填：是</para>
        /// <para>示例值：7382048365313261588</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>比例</para>
        /// <para>必填：否</para>
        /// <para>示例值：50.01</para>
        /// </summary>
        [JsonPropertyName("rate")]
        public string? Rate { get; set; }
    }

    /// <summary>
    /// <para>生效时间</para>
    /// <para>必填：是</para>
    /// <para>示例值：2024-06-15</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string EffectiveTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>变更原因</para>
    /// <para>必填：否</para>
    /// <para>示例值：编辑雇佣信息的自定义组织</para>
    /// <para>最大长度：1000</para>
    /// </summary>
    [JsonPropertyName("start_reason")]
    public string? StartReason { get; set; }
}
