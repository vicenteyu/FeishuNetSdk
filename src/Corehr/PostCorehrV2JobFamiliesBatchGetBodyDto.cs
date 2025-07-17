// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-07-17
// ************************************************************************
// <copyright file="PostCorehrV2JobFamiliesBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通过序列 ID 批量获取序列信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 根据条件批量获取序列信息 请求体
/// <para>通过序列 ID 或序列 Code 批量查询当前生效版本序列的详情信息，包括序列名称、启用状态、上级序列等。</para>
/// <para>接口ID：7252157701853216796</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job_family/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_family%2fbatch_get</para>
/// </summary>
public record PostCorehrV2JobFamiliesBatchGetBodyDto
{
    /// <summary>
    /// <para>序列ID列表。</para>
    /// <para>- 序列 ID 列表和序列 Code 列表至少有一项有值，否则接口将调用失败。</para>
    /// <para>- 未设置时表示不筛选该条件</para>
    /// <para>- ID获取方式：调用[【创建序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/create)[【批量查询序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)等接口可以返回序列ID</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("job_family_ids")]
    public string[]? JobFamilyIds { get; set; }

    /// <summary>
    /// <para>序列 Code 列表。</para>
    /// <para>- 序列 ID 列表和序列 Code 列表至少有一项有值，否则接口将调用失败。</para>
    /// <para>- 未设置时表示不筛选该条件</para>
    /// <para>- Code获取方式：调用[【创建序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/create)[【批量查询序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)等接口可以返回序列Code</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("job_family_codes")]
    public string[]? JobFamilyCodes { get; set; }
}
