// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1ExternalReferralRewardsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>导入外部内推奖励 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 导入外部内推奖励 响应体
/// <para>支持将外部的内推奖励（积分/现金）导入到招聘的「内推账号」中</para>
/// <para>接口ID：7325271522314584065</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-referral-reward-info/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_referral_reward%2fcreate</para>
/// </summary>
public record PostHireV1ExternalReferralRewardsResponseDto
{
    /// <summary>
    /// <para>创建的内推奖励的id</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
