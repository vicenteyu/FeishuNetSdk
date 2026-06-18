// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="PostApprovalV4InstancesRecallBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤回审批实例（用户级） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 撤回审批实例（用户级） 请求体
/// <para>在符合撤销规则的情况下，你可以调用本接口将**当前用户身份提交的**的审批实例撤回。</para>
/// <para>## 注意事项</para>
/// <para>- 如果撤回的是审批中的实例，则撤回后审批流程结束。</para>
/// <para>- 如果撤回的是已通过的实例，则审批实例会变更为 **审批中** 的状态。</para>
/// <para>- 撤销规则：企业管理员在审批后台的某一审批定义的 **更多设置** 中，勾选了 **允许撤销审批中的申请** 或者 **允许撤销 x 天内通过的审批**</para>
/// <para>接口ID：7642253323628399582</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/recall</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2frecall</para>
/// </summary>
public record PostApprovalV4InstancesRecallBodyDto
{
    /// <summary>
    /// <para>审批实例 Code，可通过查询任务列表接口获取到</para>
    /// <para>必填：是</para>
    /// <para>示例值：81D31358-93AF-92D6-7425-01A5D67C4E71</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;
}
