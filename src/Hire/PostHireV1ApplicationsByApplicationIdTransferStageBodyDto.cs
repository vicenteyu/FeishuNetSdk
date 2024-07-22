// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1ApplicationsByApplicationIdTransferStageBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>转移投递阶段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 转移投递阶段 请求体
/// <para>根据投递 ID 和投递阶段 ID 转移投递阶段。</para>
/// <para>接口ID：6989078472837136387</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/transfer_stage</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2ftransfer_stage</para>
/// </summary>
public record PostHireV1ApplicationsByApplicationIdTransferStageBodyDto
{
    /// <summary>
    /// <para>要转移到的阶段 ID，可通过[获取招聘流程信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_process/list)接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6960663240925956402</para>
    /// </summary>
    [JsonPropertyName("stage_id")]
    public string StageId { get; set; } = string.Empty;
}
