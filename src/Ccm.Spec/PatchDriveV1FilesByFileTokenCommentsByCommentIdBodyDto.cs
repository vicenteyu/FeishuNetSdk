namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 解决/恢复 评论 请求体
/// <para>解决或恢复云文档中的评论。</para>
/// <para>接口ID：6955017385137766401</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/CommentAPI/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment%2fpatch</para>
/// </summary>
public record PatchDriveV1FilesByFileTokenCommentsByCommentIdBodyDto
{
    /// <summary>
    /// <para>评论解决标志</para>
    /// <para>**示例值**：true</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("is_solved")]
    public bool IsSolved { get; set; }
}
