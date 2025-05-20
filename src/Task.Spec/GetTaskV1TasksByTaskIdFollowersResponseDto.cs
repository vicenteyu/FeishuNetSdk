// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetTaskV1TasksByTaskIdFollowersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取关注人列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task.Spec;
/// <summary>
/// 获取关注人列表 响应体
/// <para>该接口用于查询任务关注人列表，支持分页，最大值为50。</para>
/// <para>接口ID：6985127383322165250</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-follower/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-follower%2flist</para>
/// </summary>
public record GetTaskV1TasksByTaskIdFollowersResponseDto : IPageableResponse<GetTaskV1TasksByTaskIdFollowersResponseDto.Follower>
{
    /// <summary>
    /// <para>返回的关注人ID列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Follower[]? Items { get; set; }

    /// <summary></summary>
    public record Follower
    {
        /// <summary>
        /// <para>任务关注人 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>要删除的关注人ID列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id_list")]
        public string[]? IdList { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
