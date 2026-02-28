// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-01
//
// Last Modified By : yxr
// Last Modified On : 2026-03-01
// ************************************************************************
// <copyright file="GetBitableV1AppsByAppTokenBlockWorkflowsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>列出工作流 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 列出工作流 响应体
/// <para>此接口用于返回多维表格中所有工作流，多维表格管理员可通过此接口来管理表中的工作流</para>
/// <para>接口ID：7530602249640755201</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-block_workflow/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-block_workflow%2flist</para>
/// </summary>
public record GetBitableV1AppsByAppTokenBlockWorkflowsResponseDto
{
    /// <summary>
    /// <para>工作流列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("workflows")]
    public BlockWorkflow[]? Workflows { get; set; }

    /// <summary>
    /// <para>工作流列表</para>
    /// </summary>
    public record BlockWorkflow
    {
        /// <summary>
        /// <para>工作流唯一键</para>
        /// <para>必填：否</para>
        /// <para>示例值：12412312421312</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("workflow_id")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// <para>工作流标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：工作流</para>
        /// <para>最大长度：500</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>工作流状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：Enable</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>Enable：启用</item>
        /// <item>Disable：禁用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    }
}
