// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="PostApprovalV4InstancesRemindBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>单据催办 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 单据催办 请求体
/// <para>当需要催促审批人审批单据时，通过该接口给审批人发送催办消息</para>
/// <para>接口ID：7642253323628415966</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/remind</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fremind</para>
/// </summary>
public record PostApprovalV4InstancesRemindBodyDto
{
    /// <summary>
    /// <para>审批实例 Code，可通过「获取单个审批实例详情接口」得到，与其他系列接口中instance_code是同一概念</para>
    /// <para>必填：是</para>
    /// <para>示例值：81D31358-93AF-92D6-7425-01A5D67C4E71</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>被催办的任务ID，通过「获取单个审批实例详情接口」得到</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("task_ids")]
    public string[] TaskIds { get; set; } = [];

    /// <summary>
    /// <para>评论，请控制在500个字符内</para>
    /// <para>必填：否</para>
    /// <para>示例值：同意</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}
