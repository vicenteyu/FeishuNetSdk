namespace FeishuNetSdk.Im;
/// <summary>
/// 创建标签 响应体
/// <para>创建标签并返回标签 ID。</para>
/// <para>接口ID：7315032956271280132</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/group/im-v2/tag/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2ftag%2fcreate</para>
/// </summary>
public record PostImV2TagsResponseDto
{
    /// <summary>
    /// <para>创建的 tag 的 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：716168xxxxx</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// <para>创建失败原因</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("create_tag_fail_reason")]
    public PostImV2TagsResponseDtoCreateTagFailReason? CreateTagFailReason { get; set; }

    /// <summary>
    /// <para>创建失败原因</para>
    /// </summary>
    public record PostImV2TagsResponseDtoCreateTagFailReason
    {
        /// <summary>
        /// <para>名称重复的标签id</para>
        /// <para>必填：否</para>
        /// <para>示例值：716168xxxxx</para>
        /// </summary>
        [JsonPropertyName("duplicate_id")]
        public string? DuplicateId { get; set; }
    }
}
