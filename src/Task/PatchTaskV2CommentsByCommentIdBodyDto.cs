using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 更新评论 请求体
/// <para>更新一条评论。</para>
/// <para>更新时，将`update_fields`字段中填写所有要修改的评论的字段名，同时在`comment`字段中填写要修改的字段的新值即可。更新接口规范详情见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 关于资源的更新”章节。</para>
/// <para>目前只支持更新评论的"conent"字段。</para>
/// <para>接口ID：7255580838154420252</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/comment/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcomment%2fpatch</para>
/// </summary>
public record PatchTaskV2CommentsByCommentIdBodyDto
{
    /// <summary>
    /// <para>要更新的评论数据。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("comment")]
    public InputComment Comment { get; set; } = new();

    /// <summary>
    /// <para>要更新的评论数据。</para>
    /// </summary>
    public record InputComment
    {
        /// <summary>
        /// <para>要更新的评论内容。如果更新该字段，不允许设为空，最大支持3000个utf8字符。</para>
        /// <para>必填：否</para>
        /// <para>示例值：举杯邀明月，对影成三人</para>
        /// <para>最大长度：10000</para>
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }
    }

    /// <summary>
    /// <para>要更新的字段，支持</para>
    /// <para><md-enum></para>
    /// <para><md-enum-item key="content" >评论内容</md-enum-item></para>
    /// <para></md-enum></para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("update_fields")]
    public string[] UpdateFields { get; set; } = Array.Empty<string>();
}
