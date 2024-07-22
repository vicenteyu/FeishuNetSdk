// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1ExamsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加笔试结果 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 添加笔试结果 请求体
/// <para>根据投递 ID 添加该投递下的笔试结果。</para>
/// <para>接口ID：7033979950131118084</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/exam/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexam%2fcreate</para>
/// </summary>
public record PostHireV1ExamsBodyDto
{
    /// <summary>
    /// <para>投递 ID，可通过[获取投递列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/list)获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6891565253964859661</para>
    /// </summary>
    [JsonPropertyName("application_id")]
    public string ApplicationId { get; set; } = string.Empty;

    /// <summary>
    /// <para>试卷名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：笔试试卷</para>
    /// </summary>
    [JsonPropertyName("exam_resource_name")]
    public string ExamResourceName { get; set; } = string.Empty;

    /// <summary>
    /// <para>笔试分数（精度为小数点后 1 位）</para>
    /// <para>必填：是</para>
    /// <para>示例值：100.0</para>
    /// </summary>
    [JsonPropertyName("score")]
    public float Score { get; set; }

    /// <summary>
    /// <para>报告附件 ID，可通过[创建附件](https://open.feishu.cn/document/ukTMukTMukTM/uIDN1YjLyQTN24iM0UjN/create_attachment)上传报告附件，生成对应附件 ID。</para>
    /// <para>必填：否</para>
    /// <para>示例值：6949805467799537964</para>
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>
    /// <para>添加人用户 id，与入参`user_id_type` 保持一致</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_f476cb099ac9227c9bae09ce46112579</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public string OperatorId { get; set; } = string.Empty;
}
