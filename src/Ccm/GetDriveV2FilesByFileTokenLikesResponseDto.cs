// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="GetDriveV2FilesByFileTokenLikesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取云文档的点赞者列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取云文档的点赞者列表 响应体
/// <para>获取指定云文档的点赞者列表并按点赞时间由近到远分页返回。</para>
/// <para>接口ID：7270815553257619457</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/drive-v1/like/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIzNzUjLyczM14iM3MTN%2fdrive-v2%2ffile-like%2flist</para>
/// </summary>
public record GetDriveV2FilesByFileTokenLikesResponseDto : IPageableResponse<GetDriveV2FilesByFileTokenLikesResponseDto.FileLike>
{
    /// <summary>
    /// <para>云文档的点赞者列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public FileLike[]? Items { get; set; }

    /// <summary>
    /// <para>云文档的点赞者列表</para>
    /// </summary>
    public record FileLike
    {
        /// <summary>
        /// <para>用户 ID。与查询参数 user_id_type 一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_3bbe8a09c20e89cce9bff989ed840674</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>用户最后点赞时间，秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1690857821</para>
        /// </summary>
        [JsonPropertyName("last_liked_time")]
        public string? LastLikedTime { get; set; }

        /// <summary>
        /// <para>用户名字，用户信息被脱敏时此值不会返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonPropertyName("user_name")]
        public string? UserName { get; set; }

        /// <summary>
        /// <para>用户英文名字，用户信息被脱敏时此值不会返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：San Zhang</para>
        /// </summary>
        [JsonPropertyName("user_en_name")]
        public string? UserEnName { get; set; }

        /// <summary>
        /// <para>用户头像，用户信息被脱敏时此值不会返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://foo.icon.com/xxxx</para>
        /// </summary>
        [JsonPropertyName("user_avatar_url")]
        public string? UserAvatarUrl { get; set; }

        /// <summary>
        /// <para>用户信息是否脱敏</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("user_is_desensitized")]
        public bool? UserIsDesensitized { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：aw7DoMKBFMOGwqHCrcO8w6jCmMOvw6ILeADCvsKNw57Di8O5XGV3LG4_w5HCqhFxSnDCrCzCn0BgZcOYUg85EMOYcEAcwqYOw4ojw5QFwofCu8KoIMO3K8Ktw4IuNMOBBHNYw4bCgCV3U1zDu8K-J8KSR8Kgw7Y0fsKZdsKvW3d9w53DnkHDrcO5bDkYwrvDisOEPcOtVFJ-I03CnsOILMOoAmLDknd6dsKqG1bClAjDuS3CvcOTwo7Dg8OrwovDsRdqIcKxw5HDohTDtXN9w5rCkWo</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
