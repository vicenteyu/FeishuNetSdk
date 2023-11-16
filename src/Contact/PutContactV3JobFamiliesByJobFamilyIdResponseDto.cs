namespace FeishuNetSdk.Contact;
/// <summary>
/// 更新序列 响应体
/// <para>该接口用于更新租户序列的信息。</para>
/// <para>接口ID：7194273512282406916</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/job_family/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fjob_family%2fupdate</para>
/// </summary>
public record PutContactV3JobFamiliesByJobFamilyIdResponseDto
{
    /// <summary>
    /// <para>更新后的序列信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_family")]
    public PutContactV3JobFamiliesByJobFamilyIdResponseDtoJobFamily? JobFamily { get; set; }

    /// <summary>
    /// <para>更新后的序列信息</para>
    /// </summary>
    public record PutContactV3JobFamiliesByJobFamilyIdResponseDtoJobFamily
    {
        /// <summary>
        /// <para>序列名称。1-100字符，支持中、英文及符号</para>
        /// <para>必填：否</para>
        /// <para>示例值：产品</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>序列描述，描述序列详情信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：负责产品策略制定的相关工作</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>上级序列ID。需是该租户的序列ID列表中的值，对应唯一的序列名称。</para>
        /// <para>必填：否</para>
        /// <para>示例值：mga5oa8ayjlpzjq</para>
        /// </summary>
        [JsonPropertyName("parent_job_family_id")]
        public string? ParentJobFamilyId { get; set; }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("status")]
        public bool? Status { get; set; }

        /// <summary>
        /// <para>多语言序列名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_name")]
        public I18nContent[]? I18nNames { get; set; }

        /// <summary>
        /// <para>多语言序列名称</para>
        /// </summary>
        public record I18nContent
        {
            /// <summary>
            /// <para>语言版本</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn</para>
            /// </summary>
            [JsonPropertyName("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// <para>字段名</para>
            /// <para>必填：否</para>
            /// <para>示例值：多语言内容</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }

        /// <summary>
        /// <para>多语言描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_description")]
        public I18nContent[]? I18nDescriptions { get; set; }

        /// <summary>
        /// <para>职级序列ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：mga5oa8ayjlpkzy</para>
        /// </summary>
        [JsonPropertyName("job_family_id")]
        public string? JobFamilyId { get; set; }
    }
}
