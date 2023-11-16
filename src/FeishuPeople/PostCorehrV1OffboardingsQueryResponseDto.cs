namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 查询员工离职原因列表 响应体
/// <para>查询「飞书人事」-「离职设置」中的离职原因。</para>
/// <para>接口ID：7097044451155197956</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/offboarding/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2foffboarding%2fquery</para>
/// </summary>
public record PostCorehrV1OffboardingsQueryResponseDto
{
    /// <summary>
    /// <para>离职原因列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public OffboardingReason[]? Items { get; set; }

    /// <summary>
    /// <para>离职原因列表</para>
    /// </summary>
    public record OffboardingReason
    {
        /// <summary>
        /// <para>离职原因唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：reason_for_offboarding_option8</para>
        /// </summary>
        [JsonPropertyName("offboarding_reason_unique_identifier")]
        public string? OffboardingReasonUniqueIdentifier { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[]? Names { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>名称信息的语言</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称信息的内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>是否启用，true为启用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// <para>当前离职原因的父级原因唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：offboarding_reason_1</para>
        /// </summary>
        [JsonPropertyName("parent_offboarding_reason_unique_identifier")]
        public string? ParentOffboardingReasonUniqueIdentifier { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-08-2020:28:23</para>
        /// </summary>
        [JsonPropertyName("created_time")]
        public string? CreatedTime { get; set; }

        /// <summary>
        /// <para>更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-01-0717:21:06</para>
        /// </summary>
        [JsonPropertyName("updated_time")]
        public string? UpdatedTime { get; set; }
    }
}
