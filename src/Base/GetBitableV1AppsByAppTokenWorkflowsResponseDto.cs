// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-12
//
// Last Modified By : yxr
// Last Modified On : 2024-12-12
// ************************************************************************
// <copyright file="GetBitableV1AppsByAppTokenWorkflowsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>列出自动化流程 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 列出自动化流程 响应体
/// <para>该接口用于列出多维表格的自动化流程。</para>
/// <para>接口ID：7447033368182571009</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/bitable-v1/app-workflow/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-workflow%2flist</para>
/// </summary>
public record GetBitableV1AppsByAppTokenWorkflowsResponseDto
{
    /// <summary>
    /// <para>自动化流程信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("workflows")]
    public AppWorkflow[] Workflows { get; set; } = [];

    /// <summary>
    /// <para>自动化流程信息</para>
    /// </summary>
    public record AppWorkflow
    {
        /// <summary>
        /// <para>自动化流程的 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：72934597xxxx9998484</para>
        /// </summary>
        [JsonPropertyName("workflow_id")]
        public string WorkflowId { get; set; } = string.Empty;

        /// <summary>
        /// <para>自动化流程的状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：Enable</para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>自动化流程的名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：流程 1</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }
    }
}
