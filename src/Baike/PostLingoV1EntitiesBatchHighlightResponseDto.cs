using Newtonsoft.Json;
namespace FeishuNetSdk.Baike;
/// <summary>
/// 批量高亮 响应体
/// <para>通过这个接口，可以传入一段文本，获取这段文本中所有词条的 ID</para>
/// <para>接口ID：7293809202833342492</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/entity/batch_highlight</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2fentity%2fbatch_highlight</para>
/// </summary>
public record PostLingoV1EntitiesBatchHighlightResponseDto
{
    /// <summary>
    /// <para>和输入texts对应长度的段落实体词信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("phrases")]
    public Phrase[][]? Phrases { get; set; }

    public record Phrase
    {
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("entity_ids")]
        public string[] EntityIds { get; set; } = Array.Empty<string>();

        public record SpanSuffix
        {
            [JsonProperty("start")]
            public int Start { get; set; }

            [JsonProperty("end")]
            public int End { get; set; }
        }
    }
}
