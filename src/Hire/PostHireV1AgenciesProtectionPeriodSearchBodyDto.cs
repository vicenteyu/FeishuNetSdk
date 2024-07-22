// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1AgenciesProtectionPeriodSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询猎头保护期信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 查询猎头保护期信息 请求体
/// <para>查询猎头保护期信息</para>
/// <para>接口ID：7307160083569655811</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/agency/protect_search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2fprotect_search</para>
/// </summary>
public record PostHireV1AgenciesProtectionPeriodSearchBodyDto
{
    /// <summary>
    /// <para>人才id 可通过[「通过手机号或邮箱获取人才ID」](https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/batch_get_id)获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonPropertyName("talent_id")]
    public string TalentId { get; set; } = string.Empty;
}
