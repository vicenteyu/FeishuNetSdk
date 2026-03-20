namespace FeishuNetSdk.Contact;
/// <summary>
/// 通过 ID 获取用户姓名 响应体
/// <para>根据用户 ID 获取用户姓名，仅返回核心信息（姓名），不含扩展字段及敏感信息。</para>
/// <para>接口ID：7616208028610694095</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/basic_batch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fbasic_batch</para>
/// </summary>
public record PostContactV3UsersBasicBatchResponseDto
{
    /// <summary>
    /// <para>用户信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("users")]
    public BasicUser[]? Users { get; set; }

    /// <summary>
    /// <para>用户信息</para>
    /// </summary>
    public record BasicUser
    {
        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_b3b46653c99f1f6177a478974bdabb72</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>用户名</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>用户国际化名</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_name")]
        public I18nNameSuffix? I18nName { get; set; }

        /// <summary>
        /// <para>用户国际化名</para>
        /// </summary>
        public record I18nNameSuffix
        {
            /// <summary>
            /// <para>中文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>日文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：佐藤はるか</para>
            /// </summary>
            [JsonPropertyName("ja_jp")]
            public string? JaJp { get; set; }

            /// <summary>
            /// <para>英文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：Jason Zhang</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }
    }
}
