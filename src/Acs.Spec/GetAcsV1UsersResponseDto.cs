// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetAcsV1UsersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取用户列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Acs.Spec;
/// <summary>
/// 获取用户列表 响应体
/// <para>使用该接口获取智能门禁中所有用户信息。</para>
/// <para>接口ID：6987691292973891585</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/acs-v1/user/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2fuser%2flist</para>
/// </summary>
public record GetAcsV1UsersResponseDto : IPageableResponse<GetAcsV1UsersResponseDto.User>
{
    /// <summary>
    /// <para>-</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public User[]? Items { get; set; }

    /// <summary></summary>
    public record User
    {
        /// <summary>
        /// <para>用户特征</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("feature")]
        public FeatureSuffix? Feature { get; set; }

        /// <summary></summary>
        public record FeatureSuffix
        {
            /// <summary>
            /// <para>卡号</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("card")]
            public int? Card { get; set; }

            /// <summary>
            /// <para>是否已上传人脸图片</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("face_uploaded")]
            public bool? FaceUploaded { get; set; }
        }

        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
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
