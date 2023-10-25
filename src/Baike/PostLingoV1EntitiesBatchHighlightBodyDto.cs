using Newtonsoft.Json;
namespace FeishuNetSdk.Baike;
/// <summary>
/// 批量高亮 请求体
/// <para>通过这个接口，可以传入一段文本，获取这段文本中所有词条的 ID</para>
/// <para>接口ID：7293809202833342492</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/entity/batch_highlight</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2fentity%2fbatch_highlight</para>
/// </summary>
public record PostLingoV1EntitiesBatchHighlightBodyDto
{
    /// <summary>
    /// <para>一批需要被识别词条的文本（一批不要超过20段文本，每段文本不要超过1000字）</para>
    /// <para>必填：是</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonProperty("texts")]
    public string[] Texts { get; set; } = Array.Empty<string>();
}
