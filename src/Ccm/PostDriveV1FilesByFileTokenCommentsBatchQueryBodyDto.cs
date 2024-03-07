namespace FeishuNetSdk.Ccm;
/// <summary>
/// 批量获取评论 请求体
/// <para>该接口用于根据评论 ID 列表批量获取云文档评论信息，包括评论和回复 ID、回复的内容、评论人和回复人的用户 ID 等。支持返回全局评论以及局部评论（可通过 is_whole 字段区分）。</para>
/// <para>接口ID：7123144042921590786</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/CommentAPI/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment%2fbatch_query</para>
/// </summary>
public record PostDriveV1FilesByFileTokenCommentsBatchQueryBodyDto
{
    /// <summary>
    /// <para>需要获取数据的评论 ID ，可通过调用获取云文档所有评论接口获取 comment_id</para>
    /// <para>必填：是</para>
    /// <para>示例值：1654857036541812356</para>
    /// </summary>
    [JsonPropertyName("comment_ids")]
    public string[] CommentIds { get; set; } = Array.Empty<string>();
}
