namespace FeishuNetSdk.Hire.Spec;
/// <summary>
/// 获取 Offer 申请表详细信息 响应体
/// <para>根据 Offer 申请表 ID，获取 Offer 申请表的详细信息</para>
/// <para>接口ID：6964286393804881948</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/hire_internal/offer/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer_schema%2fget</para>
/// </summary>
public record GetHireV1OfferSchemasByOfferSchemaIdResponseDto
{
    /// <summary>
    /// <para>offer申请表ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// <para>offer申请表使用场景</para>
    /// <para>**可选值有**：</para>
    /// <para>- `1`：Offer审批表</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>- `1`：Offer审批表</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("scenario")]
    public int? Scenario { get; set; }

    /// <summary>
    /// <para>申请表版本</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("version")]
    public int? Version { get; set; }

    /// <summary>
    /// <para>字段对象信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("object_list")]
    public OfferSchemaDetail[]? ObjectList { get; set; }

    /// <summary></summary>
    public record OfferSchemaDetail
    {
        /// <summary>
        /// <para>字段ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>字段名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public OfferSchemaName? Name { get; set; }

        /// <summary></summary>
        public record OfferSchemaName
        {
            /// <summary>
            /// <para>中文名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>字段类型, text=单行文本, long_text=多行文本, select=单选, multi_select=多选, date_select=日期, number=数字</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>字段是否为自定义</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("is_customized")]
        public bool? IsCustomized { get; set; }

        /// <summary>
        /// <para>单选/多选可选择字段的选项值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("option_list")]
        public OfferSchemaDetailOption[]? OptionList { get; set; }

        /// <summary></summary>
        public record OfferSchemaDetailOption
        {
            /// <summary>
            /// <para>名字</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public OfferSchemaName? Name { get; set; }

            /// <summary>
            /// <para>选项序号</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("index")]
            public int? Index { get; set; }

            /// <summary>
            /// <para>选项当前是否启用</para>
            /// <para>**可选值有**：</para>
            /// <para>- `1`：进行中</para>
            /// <para>- `2`：已终止</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>- `1`：进行中</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("active_status")]
            public int? ActiveStatus { get; set; }
        }
    }
}
