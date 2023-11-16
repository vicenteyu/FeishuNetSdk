namespace FeishuNetSdk.Vc;
/// <summary>
/// 查询会议室预定表单 响应体
/// <para>查询会议室预定表单。</para>
/// <para>接口ID：7194790671877144578</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/scope_config/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve_config-form%2fget</para>
/// </summary>
public record GetVcV1ReserveConfigsByReserveConfigIdFormResponseDto
{
    /// <summary>
    /// <para>预定表单</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("reserve_form_config")]
    public GetVcV1ReserveConfigsByReserveConfigIdFormResponseDtoReserveFormConfig ReserveFormConfig { get; set; } = new();

    /// <summary>
    /// <para>预定表单</para>
    /// </summary>
    public record GetVcV1ReserveConfigsByReserveConfigIdFormResponseDtoReserveFormConfig
    {
        /// <summary>
        /// <para>预定表单开关，true表示打开，false表示关闭</para>
        /// <para>必填：是</para>
        /// <para>示例值：false</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("reserve_form")]
        public bool ReserveForm { get; set; }

        /// <summary>
        /// <para>通知人列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("notified_users")]
        public SubscribeUser[]? NotifiedUsers { get; set; }

        /// <summary>
        /// <para>通知人列表</para>
        /// </summary>
        public record SubscribeUser
        {
            /// <summary>
            /// <para>预定管理员ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：ou_e8bce6c3935ef1fc1b432992fd9d3db8</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string UserId { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>最晚于会议开始前 notified_time收到通知（单位：分/时/天）</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("notified_time")]
        public int? NotifiedTime { get; set; }

        /// <summary>
        /// <para>时间单位，1为分钟；2为小时；3为天，默认为天</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("time_unit")]
        public int? TimeUnit { get; set; }
    }
}
