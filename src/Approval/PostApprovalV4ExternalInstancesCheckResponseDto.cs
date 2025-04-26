// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalV4ExternalInstancesCheckResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>校验三方审批实例 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 校验三方审批实例 响应体
/// <para>调用该接口校验三方审批实例数据，用于判断服务端数据是否为最新的。请求时提交实例最新更新时间，如果服务端不存在该实例，或者服务端实例更新时间不是最新的，则返回对应实例 ID。</para>
/// <para>例如，设置定时任务每隔 5 分钟，将最近 5 分钟产生的实例使用该接口进行对比。如果数据在服务端不存在或者不是最新，则可以根据本接口返回的实例 ID、任务 ID，前往[同步三方审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/external_instance/create)。</para>
/// <para>接口ID：7114621541589909507</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/external_instance/check</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fexternal_instance%2fcheck</para>
/// </summary>
public record PostApprovalV4ExternalInstancesCheckResponseDto
{
    /// <summary>
    /// <para>更新时间不一致的实例信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("diff_instances")]
    public ExteranlInstanceCheckResponse[]? DiffInstances { get; set; }

    /// <summary>
    /// <para>更新时间不一致的实例信息</para>
    /// </summary>
    public record ExteranlInstanceCheckResponse
    {
        /// <summary>
        /// <para>审批实例 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：1234234234242423</para>
        /// </summary>
        [JsonPropertyName("instance_id")]
        public string InstanceId { get; set; } = string.Empty;

        /// <summary>
        /// <para>任务最近更新时间，Unix 毫秒时间戳。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1591603040000</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>任务信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("tasks")]
        public ExternalInstanceTask[]? Tasks { get; set; }

        /// <summary>
        /// <para>任务信息</para>
        /// </summary>
        public record ExternalInstanceTask
        {
            /// <summary>
            /// <para>任务 ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：112253</para>
            /// </summary>
            [JsonPropertyName("task_id")]
            public string TaskId { get; set; } = string.Empty;

            /// <summary>
            /// <para>任务最近更新时间，Unix 毫秒时间戳。</para>
            /// <para>必填：是</para>
            /// <para>示例值：1591603040000</para>
            /// </summary>
            [JsonPropertyName("update_time")]
            public string UpdateTime { get; set; } = string.Empty;
        }
    }
}
