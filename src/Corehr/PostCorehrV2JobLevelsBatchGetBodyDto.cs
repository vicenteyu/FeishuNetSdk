// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2JobLevelsBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通过职级 ID 批量获取职级信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 通过职级 ID 批量获取职级信息 请求体
/// <para>该接口支持通过职级id批量查询职级详情信息，包括职级包含的名称、描述、启用状态等。</para>
/// <para>- 延迟说明：数据库主从延迟 2s 以内，即：直接创建职级后2s内调用此接口可能查询不到数据。</para>
/// <para>接口ID：7252157701853200412</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_level/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_level%2fbatch_get</para>
/// </summary>
public record PostCorehrV2JobLevelsBatchGetBodyDto
{
    /// <summary>
    /// <para>职级 ID 列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("job_level_ids")]
    public string[] JobLevelIds { get; set; } = Array.Empty<string>();
}
