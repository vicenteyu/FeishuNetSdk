// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-07-17
// ************************************************************************
// <copyright file="PostCorehrV2JobLevelsBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通过职级 ID 批量获取职级信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 根据条件批量获取职级信息 请求体
/// <para>该接口支持通过职级ID或职级Code批量查询职级详情信息，包括名称、描述、启用状态等。</para>
/// <para>接口ID：7252157701853200412</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job_level/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_level%2fbatch_get</para>
/// </summary>
public record PostCorehrV2JobLevelsBatchGetBodyDto
{
    /// <summary>
    /// <para>职级 ID 列表</para>
    /// <para>- 职级 ID 列表和职级 Code 列表至少有一项有值，否则接口将调用失败。</para>
    /// <para>- 未设置时表示不筛选该条件</para>
    /// <para>- ID获取方式：调用[【创建职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_level/events/created)[【批量查询职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/list)等接口可以返回职级ID</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("job_level_ids")]
    public string[]? JobLevelIds { get; set; }

    /// <summary>
    /// <para>职级 Code 列表</para>
    /// <para>- 职级 ID 列表和职级 Code 列表至少有一项有值，否则接口将调用失败。</para>
    /// <para>- 未设置时表示不筛选该条件</para>
    /// <para>- Code获取方式：调用[【创建职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_level/events/created)[【批量查询职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/list)等接口可以返回职级Code</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("job_level_codes")]
    public string[]? JobLevelCodes { get; set; }
}
