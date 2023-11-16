namespace FeishuNetSdk.Vc;
/// <summary>
/// 删除会议室层级 请求体
/// <para>该接口可以用来删除某个会议室层级。</para>
/// <para>接口ID：7160517357592002563</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room_level/del</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_level%2fdel</para>
/// </summary>
public record PostVcV1RoomLevelsDelBodyDto
{
    /// <summary>
    /// <para>层级ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：omb_4ad1a2c7a2fbc5fc9570f38456931293</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("room_level_id")]
    public string RoomLevelId { get; set; } = string.Empty;

    /// <summary>
    /// <para>是否删除所有子层级</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("delete_child")]
    public bool? DeleteChild { get; set; }
}
