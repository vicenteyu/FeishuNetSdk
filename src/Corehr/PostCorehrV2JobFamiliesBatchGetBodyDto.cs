// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2JobFamiliesBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通过序列 ID 批量获取序列信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 通过序列 ID 批量获取序列信息 请求体
/// <para>通过序列 ID 批量查询序列的详情信息，包括序列名称、启用状态、上级序列等。</para>
/// <para>接口ID：7252157701853216796</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job_family/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_family%2fbatch_get</para>
/// </summary>
public record PostCorehrV2JobFamiliesBatchGetBodyDto
{
    /// <summary>
    /// <para>序列ID列表。ID获取方式：</para>
    /// <para>- 调用[【新建序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/create)[【查询租户的序列信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)等接口可以返回序列ID</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("job_family_ids")]
    public string[] JobFamilyIds { get; set; } = Array.Empty<string>();
}
