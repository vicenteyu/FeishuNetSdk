// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetTaskV2AttachmentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>列取附件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 列取附件 响应体
/// <para>列取一个资源的所有附件。返回的附件列表支持分页，按照附件上传时间排序。</para>
/// <para>每个附件会返回一个可供下载的临时url，有效期为3分钟，最多可以支持3次下载。如果超过使用限制，需要通过本接口获取新的临时url。</para>
/// <para>接口ID：7297183031634477059</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/attachment/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fattachment%2flist</para>
/// </summary>
public record GetTaskV2AttachmentsResponseDto
{
    /// <summary>
    /// <para>附件列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Attachment[]? Items { get; set; }

    /// <summary>
    /// <para>附件列表</para>
    /// </summary>
    public record Attachment
    {
        /// <summary>
        /// <para>附件guid</para>
        /// <para>必填：否</para>
        /// <para>示例值：f860de3e-6881-4ddd-9321-070f36d1af0b</para>
        /// </summary>
        [JsonPropertyName("guid")]
        public string? Guid { get; set; }

        /// <summary>
        /// <para>附件在云文档系统中的token</para>
        /// <para>必填：否</para>
        /// <para>示例值：boxcnTDqPaRA6JbYnzQsZ2doB2b</para>
        /// </summary>
        [JsonPropertyName("file_token")]
        public string? FileToken { get; set; }

        /// <summary>
        /// <para>附件名</para>
        /// <para>必填：否</para>
        /// <para>示例值：foo.jpg</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>附件的字节大小</para>
        /// <para>必填：否</para>
        /// <para>示例值：62232</para>
        /// </summary>
        [JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// <para>附件归属的资源</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("resource")]
        public AttachmentResource? Resource { get; set; }

        /// <summary>
        /// <para>附件归属的资源</para>
        /// </summary>
        public record AttachmentResource
        {
            /// <summary>
            /// <para>资源类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：task</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>资源ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：e6e37dcc-f75a-5936-f589-12fb4b5c80c2</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }
        }

        /// <summary>
        /// <para>附件上传者</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("uploader")]
        public Member? Uploader { get; set; }

        /// <summary>
        /// <para>附件上传者</para>
        /// </summary>
        public record Member
        {
            /// <summary>
            /// <para>表示member的id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f</para>
            /// <para>最大长度：100</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>成员的类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：user</para>
            /// <para>默认值：user</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>成员角色</para>
            /// <para>必填：否</para>
            /// <para>示例值：editor</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonPropertyName("role")]
            public string? Role { get; set; }
        }

        /// <summary>
        /// <para>是否是封面图</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_cover")]
        public bool? IsCover { get; set; }

        /// <summary>
        /// <para>上传时间戳(ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonPropertyName("uploaded_at")]
        public string? UploadedAt { get; set; }

        /// <summary>
        /// <para>附件的临时下载url，有效时间3分钟，且只允许调用3次进行附件下载。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://example.com/download/authcode/?code=OWMzNDlmMjJmZThkYzZkZGJlMjYwZTI0OTUxZTE2MDJfMDZmZmMwOWVj</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：aWQ9NzEwMjMzMjMxMDE=</para>
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
