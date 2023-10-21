using Newtonsoft.Json;
namespace FeishuNetSdk.Approval;
/// <summary>
/// 创建三方审批定义 响应体
/// <para>审批定义是审批的描述，包括审批名称、图标、描述等基础信息。创建好审批定义，用户就可以在审批应用的发起页中看到审批，如果用户点击发起，则会跳转到配置的发起三方系统地址去发起审批。</para>
/// <para>另外，审批定义还配置了审批操作时的回调地址：审批人在待审批列表中进行【同意】【拒绝】操作时，审批中心会调用回调地址通知三方系统。</para>
/// <para>接口ID：7114621541589794819</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/external_approval/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fexternal_approval%2fcreate</para>
/// </summary>
public record PostApprovalV4ExternalApprovalsResponseDto
{
    /// <summary>
    /// <para>审批定义code，审批生成的唯一标识，用于三方审批实例同步时使用</para>
    /// <para>必填：是</para>
    /// <para>示例值：C30381C8-7A5F-4717-A9CF-C233BF0202D4</para>
    /// </summary>
    [JsonProperty("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;
}
