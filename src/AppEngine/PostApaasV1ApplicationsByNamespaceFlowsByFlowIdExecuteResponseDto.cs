// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-29
//
// Last Modified By : yxr
// Last Modified On : 2024-11-29
// ************************************************************************
// <copyright file="PostApaasV1ApplicationsByNamespaceFlowsByFlowIdExecuteResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发起流程 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 发起流程 响应体
/// <para>执行相应流程</para>
/// <para>接口ID：7442599557486624772</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/application-flow/execute</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-flow%2fexecute</para>
/// </summary>
public record PostApaasV1ApplicationsByNamespaceFlowsByFlowIdExecuteResponseDto
{
    /// <summary>
    /// <para>状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：123</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// <para>输出参数</para>
    /// <para>必填：否</para>
    /// <para>示例值：123</para>
    /// </summary>
    [JsonPropertyName("out_params")]
    public string? OutParams { get; set; }

    /// <summary>
    /// <para>执行id</para>
    /// <para>必填：否</para>
    /// <para>示例值：123</para>
    /// </summary>
    [JsonPropertyName("execution_id")]
    public string? ExecutionId { get; set; }

    /// <summary>
    /// <para>错误信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：123</para>
    /// </summary>
    [JsonPropertyName("error_msg")]
    public string? ErrorMsg { get; set; }

    /// <summary>
    /// <para>code</para>
    /// <para>必填：否</para>
    /// <para>示例值：123</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}
