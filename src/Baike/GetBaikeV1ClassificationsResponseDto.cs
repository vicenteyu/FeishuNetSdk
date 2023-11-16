namespace FeishuNetSdk.Baike;
/// <summary>
/// 获取词典分类 响应体
/// <para>获取飞书词典当前分类。</para>
/// <para>飞书词典目前为二级分类体系，每个词条可添加多个二级分类，但选择的二级分类必须从属于不同的一级分类。</para>
/// <para>接口ID：7085379347152076802</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/baike-v1/classification/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbaike-v1%2fclassification%2flist</para>
/// </summary>
public record GetBaikeV1ClassificationsResponseDto
{
    /// <summary>
    /// <para>分类</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Classification[]? Items { get; set; }

    /// <summary>
    /// <para>分类</para>
    /// </summary>
    public record Classification
    {
        /// <summary>
        /// <para>二级分类 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7049606926****37761</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>二级分类名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：行业术语</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>对应一级分类 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7049606926****37777</para>
        /// </summary>
        [JsonPropertyName("father_id")]
        public string? FatherId { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：408ecac018b2e3518db37275e812****bb8ad3e755fc886f322ac6c430ba</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
