// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1ExamsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加笔试结果 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 添加笔试结果 响应体
/// <para>根据投递 ID 添加该投递下的笔试结果。</para>
/// <para>接口ID：7033979950131118084</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/exam/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexam%2fcreate</para>
/// </summary>
public record PostHireV1ExamsResponseDto
{
    /// <summary>
    /// <para>笔试 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7031822096580868396</para>
    /// </summary>
    [JsonPropertyName("exam_id")]
    public string? ExamId { get; set; }

    /// <summary>
    /// <para>投递 ID，如何获取投递信息请参考[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
    /// <para>必填：否</para>
    /// <para>示例值：7031822096580868396</para>
    /// </summary>
    [JsonPropertyName("application_id")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// <para>试卷名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：测试名字</para>
    /// </summary>
    [JsonPropertyName("exam_resource_name")]
    public string? ExamResourceName { get; set; }

    /// <summary>
    /// <para>笔试分数</para>
    /// <para>必填：否</para>
    /// <para>示例值：95.5</para>
    /// </summary>
    [JsonPropertyName("score")]
    public float? Score { get; set; }

    /// <summary>
    /// <para>附件 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6949805467799537964</para>
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>
    /// <para>操作人用户 open_id</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_xxx</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public string? OperatorId { get; set; }

    /// <summary>
    /// <para>操作时间戳（单位：毫秒）</para>
    /// <para>必填：否</para>
    /// <para>示例值：1637295516451</para>
    /// </summary>
    [JsonPropertyName("operate_time")]
    public string? OperateTime { get; set; }
}
