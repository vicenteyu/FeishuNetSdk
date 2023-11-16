namespace FeishuNetSdk.Vc;
/// <summary>
/// 创建签到板部署码 响应体
/// <para>创建一个范围内的签到板部署码</para>
/// <para>接口ID：7070073879629430788</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/room_config/set_checkboard_access_code</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_config%2fset_checkboard_access_code</para>
/// </summary>
public record PostVcV1RoomConfigsSetCheckboardAccessCodeResponseDto
{
    /// <summary>
    /// <para>部署访问码</para>
    /// <para>必填：否</para>
    /// <para>示例值：YNMLTJOUZ</para>
    /// </summary>
    [JsonPropertyName("access_code")]
    public string? AccessCode { get; set; }
}
