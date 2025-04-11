// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostHireV1TalentPoolsByTalentPoolIdBatchChangeTalentPoolBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量加入/移除人才库中人才 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 批量加入/移除人才库中人才 请求体
/// <para>对于同一个人才库，可批量执行人才加入或移除操作</para>
/// <para>- 执行加入操作：当传入不存在人才 ID 时，接口会报错返回不存在人才 ID 列表。 当人才已在人才库中时，接口静默处理。</para>
/// <para>- 执行移除操作：当传入不存在人才 ID 时，接口会报错返回不存在人才 ID 列表。 当人才未在人才库中时，接口静默处理。</para>
/// <para>接口ID：7397677441913028636</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/talent_pool/batch_change_talent_pool</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent_pool%2fbatch_change_talent_pool</para>
/// </summary>
public record PostHireV1TalentPoolsByTalentPoolIdBatchChangeTalentPoolBodyDto
{
    /// <summary>
    /// <para>人才 ID 列表，可通过[获取人才列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent/list)接口获取</para>
    /// <para>必填：是</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("talent_id_list")]
    public string[] TalentIdList { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>操作类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：将人才添加至指定人才库</item>
    /// <item>2：将人才从指定人才库中移除</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("option_type")]
    public int OptionType { get; set; }
}
