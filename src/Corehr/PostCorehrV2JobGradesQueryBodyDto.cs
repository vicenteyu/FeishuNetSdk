// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2JobGradesQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询职等 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询职等 请求体
/// <para>查询职等的详细信息。</para>
/// <para>接口ID：7366602835655720964</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_grade%2fquery</para>
/// </summary>
public record PostCorehrV2JobGradesQueryBodyDto
{
    /// <summary>
    /// <para>职等ID列表，不填写则返回全部列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("ids")]
    public string[]? Ids { get; set; }

    /// <summary>
    /// <para>职等code列表，不填写则返回全部列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("codes")]
    public string[]? Codes { get; set; }

    /// <summary>
    /// <para>是否启用，不填写则返回全部列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }
}
