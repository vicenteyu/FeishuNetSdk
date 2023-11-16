namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 提交审核 响应体
/// <para>正常情况下调用创建推送接口后，就可以调用提交审核接口，如果创建人是服务台owner则会自动审核通过，否则会通知服务台owner审核此推送信息。</para>
/// <para>接口ID：6999529163292508162</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/notification/submit_approve</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fnotification%2fsubmit_approve</para>
/// </summary>
public record PostHelpdeskV1NotificationsByNotificationIdSubmitApproveResponseDto
{
    /// <summary>
    /// <para>是否有权限创建或者管理审批流程 （有两种情况会导致没有权限： 1：用户没有安装服务台小程序，需要在https://app.feishu.cn/app/cli_9f9f8825d53b900d 安装小程序 2：用户安装的服务台小程序版本过低）</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_access")]
    public bool? HasAccess { get; set; }
}
