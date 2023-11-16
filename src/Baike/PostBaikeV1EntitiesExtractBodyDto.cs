namespace FeishuNetSdk.Baike;
/// <summary>
/// 提取潜在的词条 请求体
/// <para>提取文本中可能成为词条的词语，且不会过滤已经成为词条的词语。同时返回推荐的别名。</para>
/// <para>接口ID：7158733167621242883</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/baike-v1/entity/extract</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbaike-v1%2fentity%2fextract</para>
/// </summary>
public record PostBaikeV1EntitiesExtractBodyDto
{
    /// <summary>
    /// <para>需要被提取词条的文本（不会过滤租户中已成为词条的内容）</para>
    /// <para>必填：否</para>
    /// <para>示例值：飞书词典是一部高效汇聚企业内各类信息，并可由企业成员参与编辑的在线词典</para>
    /// <para>最大长度：128</para>
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}
