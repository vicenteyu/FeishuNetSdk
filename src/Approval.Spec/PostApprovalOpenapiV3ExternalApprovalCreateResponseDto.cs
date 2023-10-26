using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 三方审批定义创建 响应体
/// <para>为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/external_approval/create)审批定义是审批的描述，包括审批名称、图标、描述等基础信息。创建好审批定义，用户就可以在审批应用的发起页中看到审批，如果用户点击发起，则会跳转到配置的发起三方系统地址去发起审批。</para>
/// <para>另外，审批定义还配置了审批操作时的回调地址：审批人在待审批列表中进行【同意】【拒绝】操作时，审批中心会调用回调地址通知三方系统。</para>
/// <para>注意，审批中心不负责审批流程的流转，只负责展示、操作、消息通知。因此审批定义创建时没有审批流程的信息。</para>
/// <para>接口ID：6907569744329883649</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/third-party-approval-integration/external-approval-create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDNyYjLyQjM24iM0IjN</para>
/// </summary>
public record PostApprovalOpenapiV3ExternalApprovalCreateResponseDto
{
    /// <summary>
    /// <para>审批定义 Code，用于发起实例</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("approval_code")]
    public string? ApprovalCode { get; set; }
}
