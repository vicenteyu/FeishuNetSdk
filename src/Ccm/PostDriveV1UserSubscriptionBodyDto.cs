// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="PostDriveV1UserSubscriptionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>订阅用户云文档事件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 订阅用户云文档事件 请求体
/// <para>订阅用户云文档的各类通知事件，调用后目前可获取接收者视角的云文档评论、回复添加事件 ，未来 还会陆续扩充其它通知事件。</para>
/// <para>## 注意事项</para>
/// <para>仅用户身份订阅“用户云文档事件”时，需要调用该接口。应用身份无需调用。</para>
/// <para>接口ID：7623827135371201487</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/user/subscription</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fuser%2fsubscription</para>
/// </summary>
public record PostDriveV1UserSubscriptionBodyDto
{
    /// <summary>
    /// <para>事件类型</para>
    /// <para>路由到 云文档事件列表，当前仅支持一种事件</para>
    /// <para>可选值：</para>
    /// <para>drive.notice.comment_add_v1：添加评论、回复通知事件</para>
    /// <para>必填：是</para>
    /// <para>示例值：drive.notice.comment_add_v1</para>
    /// </summary>
    [JsonPropertyName("event_type")]
    public string EventType { get; set; } = string.Empty;
}
