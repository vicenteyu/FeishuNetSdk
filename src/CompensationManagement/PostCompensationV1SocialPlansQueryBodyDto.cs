// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="PostCompensationV1SocialPlansQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>根据方案ID和生效日期批量查询参保方案 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 根据方案ID和生效日期批量查询参保方案 请求体
/// <para>通过plan_ids列表和effective_date联合过滤数据库中的参保方案数据</para>
/// <para>接口ID：7420038908975431682</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/social_plan/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fsocial_plan%2fquery</para>
/// </summary>
public record PostCompensationV1SocialPlansQueryBodyDto
{
    /// <summary>
    /// <para>参保方案ID列表，最少1个，最大200，可以通过[通过员工ID批量获取社保增减员记录](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/social_archive_adjust_record/query)或[批量获取员工参保档案](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/social_archive/query)接口获取</para>
    /// <para>必填：是</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("plan_ids")]
    public string[] PlanIds { get; set; } = [];

    /// <summary>
    /// <para>生效日期，查询在该日期生效的参保方案数据，日期格式为：YYYY-mm-dd，长度为 10 字符</para>
    /// <para>必填：是</para>
    /// <para>示例值：2024-01-01</para>
    /// </summary>
    [JsonPropertyName("effective_date")]
    public string EffectiveDate { get; set; } = string.Empty;
}
