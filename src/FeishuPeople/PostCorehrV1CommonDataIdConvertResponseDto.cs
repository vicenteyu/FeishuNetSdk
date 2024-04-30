namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// ID 转换 响应体
/// <para>该接口用来进行飞书人事和飞书通讯录、people admin 的各种 ID 转换（仅适用于飞书人事新链路租户）</para>
/// <para>接口ID：7338765273649348612</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/common_data-id/convert</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcommon_data-id%2fconvert</para>
/// </summary>
public record PostCorehrV1CommonDataIdConvertResponseDto
{
    /// <summary>
    /// <para>ID 信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public IdInfo[]? Items { get; set; }

    /// <summary>
    /// <para>ID 信息列表</para>
    /// </summary>
    public record IdInfo
    {
        /// <summary>
        /// <para>传入的 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7224321696097404460</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>目标 ID 值</para>
        /// <para>必填：否</para>
        /// <para>示例值：7224321696097404461</para>
        /// </summary>
        [JsonPropertyName("target_id")]
        public string? TargetId { get; set; }
    }
}
