// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostTaskV1TasksByTaskIdFollowersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增关注人 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 新增关注人 响应体
/// <para>该接口用于新增任务关注人。可以一次性添加多位关注人。关注人ID要使用表示用户的ID。</para>
/// <para>接口ID：6985127383322181634</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-follower/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-follower%2fcreate</para>
/// </summary>
public record PostTaskV1TasksByTaskIdFollowersResponseDto
{
    /// <summary>
    /// <para>创建后的任务关注者</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("follower")]
    public PostTaskV1TasksByTaskIdFollowersResponseDtoFollower Follower { get; set; } = new();

    /// <summary>
    /// <para>创建后的任务关注者</para>
    /// </summary>
    public record PostTaskV1TasksByTaskIdFollowersResponseDtoFollower
    {
        /// <summary>
        /// <para>任务关注人 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_99e1a581b36ecc4862cbfbce473f3123</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>要删除的关注人ID列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：[ "ou_550cc75233d8b7b9fcbdad65f34433f4", "ou_d1e9d27cf3235b40ca9a67c67ef088b0"]</para>
        /// </summary>
        [JsonPropertyName("id_list")]
        public string[]? IdList { get; set; }
    }
}
