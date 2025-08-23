// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="PostCompensationV1SocialArchiveQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取员工参保档案 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 批量获取员工参保档案 请求体
/// <para>通过用户ID列表和生效日期查询</para>
/// <para>接口ID：7420038908975398914</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/social_archive/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fsocial_archive%2fquery</para>
/// </summary>
public record PostCompensationV1SocialArchiveQueryBodyDto
{
    /// <summary>
    /// <para>用户ID列表，与入参 user_id_type 类型一致，最少1个，最大200</para>
    /// <para>必填：是</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("user_id_list")]
    public string[] UserIdList { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>生效日期，查询在该日期生效的社保档案，格式为 YYYY-mm-dd，长度为 10 字符</para>
    /// <para>必填：是</para>
    /// <para>示例值：2024-01-01</para>
    /// </summary>
    [JsonPropertyName("effective_date")]
    public string EffectiveDate { get; set; } = string.Empty;
}
