// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-18
//
// Last Modified By : yxr
// Last Modified On : 2024-07-18
// ************************************************************************
// <copyright file="PostCorehrV2PreHiresQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询待入职信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询待入职信息 请求体
/// <para>该接口用于根据待入职人员 ID(支持批量)查询待入职人员信息，信息包含姓名、手机号等个人信息和任职信息。</para>
/// <para>- 延迟说明：数据库主从延迟 2s 以内，即：直接创建待入职后2s内调用此接口可能查询不到数据。</para>
/// <para>- 性能说明：本接口返回数据量较多，查询时请控制每批次数量（&lt;10）和适当减少查询字段数(&lt;50)</para>
/// <para>接口ID：7386487948991299587</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/pre_hire/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fquery</para>
/// </summary>
public record PostCorehrV2PreHiresQueryBodyDto
{
    /// <summary>
    /// <para>待入职人员 ID 列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("pre_hire_ids")]
    public string[]? PreHireIds { get; set; }

    /// <summary>
    /// <para>返回数据的字段列表，填写方式：</para>
    /// <para>- 为空时只返回 pre_hire_id</para>
    /// <para>- 不为空时按照传入的字段返回数据，数据结构可以参考response的数据结构，格式示例如下：</para>
    /// <para>- person_info（个人信息） 字段：person_info.gender，person_info.age</para>
    /// <para>- employment_info（雇佣信息） 字段：employment_info.department</para>
    /// <para>- onboarding_info（入职信息） 字段：onboarding_info.onboarding_date</para>
    /// <para>- probation_info（试用期信息） 字段：probation_info.probation_period</para>
    /// <para>- contract_info（合同信息） 字段：contract_info.contract_type</para>
    /// <para>- 如果要返回所有下级，只用传上级结构体名称，例如 person_info</para>
    /// <para>- 返回数据越多，查询接口性能越慢，请按需填写返回字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：\["person_info","employment_info.department","probation_info.probation_period"\]</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("fields")]
    public string[]? Fields { get; set; }
}
