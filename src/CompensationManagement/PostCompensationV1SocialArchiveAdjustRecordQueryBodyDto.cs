// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="PostCompensationV1SocialArchiveAdjustRecordQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通过员工ID批量获取社保增减员记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 通过员工ID批量获取社保增减员记录 请求体
/// <para>通过员工ID批量获取社保增减员记录</para>
/// <para>接口ID：7420038908975382530</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/social_archive/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fsocial_archive_adjust_record%2fquery</para>
/// </summary>
public record PostCompensationV1SocialArchiveAdjustRecordQueryBodyDto
{
    /// <summary>
    /// <para>用户ID列表，与入参 user_id_type 类型一致</para>
    /// <para>必填：是</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("user_id_list")]
    public string[] UserIdList { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>增减员类型, increase: 增员; attrition: 减员</para>
    /// <para>必填：是</para>
    /// <para>示例值：increase</para>
    /// <para>最大长度：32</para>
    /// <para>最小长度：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>increase：增员</item>
    /// <item>attrition：减员</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("record_type")]
    public string RecordType { get; set; } = string.Empty;
}
