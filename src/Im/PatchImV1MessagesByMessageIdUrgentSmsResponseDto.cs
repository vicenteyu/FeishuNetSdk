// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchImV1MessagesByMessageIdUrgentSmsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发送短信加急 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 发送短信加急 响应体
/// <para>调用该接口把指定消息加急给目标用户，加急将通过飞书客户端和短信进行通知。了解加急可参见[加急功能](https://www.feishu.cn/hc/zh-CN/articles/360024757913)。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability) 。</para>
/// <para>- 确保机器人在被加急消息所属会话中。如果是群组，还需要确保群管理中设置了 **所有群成员可以加急**，或者设置了 **仅群主或管理员可以加急** 且机器人是管理员。</para>
/// <para>## 使用限制</para>
/// <para>- 只能加急当前机器人自己发送的消息。</para>
/// <para>- 加急用户的未读加急总数不能超过 200 条。</para>
/// <para>- 不支持加急[批量发送的消息](https://open.feishu.cn/document/ukTMukTMukTM/ucDO1EjL3gTNx4yN4UTM)。</para>
/// <para>- 加急[折叠会话](https://www.feishu.cn/hc/zh-CN/articles/360025267393)内的消息时，仅会在应用内推送提醒通知。</para>
/// <para>接口ID：6948245234036637724</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/buzz-messages/urgent_sms</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2furgent_sms</para>
/// </summary>
public record PatchImV1MessagesByMessageIdUrgentSmsResponseDto
{
    /// <summary>
    /// <para>无效的用户 ID。当传入的用户 ID 列表内存在部分用户 ID 有效时，将对有效的用户进行加急操作，同时返回无效的用户 ID。当所有的用户 ID 无效时，将返回 `230001` 错误码。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("invalid_user_id_list")]
    public string[] InvalidUserIdList { get; set; } = [];
}
