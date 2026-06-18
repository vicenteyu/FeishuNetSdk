// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="PostApprovalV4InstancesAddCcBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>抄送审批实例（用户级） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 抄送审批实例（用户级） 请求体
/// <para>调用该接口将当前审批实例抄送给指定用户。被抄送的用户可以查看审批实例详情。例如，在飞书客户端的 **工作台 &gt; 审批 &gt; 审批中心 &gt; 抄送我** 列表中查看到审批实例。</para>
/// <para>接口ID：7642253323628350430</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/add_cc</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fadd_cc</para>
/// </summary>
public record PostApprovalV4InstancesAddCcBodyDto
{
    /// <summary>
    /// <para>审批实例 Code，可通过任务列表接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：81D31358-93AF-92D6-7425-01A5D67C4E71</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>抄送人的用户 ID 列表，cc_user_ids 的 ID 类型需与 user_id_type 的取值保持一致</para>
    /// <para>必填：是</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("cc_user_ids")]
    public string[] CcUserIds { get; set; } = [];

    /// <summary>
    /// <para>抄送留言，不要超过500字</para>
    /// <para>必填：否</para>
    /// <para>示例值：同意</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}
