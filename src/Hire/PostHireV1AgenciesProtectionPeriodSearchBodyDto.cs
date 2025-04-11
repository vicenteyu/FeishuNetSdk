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
/// <para>查询指定人才的猎头保护期信息列表，包含保护期起止时间、猎头供应商、猎头顾问信息等。若人才已经入职，还会返回入职时所在的保护期信息。</para>
/// <para>接口ID：7307160083569655811</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/agency/protect_search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2fprotect_search</para>
/// </summary>
public record PostHireV1AgenciesProtectionPeriodSearchBodyDto
{
    /// <summary>
    /// <para>人才 ID，可通过[通过手机号或邮箱获取人才 ID](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent/batch_get_id)、[获取人才列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent/list)接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonPropertyName("talent_id")]
    public string TalentId { get; set; } = string.Empty;
}
