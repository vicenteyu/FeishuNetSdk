// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-11
//
// Last Modified By : yxr
// Last Modified On : 2026-05-11
// ************************************************************************
// <copyright file="PostCorehrV2CostCentersQueryMultiTimelineBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询成本中心版本信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量查询成本中心版本信息 请求体
/// <para>根据成本中心 ID 列表，批量查询开始结束时间内的所有成本中心版本信息，含成本中心名称、编码、上级成本中心、负责人、版本生效日期、版本失效日期、是否启用、描述等信息。</para>
/// <para>接口ID：7637139455451122649</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/query_multi_timeline</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2fquery_multi_timeline</para>
/// </summary>
public record PostCorehrV2CostCentersQueryMultiTimelineBodyDto
{
    /// <summary>
    /// <para>成本中心 ID 列表，详细信息可通过[【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口查询获得</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("cost_center_ids")]
    public string[] CostCenterIds { get; set; } = [];

    /// <summary>
    /// <para>生效日期开始(包含)</para>
    /// <para>- 若不传入 effective_date_start 和 effective_date_end，默认返回当前生效版本。</para>
    /// <para>- 支持单独传入：仅传 effective_date_start 时，返回该日期及之后生效的版本。</para>
    /// <para>- 与 effective_date_end 同时传入时，返回两者交集范围内生效的版本</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-01-01</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：10</para>
    /// </summary>
    [JsonPropertyName("effective_date_start")]
    public string? EffectiveDateStart { get; set; }

    /// <summary>
    /// <para>生效日期结束(包含)</para>
    /// <para>- 若不传入 effective_date_start 和 effective_date_end，默认返回当前生效版本。</para>
    /// <para>- 支持单独传入：仅传 effective_date_end 时，返回该日期及之前生效的版本。</para>
    /// <para>- 与 effective_date_start 同时传入时，返回两者交集范围内生效的版本。</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-12-31</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：10</para>
    /// </summary>
    [JsonPropertyName("effective_date_end")]
    public string? EffectiveDateEnd { get; set; }

    /// <summary>
    /// <para>返回数据的字段列表，可选</para>
    /// <para>- name：成本中心名称</para>
    /// <para>- code：编码</para>
    /// <para>- active：当前实体是否启用</para>
    /// <para>- parent_cost_center_id： 上级成本中心ID</para>
    /// <para>- managers：成本中心负责人ID 列表</para>
    /// <para>- description：成本中心描述</para>
    /// <para>- effective_date：版本生效日期</para>
    /// <para>- expiration_date：版本失效日期</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("fields")]
    public string[]? Fields { get; set; }
}
