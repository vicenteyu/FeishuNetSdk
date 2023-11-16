namespace FeishuNetSdk.Im;
/// <summary>
/// 获取群公告信息 响应体
/// <para>获取会话中的群公告信息，公告信息格式与[旧版云文档](https://open.feishu.cn/document/ukTMukTMukTM/uAzM5YjLwMTO24CMzkjN)格式相同。</para>
/// <para>接口ID：6946222929790435356</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-announcement/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-announcement%2fget</para>
/// </summary>
public record GetImV1ChatsByChatIdAnnouncementResponseDto
{
    /// <summary>
    /// <para>云文档序列化信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxx</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// <para>文档当前版本号 纯数字</para>
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
    /// <para>- 如果所有者是用户，则与查询参数中的user_id_type 相同；取值为`open_id` `user_id` `union_id` 其中之一，不同 ID 的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
    /// <para>- 如果所有者是机器人，为机器人应用的 `app_id`，详情参见 [获取应用身份访问凭证](https://open.feishu.cn/document/ukTMukTMukTM/ukDNz4SO0MjL5QzM/g)</para>
    /// <para>必填：否</para>
    /// <para>示例值：open_id</para>
    /// <para>可选值：<list type="bullet">
    /// <item>user_id：以user_id来识别用户</item>
    /// <item>union_id：以union_id来识别用户</item>
    /// <item>open_id：以open_id来识别用户</item>
    /// <item>app_id：以app_id来识别机器人应用</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("owner_id_type")]
    public string? OwnerIdType { get; set; }

    /// <summary>
    /// <para>文档所有者 ID，ID 值与owner_id_type 中的ID类型对应</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
    /// </summary>
    [JsonPropertyName("owner_id")]
    public string? OwnerId { get; set; }

    /// <summary>
    /// <para>文档最新修改者 id 类型</para>
    /// <para>- 如果修改者是用户，则与查询参数中的user_id_type 相同；取值为`open_id` `user_id` `union_id` 其中之一，不同 ID 的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
    /// <para>- 如果修改者是机器人，为机器人应用的 `app_id`，详情参见 [获取应用身份访问凭证](https://open.feishu.cn/document/ukTMukTMukTM/ukDNz4SO0MjL5QzM/g)</para>
    /// <para>必填：否</para>
    /// <para>示例值：open_id</para>
    /// <para>可选值：<list type="bullet">
    /// <item>user_id：以user_id来识别用户</item>
    /// <item>union_id：以union_id来识别用户</item>
    /// <item>open_id：以open_id来识别用户</item>
    /// <item>app_id：以app_id来识别应用</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("modifier_id_type")]
    public string? ModifierIdType { get; set; }

    /// <summary>
    /// <para>文档最新修改者 ID，ID 值与modifier_id_type 中的ID类型对应</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
    /// </summary>
    [JsonPropertyName("modifier_id")]
    public string? ModifierId { get; set; }
}
