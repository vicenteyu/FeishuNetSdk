// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalOpenapiV3ExternalInstanceCheckResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>三方审批实例校验 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 三方审批实例校验 响应体
/// <para>为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/external_instance/check)校验三方审批实例数据，用于判断服务端数据是否为最新的。用户提交实例最新更新时间，如果服务端不存在该实例，或者服务端实例更新时间不是最新的，则返回对应实例 id。</para>
/// <para>例如，用户可以每隔5分钟，将最近5分钟产生的实例使用该接口进行对比。</para>
/// <para>接口ID：6907569745298604034</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/third-party-approval-integration/external-approval-instance-check</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDNyYjL1QjM24SN0IjN</para>
/// </summary>
public record PostApprovalOpenapiV3ExternalInstanceCheckResponseDto
{
    /// <summary>
    /// <para>实例信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("diff_times")]
    public DiffTime[]? DiffTimes { get; set; }

    /// <summary></summary>
    public record DiffTime
    {
        /// <summary>
        /// <para>审批实例 id</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("instance_id")]
        public string InstanceId { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批实例最近更新时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// <para>任务信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("tasks")]
        public Task[]? Tasks { get; set; }

        /// <summary></summary>
        public record Task
        {
            /// <summary>
            /// <para>任务 id</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("task_id")]
            public string TaskId { get; set; } = string.Empty;

            /// <summary>
            /// <para>任务最近更新时间</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("update_time")]
            public long? UpdateTime { get; set; }
        }
    }
}
