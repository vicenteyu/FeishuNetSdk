// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2EmployeesBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询员工信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量查询员工信息 请求体
/// <para>通过员工 ID 、个人信息 ID、工作邮箱等筛选项批量查询员工的工作信息、个人信息。</para>
/// <para>接口ID：7252969409509490692</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee%2fbatch_get</para>
/// </summary>
public record PostCorehrV2EmployeesBatchGetBodyDto
{
    /// <summary>
    /// <para>需要查询的字段列表</para>
    /// <para>- 参考[【字段下钻】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/query-employment-fields)</para>
    /// <para>- 为空时仅返回 employment_id</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("fields")]
    public string[]? Fields { get; set; }

    /// <summary>
    /// <para>雇佣 ID 列表</para>
    /// <para>- 以下请求参数中「employment_ids」，「person_ids」，「work_emails」不得均为空</para>
    /// <para>- 请根据需求选择一种模式进行查询，若单次请求中多个请求参数有值，按照【employment_ids &gt; person_ids &gt; work_emails】的顺序只识别第一个有值的请求参数</para>
    /// <para>- ID 类型需要与 user_id_type 保持一致。</para>
    /// <para>- 在[【创建雇佣】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employment/create)时返回的 ID。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("employment_ids")]
    public string[]? EmploymentIds { get; set; }

    /// <summary>
    /// <para>个人信息 ID 列表，employment_ids参数有值时该参数不生效。</para>
    /// <para>- 在[【创建个人信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/person/create)时返回的 ID。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("person_ids")]
    public string[]? PersonIds { get; set; }

    /// <summary>
    /// <para>主工作邮箱列表，「employment_ids」，「person_ids」参数有值时该参数不生效。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("work_emails")]
    public string[]? WorkEmails { get; set; }
}
