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
// <summary>删除试卷列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 删除试卷列表 请求体
/// <para>飞书招聘的笔试服务商，可通过该接口删除客户笔试帐号下的试卷列表。删除操作不影响已安排的笔试，删除不存在的试卷时不会报错。</para>
/// <para>接口ID：7195815976042577922</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_exam_paper/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_exam_paper%2fbatch_delete</para>
/// </summary>
public record PostHireV1EcoExamPapersBatchDeleteBodyDto
{
    /// <summary>
    /// <para>笔试账号 ID，可通过[账号绑定](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_account/events/created)事件获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：7147998241542539527</para>
    /// </summary>
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; } = string.Empty;

    /// <summary>
    /// <para>试卷 ID 列表。通过[创建试卷列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_exam_paper/create)传入的 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：["7147998241542539512"]</para>
    /// </summary>
    [JsonPropertyName("paper_id_list")]
    public string[] PaperIdList { get; set; } = Array.Empty<string>();
}
