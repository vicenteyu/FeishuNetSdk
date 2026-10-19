// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-10-17
//
// Last Modified By : yxr
// Last Modified On : 2026-10-17
// ************************************************************************
// <copyright file="PutSparkV1AppsByAppIdReleasesByReleaseIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>回写发布节点状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 回写发布节点状态 响应体
/// <para>外部审核系统收到妙搭发布流水线的 webhook 通知后，调用本接口对处于等待态（`PENDING`）的发布节点做出裁决（通过 / 拒绝 / 撤回），或仅回填审核单链接、操作人与审批意见，供开发者在妙搭发布详情页查看审核进度。</para>
/// <para>一次调用只操作一个节点，节点允许的状态流转如下：</para>
/// <para>| 当前状态 | 动作 | 流转后状态 | 说明 |</para>
/// <para>| --- | --- | --- | --- |</para>
/// <para>| PENDING | approve | APPROVED | 审核通过，流水线继续执行 |</para>
/// <para>| PENDING | reject | REJECTED | 审核拒绝，本次发布终止 |</para>
/// <para>| PENDING | cancel | CANCELED | 外部撤回，本次发布终止（等价于开发者在妙搭内手动撤回） |</para>
/// <para>| PENDING | 不传 | PENDING | 不改变节点状态，仅回写 result（例如先回填审核单链接） |</para>
/// <para>接口ID：7692846107466222565</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-release/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-release%2fupdate</para>
/// </summary>
public record PutSparkV1AppsByAppIdReleasesByReleaseIdResponseDto
{
    /// <summary>
    /// <para>妙搭应用 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：app_4ka4egt4j2y6p</para>
    /// </summary>
    [JsonPropertyName("app_id")]
    public string AppId { get; set; } = string.Empty;

    /// <summary>
    /// <para>发布记录 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：7683140375070166555</para>
    /// </summary>
    [JsonPropertyName("release_id")]
    public string ReleaseId { get; set; } = string.Empty;

    /// <summary>
    /// <para>被操作的节点任务 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：evt_7683140375070395931</para>
    /// </summary>
    [JsonPropertyName("node_task_id")]
    public string NodeTaskId { get; set; } = string.Empty;

    /// <summary>
    /// <para>被操作节点的节点名，可能为空。</para>
    /// <para>**可选值有**：</para>
    /// <para>- `build`：编译构建</para>
    /// <para>- `deploy`：产物部署</para>
    /// <para>必填：是</para>
    /// <para>示例值：build</para>
    /// </summary>
    [JsonPropertyName("node")]
    public string Node { get; set; } = string.Empty;

    /// <summary>
    /// <para>节点当前状态，仅反映本节点，不代表整条流水线的最终状态。</para>
    /// <para>**可选值有**：</para>
    /// <para>- `PENDING`：等待裁决（仅回写 result、未裁决时返回）</para>
    /// <para>- `APPROVED`：已通过</para>
    /// <para>- `REJECTED`：已拒绝</para>
    /// <para>- `CANCELED`：已撤回</para>
    /// <para>必填：是</para>
    /// <para>示例值：APPROVED</para>
    /// </summary>
    [JsonPropertyName("node_status")]
    public string NodeStatus { get; set; } = string.Empty;

    /// <summary>
    /// <para>节点已保存的回写结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("result")]
    public OpenApiReleaseNodeResult? Result { get; set; }

    /// <summary>
    /// <para>节点已保存的回写结果</para>
    /// </summary>
    public record OpenApiReleaseNodeResult
    {
        /// <summary>
        /// <para>审核单详情页链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://audit.example.com/tickets/10086</para>
        /// </summary>
        [JsonPropertyName("approval_url")]
        public string? ApprovalUrl { get; set; }

        /// <summary>
        /// <para>操作人标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
        /// </summary>
        [JsonPropertyName("operator")]
        public string? Operator { get; set; }

        /// <summary>
        /// <para>审批意见、拒绝原因或审核中说明</para>
        /// <para>必填：否</para>
        /// <para>示例值：安全扫描通过，同意发布</para>
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }
}
