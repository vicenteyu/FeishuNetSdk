// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetImV1ChatsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取用户或机器人所在的群列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 获取用户或机器人所在的群列表 响应体
/// <para>获取 [access_token](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-choose-which-type-of-token-to-use) 所代表的用户或者机器人所在的群列表。</para>
/// <para>## 前提条件</para>
/// <para>应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 注意事项</para>
/// <para>- 请注意区分本接口和[获取群信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/get)的请求 URL。</para>
/// <para>- 获取到的群列表中，不包含单聊（群模式为 `p2p`）。</para>
/// <para>- 查询参数 **user_id_type** 用于控制响应体中 owner_id 的类型，如果是获取机器人所在群列表该值可以不填。</para>
/// <para>接口ID：6946222931479412737</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2flist</para>
/// </summary>
public record GetImV1ChatsResponseDto : IPageableResponse<GetImV1ChatsResponseDto.ListChat>
{
    /// <summary>
    /// <para>群组列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public ListChat[]? Items { get; set; }

    /// <summary>
    /// <para>群组列表</para>
    /// </summary>
    public record ListChat
    {
        /// <summary>
        /// <para>群组 ID，调用[获取群信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/get)接口，根据群组 ID 可获取群详细信息。</para>
        /// <para>必填：否</para>
        /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
        /// </summary>
        [JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// <para>群头像 URL</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://p3-lark-file.byteimg.com/img/lark-avatar-staging/default-avatar_44ae0ca3-e140-494b-956f-78091e348435~100x100.jpg</para>
        /// </summary>
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// <para>群名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试群名称</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>群描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试群描述</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>群主的用户 ID，ID 类型与 owner_id_type 相对应。</para>
        /// <para>**注意**：群主为机器人时无返回值。</para>
        /// <para>必填：否</para>
        /// <para>示例值：4d7a3c6g</para>
        /// </summary>
        [JsonPropertyName("owner_id")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// <para>群主的用户 ID 类型，类型分为 user_id、open_id、union_id。各类型 ID 介绍参考[用户身份概述](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
        /// <para>**注意**：群主为机器人时无返回值。</para>
        /// <para>必填：否</para>
        /// <para>示例值：user_id</para>
        /// </summary>
        [JsonPropertyName("owner_id_type")]
        public string? OwnerIdType { get; set; }

        /// <summary>
        /// <para>是否是外部群</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("external")]
        public bool? External { get; set; }

        /// <summary>
        /// <para>租户 Key，为租户在飞书上的唯一标识，用来换取对应的tenant_access_token，也可以用作租户在应用中的唯一标识。</para>
        /// <para>必填：否</para>
        /// <para>示例值：736588c9260f175e</para>
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string? TenantKey { get; set; }

        /// <summary>
        /// <para>群状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：normal</para>
        /// <para>可选值：<list type="bullet">
        /// <item>normal：正常</item>
        /// <item>dissolved：解散</item>
        /// <item>dissolved_save：解散并保留</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("chat_status")]
        public string? ChatStatus { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：dmJCRHhpd3JRbGV1VEVNRFFyTitRWDY5ZFkybmYrMEUwMUFYT0VMMWdENEtuYUhsNUxGMDIwemtvdE5ORjBNQQ==</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
