using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 批量获取全文评论 请求体
/// <para>该接口用于根据评论 ID 列表批量获取全文评论，暂时不支持局部评论</para>
/// <para>接口ID：7123144042921590786</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/CommentAPI/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment%2fbatch_query</para>
/// </summary>
public record PostDriveV1FilesByFileTokenCommentsBatchQueryBodyDto
{
    /// <summary>
    /// <para>需要获取数据的评论id</para>
    /// <para>必填：是</para>
    /// <para>示例值：1654857036541812356</para>
    /// </summary>
    [JsonProperty("comment_ids")]
    public string[] CommentIds { get; set; } = Array.Empty<string>();
}
