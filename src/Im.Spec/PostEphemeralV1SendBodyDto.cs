// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostEphemeralV1SendBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发送仅特定人可见的消息卡片 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Spec;
/// <summary>
/// 发送仅特定人可见的消息卡片 请求体
/// <para>调用该接口，可以使应用机器人在指定群聊中发送仅指定用户可见的卡片消息。卡片上将展示 **仅对你可见** 标识，如下图所示。</para>
/// <para>![image.png](//sf3-cn.feishucdn.com/obj/open-platform-opendoc/b0ec0ce45942463381457edc7b62e144_RXYCFtfUtb.png?height=486&amp;lazyload=true&amp;maxWidth=592&amp;width=1592)</para>
/// <para>接口ID：6907569523177078785</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-card/send-message-cards-that-are-only-visible-to-certain-people</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuETOyYjLxkjM24SM5IjN</para>
/// </summary>
public record PostEphemeralV1SendBodyDto
{
    /// <summary>
    /// <para>目标群 ID。群 ID 获取方式参见[群 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)。</para>
    /// <para>示例值：oc_5ad573a6411d72b8305fda3a9c1abcef</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; } = string.Empty;

    /// <summary>
    /// <para>可见卡片的用户 open_id。ID 获取方式参考[如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
    /// <para>**注意**：你仅需填写 `open_id`、`email`、或 `user_id` 其中之一，且三个字段不可同时为空。若填写多个，字段生效的顺序为 `open_id` &gt; `user_id` &gt; `email`。 推荐使用 `open_id` 字段。</para>
    /// <para>示例值：ou_449b53ad6aee526f7ed311b216aabcef</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("open_id")]
    public string? OpenId { get; set; }

    /// <summary>
    /// <para>可见卡片的用户 user_id。ID 获取方式参考[如何获取 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)。</para>
    /// <para>**注意**：你仅需填写 `open_id`、`email`、或 `user_id` 其中之一，且三个字段不可同时为空。若填写多个，字段生效的顺序为 `open_id` &gt; `user_id` &gt; `email`。 推荐使用 `open_id` 字段。</para>
    /// <para>**示例值**：gg895344</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>可见卡片的用户邮箱地址。</para>
    /// <para>**注意**：你仅需填写 `open_id`、`email`、或 `user_id` 其中之一，且三个字段不可同时为空。若填写多个，字段生效的顺序为 `open_id` &gt; `user_id` &gt; `email`。 推荐使用 `open_id` 字段。</para>
    /// <para>**示例值**：zhangmin@feishu.com</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// <para>消息的类型，固定取值 `interactive`。</para>
    /// <para>**示例值**：interactive</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("msg_type")]
    public string MsgType { get; set; } = "interactive";

    /// <summary>
    /// <para>消息卡片的内容。支持卡片 JSON 或[搭建工具](https://open.feishu.cn/cardkit?from=open_docs)构建的卡片。</para>
    /// <para>- 要使用卡片 JSON，参考[卡片 JSON 结构](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-json-structure)。示例值可参考下文的请求体示例。</para>
    /// <para>- 要使用[搭建工具](https://open.feishu.cn/cardkit?from=open_docs)构建的卡片模板，你需传入 `type` 和 `data` 参数。参考 [发送卡片](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/send-feishu-card#461aa643-1)文档末尾的字段说明传值。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("card")]
    public object Card { get; set; } = new();
}
