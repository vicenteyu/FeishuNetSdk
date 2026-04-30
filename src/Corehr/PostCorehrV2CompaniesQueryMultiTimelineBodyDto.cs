// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-01
//
// Last Modified By : yxr
// Last Modified On : 2026-05-01
// ************************************************************************
// <copyright file="PostCorehrV2CompaniesQueryMultiTimelineBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询指定时间范围公司版本 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询指定时间范围公司版本 请求体
/// <para>- 接口支持查询出对象生效时间段在指定的start_date和end_date之间的版本（即：会查询出生效时间段和查询时间段有交集的版本）</para>
/// <para>- 接口支持对象版本相关字段的查询和返回（默认返回id和version_id）</para>
/// <para>接口ID：7473071080241545220</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/company/query_multi_timeline</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcompany%2fquery_multi_timeline</para>
/// </summary>
public record PostCorehrV2CompaniesQueryMultiTimelineBodyDto
{
    /// <summary>
    /// <para>公司ID。ID获取方式：</para>
    /// <para>- 调用[【创建公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/create)[【批量查询公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/list)等接口可以返回公司ID</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("company_ids")]
    public string[] CompanyIds { get; set; } = [];

    /// <summary>
    /// <para>查询开始时间（包含）</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-01-01</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：10</para>
    /// </summary>
    [JsonPropertyName("start_date")]
    public string? StartDate { get; set; }

    /// <summary>
    /// <para>查询结束时间（不包含）</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-12-31</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：10</para>
    /// </summary>
    [JsonPropertyName("end_date")]
    public string? EndDate { get; set; }

    /// <summary>
    /// <para>返回数据的字段列表，可选</para>
    /// <para>- company_name：公司名称</para>
    /// <para>- code ：编码</para>
    /// <para>- active：是否启用</para>
    /// <para>- parent_company：上级公司</para>
    /// <para>- description：描述</para>
    /// <para>- effective_date ：当前版本生效日期</para>
    /// <para>- expiration_date ：当前版本失效日期</para>
    /// <para>- type：公司性质</para>
    /// <para>- industry_list：所在行业</para>
    /// <para>- legal_representative ：法定代表人</para>
    /// <para>- post_code：邮编</para>
    /// <para>- tax_payer_id ：纳税人识别号</para>
    /// <para>- confidential：是否保密</para>
    /// <para>- sub_type_list：公司主体类型</para>
    /// <para>- branch_company：是否为分公司</para>
    /// <para>- primary_manager：主要负责人</para>
    /// <para>- currency：默认币种</para>
    /// <para>- phone：电话</para>
    /// <para>- fax：传真</para>
    /// <para>- registered_office_address：完整注册地址</para>
    /// <para>- office_address：完整办公地址</para>
    /// <para>- registered_office_address_info：注册地址</para>
    /// <para>- office_address_info：办公地址</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("fields")]
    public string[]? Fields { get; set; }
}
