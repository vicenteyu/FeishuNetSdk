using Newtonsoft.Json;
namespace FeishuNetSdk.Baike;
/// <summary>
/// 精准搜索词条 响应体
/// <para>将关键词与词条名、别名精准匹配，并返回对应的 词条 ID。</para>
/// <para>接口ID：7249689905697079324</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/entity/match</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2fentity%2fmatch</para>
/// </summary>
public record PostLingoV1EntitiesMatchResponseDto
{
    /// <summary>
    /// <para>搜索结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("results")]
    public MatchInfo[]? Results { get; set; }

    /// <summary>
    /// <para>搜索结果</para>
    /// </summary>
    public record MatchInfo
    {
        /// <summary>
        /// <para>词条 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：enterprise_34***584</para>
        /// </summary>
        [JsonProperty("entity_id")]
        public string? EntityId { get; set; }

        /// <summary>
        /// <para>匹配中的字段</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：词条名</item>
        /// <item>1：全称</item>
        /// <item>2：别名</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("type")]
        public int? Type { get; set; }
    }
}
