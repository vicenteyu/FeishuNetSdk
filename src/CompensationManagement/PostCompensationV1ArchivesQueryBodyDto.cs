// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-12-12
// ************************************************************************
// <copyright file="PostCompensationV1ArchivesQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询员工薪资档案 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 批量查询员工薪资档案 请求体
/// <para>批量查询员工薪资档案</para>
/// <para>接口ID：7314129756769746948</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/archive/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2farchive%2fquery</para>
/// </summary>
public record PostCompensationV1ArchivesQueryBodyDto
{
    /// <summary>
    /// <para>用户ID列表，获取方式可参考查询参数中的「user_id_type」字段</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("user_id_list")]
    public string[] UserIdList { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>档案Tid列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("tid_list")]
    public string[]? TidList { get; set; }

    /// <summary>
    /// <para>生效开始时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-05-10</para>
    /// </summary>
    [JsonPropertyName("effective_start_date")]
    public string? EffectiveStartDate { get; set; }

    /// <summary>
    /// <para>生效结束时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：2023-05-15</para>
    /// </summary>
    [JsonPropertyName("effective_end_date")]
    public string? EffectiveEndDate { get; set; }
}
