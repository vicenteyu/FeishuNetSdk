// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostTaskV2AttachmentsUploadResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传附件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 上传附件 响应体
/// <para>为特定资源上传附件。本接口可以支持一次上传多个附件，最多5个。每个附件尺寸不超过50MB，格式不限。</para>
/// <para>上传请求体的格式为"form-data"。若希望上传多个附件，则提供多个"file"字段即可。返回的附件顺序将会与输入的file顺序保持一致。</para>
/// <para>目前资源类型仅支持"task", `resource_id`需要填写任务的GUID。</para>
/// <para>接口ID：7297183031634460675</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/attachment/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fattachment%2fupload</para>
/// </summary>
public record PostTaskV2AttachmentsUploadResponseDto
{
    /// <summary>
    /// <para>上传的附件列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Attachment[]? Items { get; set; }

    /// <summary>
    /// <para>上传的附件列表</para>
    /// </summary>
    public record Attachment
    {
        /// <summary>
        /// <para>附件GUID</para>
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
            /// <para>示例值：creator</para>
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
    }
}
