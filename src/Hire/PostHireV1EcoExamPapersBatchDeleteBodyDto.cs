// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1EcoExamPapersBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除试卷 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 删除试卷 请求体
/// <para>删除指定帐号的指定试卷列表，删除不影响已创建的笔试，删除不存在的试卷时不会报错</para>
/// <para>接口ID：7195815976042577922</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_exam_paper/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_exam_paper%2fbatch_delete</para>
/// </summary>
public record PostHireV1EcoExamPapersBatchDeleteBodyDto
{
    /// <summary>
    /// <para>背调账号 ID，可在「账号绑定」事件中获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：7147998241542539527</para>
    /// </summary>
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; } = string.Empty;

    /// <summary>
    /// <para>试卷 ID 列表</para>
    /// <para>必填：是</para>
    /// <para>示例值：["7147998241542539512"]</para>
    /// </summary>
    [JsonPropertyName("paper_id_list")]
    public string[] PaperIdList { get; set; } = Array.Empty<string>();
}
