// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="DriveNoticeCommentAddV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加评论、回复通知事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Events;
/// <summary>
/// 添加评论、回复通知事件 事件体
/// <para>当用户有新文档评论或回复通知会触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=drive&amp;version=v1&amp;resource=notice&amp;event=comment_add)</para>
/// <para>接口ID：7623827135371250639</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/notice/events/comment_add</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fnotice%2fevents%2fcomment_add</para>
/// </summary>
public record DriveNoticeCommentAddV1EventBodyDto() : EventBodyDto("drive.notice.comment_add_v1")
{
    /// <summary>
    /// <para>通知元信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("notice_meta")]
    public Notice? NoticeMeta { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record Notice
    {
        /// <summary>
        /// <para>文档类型</para>
        /// <para>**可选值有**：</para>
        /// <para>doc:旧版文档,docx:新版文档,sheet:电子表格,bitable:多维表格,slides:幻灯片,file:文件</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 长度范围：`1` ～ `50` 字符</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>doc：旧版文档</item>
        /// <item>docx：新版文档</item>
        /// <item>sheet：电子表格</item>
        /// <item>bitable：多维表格</item>
        /// <item>slides：幻灯片</item>
        /// <item>file：文件</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("file_type")]
        public string? FileType { get; set; }

        /// <summary>
        /// <para>文档token</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 长度范围：`22` ～ `27` 字符</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("file_token")]
        public string? FileToken { get; set; }

        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("from_user_id")]
        public UserIdSuffix? FromUserId { get; set; }

        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("to_user_id")]
        public UserIdSuffix? ToUserId { get; set; }

        /// <summary>
        /// <para>评论操作类型，枚举值：add_comment、add_reply</para>
        /// <para>**可选值有**：</para>
        /// <para>add_comment:添加评论,add_reply:添加回复</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 长度范围：`2` ～ `50` 字符</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>add_comment：添加评论</item>
        /// <item>add_reply：添加回复</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("notice_type")]
        public string? NoticeType { get; set; }
    }

    /// <summary>
    /// <para>评论ID</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`15` ～ `30` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("comment_id")]
    public string? CommentId { get; set; }

    /// <summary>
    /// <para>回复ID</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`15` ～ `30` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("reply_id")]
    public string? ReplyId { get; set; }

    /// <summary>
    /// <para>接收者是否被mention</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("is_mentioned")]
    public bool? IsMentioned { get; set; }
}
