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
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 校验三方审批实例 响应体
/// <para>校验三方审批实例数据，用于判断服务端数据是否为最新的。用户提交实例最新更新时间，如果服务端不存在该实例，或者服务端实例更新时间不是最新的，则返回对应实例 id。</para>
/// <para>例如，用户可以每隔5分钟，将最近5分钟产生的实例使用该接口进行对比。</para>
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

    /// <summary></summary>
    public record ExteranlInstanceCheckResponse
    {
        /// <summary>
        /// <para>审批实例 id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("instance_id")]
        public string? InstanceId { get; set; }

        /// <summary>
        /// <para>任务最近更新时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>任务信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("tasks")]
        public ExternalInstanceTask[]? Tasks { get; set; }

        /// <summary></summary>
        public record ExternalInstanceTask
        {
            /// <summary>
            /// <para>任务 id</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("task_id")]
            public string? TaskId { get; set; }

            /// <summary>
            /// <para>任务最近更新时间</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("update_time")]
            public string? UpdateTime { get; set; }
        }
    }
}
