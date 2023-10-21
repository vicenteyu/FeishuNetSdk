using Newtonsoft.Json;
namespace FeishuNetSdk.Baike;
/// <summary>
/// 提取潜在词条 响应体
/// <para>提取文本中可能成为词条的词语，且不会过滤已经成为词条的词语。同时返回推荐的别名。</para>
/// <para>接口ID：7249689905697144860</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/entity/extract</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2fentity%2fextract</para>
/// </summary>
public record PostLingoV1EntitiesExtractResponseDto
{
    /// <summary>
    /// <para>文本中可能的成为百科词条的实体词</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("entity_word")]
    public EntityWord[] EntityWords { get; set; } = Array.Empty<EntityWord>();

    /// <summary>
    /// <para>文本中可能的成为百科词条的实体词</para>
    /// </summary>
    public record EntityWord
    {
        /// <summary>
        /// <para>抽取出的词条名</para>
        /// <para>必填：是</para>
        /// <para>示例值：飞书词典</para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>词条可能的推荐别名</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("aliases")]
        public string[]? Aliases { get; set; }
    }
}
