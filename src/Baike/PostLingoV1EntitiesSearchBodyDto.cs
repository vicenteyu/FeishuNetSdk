namespace FeishuNetSdk.Baike;
/// <summary>
/// 模糊搜索词条 请求体
/// <para>传入关键词，与词条名、别名、释义等信息进行模糊匹配，返回搜到的词条信息。</para>
/// <para>接口ID：7249689905697095708</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/entity/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2fentity%2fsearch</para>
/// </summary>
public record PostLingoV1EntitiesSearchBodyDto
{
    /// <summary>
    /// <para>搜索关键词</para>
    /// <para>必填：否</para>
    /// <para>示例值：飞书词典</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// <para>分类筛选</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("classification_filter")]
    public PostLingoV1EntitiesSearchBodyDtoClassificationFilter? ClassificationFilter { get; set; }

    /// <summary>
    /// <para>分类筛选</para>
    /// </summary>
    public record PostLingoV1EntitiesSearchBodyDtoClassificationFilter
    {
        /// <summary>
        /// <para>需要获取的分类</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("include")]
        public string[]? Include { get; set; }

        /// <summary>
        /// <para>需要排除的分类</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("exclude")]
        public string[]? Exclude { get; set; }
    }

    /// <summary>
    /// <para>词条的创建来源，1：用户主动创建，2：批量导入，3：官方词，4：OpenAPI 创建</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sources")]
    public int[]? Sources { get; set; }

    /// <summary>
    /// <para>创建者</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_30b07b63089ea46518789914dac63d36</para>
    /// </summary>
    [JsonPropertyName("creators")]
    public string[]? Creators { get; set; }
}
