// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutTaskV1TasksByTaskIdCommentsByCommentIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新评论 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 更新评论 请求体
/// <para>该接口用于更新评论内容。</para>
/// <para>接口ID：6999599891686227970</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-comment/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-comment%2fupdate</para>
/// </summary>
public record PutTaskV1TasksByTaskIdCommentsByCommentIdBodyDto
{
    /// <summary>
    /// <para>新的评论内容</para>
    /// <para>必填：否</para>
    /// <para>示例值：飞流直下三千尺，疑是银河落九天</para>
    /// <para>最大长度：65536</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// <para>新的富文本评论内容（优先使用）</para>
    /// <para>必填：否</para>
    /// <para>示例值：飞流直下三千尺，疑是银河落九天&lt;atid=7058204817822318612&gt;&lt;/at&gt;</para>
    /// <para>最大长度：65536</para>
    /// </summary>
    [JsonPropertyName("rich_content")]
    public string? RichContent { get; set; }
}
