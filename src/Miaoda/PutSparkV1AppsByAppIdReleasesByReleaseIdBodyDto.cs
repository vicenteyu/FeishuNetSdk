// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-10-17
//
// Last Modified By : yxr
// Last Modified On : 2026-10-17
// ************************************************************************
// <copyright file="PutSparkV1AppsByAppIdReleasesByReleaseIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>回写发布节点状态 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 回写发布节点状态 请求体
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
public record PutSparkV1AppsByAppIdReleasesByReleaseIdBodyDto
{
    /// <summary>
    /// <para>目标节点任务 ID，取自 webhook 请求 payload 中的 `data.node_task_id`（即请求头 `X-Aily-Event-Id` 的值）。用于精确定位本次发布中待裁决的节点实例，重试或重跑场景下不会误操作其他实例。</para>
    /// <para>必填：是</para>
    /// <para>示例值：evt_7683140375070395931</para>
    /// </summary>
    [JsonPropertyName("node_task_id")]
    public string NodeTaskId { get; set; } = string.Empty;

    /// <summary>
    /// <para>裁决动作。不传则不改变节点状态，仅回写 `result`；传入其他值会返回参数错误。</para>
    /// <para>**可选值有**：</para>
    /// <para>- `approve`：通过，放行该节点，流水线继续执行</para>
    /// <para>- `reject`：拒绝，终止本次发布</para>
    /// <para>- `cancel`：撤回，主动终止本次发布</para>
    /// <para>必填：否</para>
    /// <para>示例值：approve</para>
    /// </summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>
    /// <para>回写结果，可与 `action` 同时传入，也可单独传入。多次调用以最后一次为准，覆盖已有值。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("result")]
    public OpenApiReleaseNodeResult? Result { get; set; }

    /// <summary>
    /// <para>回写结果，可与 `action` 同时传入，也可单独传入。多次调用以最后一次为准，覆盖已有值。</para>
    /// </summary>
    public record OpenApiReleaseNodeResult
    {
        /// <summary>
        /// <para>外部审核系统中的审核单详情页链接，妙搭会在发布详情页展示给开发者查看审核进度。必须是合法的 HTTP/HTTPS URL，最大长度 2048 字符。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://audit.example.com/tickets/10086</para>
        /// </summary>
        [JsonPropertyName("approval_url")]
        public string? ApprovalUrl { get; set; }

        /// <summary>
        /// <para>做出本次裁决的操作人标识（open_id、工号、邮箱均可），妙搭原样留痕，不做解析。最大长度 128 字符。不传时记录为调用应用。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
        /// </summary>
        [JsonPropertyName("operator")]
        public string? Operator { get; set; }

        /// <summary>
        /// <para>审批意见、拒绝原因或审核中说明，妙搭原样留痕并在发布详情页展示。最大长度 1024 字符。</para>
        /// <para>必填：否</para>
        /// <para>示例值：安全扫描通过，同意发布</para>
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }
}
