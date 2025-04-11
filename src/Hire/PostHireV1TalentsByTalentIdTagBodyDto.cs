// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-18
//
// Last Modified By : yxr
// Last Modified On : 2024-10-18
// ************************************************************************
// <copyright file="PostHireV1TalentsByTalentIdTagBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>操作人才标签 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 操作人才标签 请求体
/// <para>可为人才新增、删除标签。</para>
/// <para>接口ID：7404770953199730690</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/talent/tag</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2ftag</para>
/// </summary>
public record PostHireV1TalentsByTalentIdTagBodyDto
{
    /// <summary>
    /// <para>操作类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：新增</item>
    /// <item>2：删除</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("operation")]
    public int Operation { get; set; }

    /// <summary>
    /// <para>标签 ID 列表，可通过以下接口获取[获取人才标签信息列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_tag/list)</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("tag_id_list")]
    public string[] TagIdList { get; set; } = Array.Empty<string>();
}
