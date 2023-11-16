namespace FeishuNetSdk.Vc;
/// <summary>
/// 更新会议室层级 请求体
/// <para>该接口可以用来更新某个会议室层级的信息。</para>
/// <para>接口ID：7160517356095995908</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room_level/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_level%2fpatch</para>
/// </summary>
public record PatchVcV1RoomLevelsByRoomLevelIdBodyDto
{
    /// <summary>
    /// <para>层级名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：测试层级</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>父层级ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：omb_4ad1a2c7a2fbc5fc9570f38456931293</para>
    /// </summary>
    [JsonPropertyName("parent_id")]
    public string ParentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义层级ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：10000</para>
    /// </summary>
    [JsonPropertyName("custom_group_id")]
    public string? CustomGroupId { get; set; }
}
