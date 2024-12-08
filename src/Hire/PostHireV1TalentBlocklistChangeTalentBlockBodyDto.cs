// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostHireV1TalentBlocklistChangeTalentBlockBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>加入/移除屏蔽名单 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 加入/移除屏蔽名单 请求体
/// <para>根据人才 ID 将人才加入或移除屏蔽名单。</para>
/// <para>接口ID：7413697955198091268</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_blocklist/change_talent_block</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent_blocklist%2fchange_talent_block</para>
/// </summary>
public record PostHireV1TalentBlocklistChangeTalentBlockBodyDto
{
    /// <summary>
    /// <para>人才 ID，可通过[获取人才列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent/list)接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6930815272790114325</para>
    /// </summary>
    [JsonPropertyName("talent_id")]
    public string TalentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>操作类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：加入屏蔽名单</item>
    /// <item>2：从屏蔽名单中移除</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("option")]
    public int Option { get; set; }

    /// <summary>
    /// <para>屏蔽原因，当`option`为`1`时必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：人才作弊</para>
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}
