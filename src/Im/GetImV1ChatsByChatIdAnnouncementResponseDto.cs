// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetImV1ChatsByChatIdAnnouncementResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取群公告信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 获取群公告信息 响应体
/// <para>获取指定群组中的群公告信息，公告信息格式与[旧版云文档](https://open.feishu.cn/document/ukTMukTMukTM/uAzM5YjLwMTO24CMzkjN)格式相同。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 调用当前接口的用户或者机器人必须在对应的群组内。</para>
/// <para>- 获取内部群信息时，调用当前接口的用户或者机器人必须与对应群组在同一租户下。</para>
/// <para>接口ID：6946222929790435356</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-announcement/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-announcement%2fget</para>
/// </summary>
public record GetImV1ChatsByChatIdAnnouncementResponseDto
{
    /// <summary>
    /// <para>群公告内容，以旧版云文档序列化数据结构展示，数据结构详情参考：</para>
    /// <para>- [编辑旧版文档内容](https://open.feishu.cn/document/ukTMukTMukTM/uYDM2YjL2AjN24iNwYjN)</para>
    /// <para>- [旧版文档数据结构参考](https://open.feishu.cn/document/ukTMukTMukTM/ukDM2YjL5AjN24SOwYjN)</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxx</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// <para>文档当前版本号</para>
    /// <para>必填：否</para>
    /// <para>示例值：12</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>
    /// <para>文档生成的时间戳（秒）</para>
    /// <para>必填：否</para>
    /// <para>示例值：1609296809</para>
    /// </summary>
    [JsonPropertyName("create_time")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// <para>文档更新的时间戳（秒）</para>
    /// <para>必填：否</para>
    /// <para>示例值：1609296809</para>
    /// </summary>
    [JsonPropertyName("update_time")]
    public string? UpdateTime { get; set; }

    /// <summary>
    /// <para>文档所有者的 ID 类型</para>
    /// <para>- 如果所有者是用户，则类型与查询参数中的 user_id_type 相同，取值为`open_id` `user_id` `union_id` 其中之一，不同 ID 的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
    /// <para>- 如果所有者是机器人，为机器人应用的 `app_id`，详情参见 [获取应用身份访问凭证](https://open.feishu.cn/document/ukTMukTMukTM/ukDNz4SO0MjL5QzM/g)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：open_id</para>
    /// <para>可选值：<list type="bullet">
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。</item>
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。</item>
    /// <item>app_id：飞书开放平台应用的唯一标识。在创建应用时，由系统自动生成，用户不能自行修改。</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("owner_id_type")]
    public string? OwnerIdType { get; set; }

    /// <summary>
    /// <para>文档所有者 ID，ID 类型与 owner_id_type 取值一致。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
    /// </summary>
    [JsonPropertyName("owner_id")]
    public string? OwnerId { get; set; }

    /// <summary>
    /// <para>文档最新修改者 ID 类型。</para>
    /// <para>- 如果修改者是用户，则类型与查询参数中的 user_id_type 相同，取值为`open_id` `user_id` `union_id` 其中之一，不同 ID 的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
    /// <para>- 如果修改者是机器人，为机器人应用的 `app_id`，详情参见 [获取应用身份访问凭证](https://open.feishu.cn/document/ukTMukTMukTM/ukDNz4SO0MjL5QzM/g)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：open_id</para>
    /// <para>可选值：<list type="bullet">
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。</item>
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。</item>
    /// <item>app_id：飞书开放平台应用的唯一标识。在创建应用时，由系统自动生成，用户不能自行修改。</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("modifier_id_type")]
    public string? ModifierIdType { get; set; }

    /// <summary>
    /// <para>文档最新修改者 ID，ID 类型与 modifier_id_type 取值一致。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
    /// </summary>
    [JsonPropertyName("modifier_id")]
    public string? ModifierId { get; set; }
}
