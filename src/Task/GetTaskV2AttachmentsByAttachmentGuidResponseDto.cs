using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 获取附件 响应体
/// <para>提供一个附件GUID，返回附件的详细信息，包括GUID，名称，大小，上传时间，临时可下载链接等。</para>
/// <para>接口ID：7297183031634493443</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/attachment/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fattachment%2fget</para>
/// </summary>
public record GetTaskV2AttachmentsByAttachmentGuidResponseDto
{
    /// <summary>
    /// <para>附件详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("attachment")]
    public GetTaskV2AttachmentsByAttachmentGuidResponseDtoAttachment? Attachment { get; set; }

    /// <summary>
    /// <para>附件详情</para>
    /// </summary>
    public record GetTaskV2AttachmentsByAttachmentGuidResponseDtoAttachment
    {
        /// <summary>
        /// <para>附件guid</para>
        /// <para>必填：否</para>
        /// <para>示例值：f860de3e-6881-4ddd-9321-070f36d1af0b</para>
        /// </summary>
        [JsonProperty("guid")]
        public string? Guid { get; set; }

        /// <summary>
        /// <para>附件在云文档系统中的token</para>
        /// <para>必填：否</para>
        /// <para>示例值：boxcnTDqPaRA6JbYnzQsZ2doB2b</para>
        /// </summary>
        [JsonProperty("file_token")]
        public string? FileToken { get; set; }

        /// <summary>
        /// <para>附件名</para>
        /// <para>必填：否</para>
        /// <para>示例值：foo.jpg</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>附件的字节大小</para>
        /// <para>必填：否</para>
        /// <para>示例值：62232</para>
        /// </summary>
        [JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// <para>附件归属的资源</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("resource")]
        public GetTaskV2AttachmentsByAttachmentGuidResponseDtoAttachmentResource? Resource { get; set; }

        /// <summary>
        /// <para>附件归属的资源</para>
        /// </summary>
        public record GetTaskV2AttachmentsByAttachmentGuidResponseDtoAttachmentResource
        {
            /// <summary>
            /// <para>资源类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：task</para>
            /// </summary>
            [JsonProperty("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>资源ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：e6e37dcc-f75a-5936-f589-12fb4b5c80c2</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }
        }

        /// <summary>
        /// <para>附件上传者</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("uploader")]
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
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>成员的类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：user</para>
            /// <para>默认值：user</para>
            /// </summary>
            [JsonProperty("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>成员角色</para>
            /// <para>必填：否</para>
            /// <para>示例值：editor</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonProperty("role")]
            public string? Role { get; set; }
        }

        /// <summary>
        /// <para>是否是封面图</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("is_cover")]
        public bool? IsCover { get; set; }

        /// <summary>
        /// <para>上传时间戳(ms)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// </summary>
        [JsonProperty("uploaded_at")]
        public string? UploadedAt { get; set; }

        /// <summary>
        /// <para>附件的临时下载url，有效时间3分钟，且只允许调用3次进行附件下载。只有在获取附件时会动态生成。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://example.com/download/authcode/?code=OWMzNDlmMjJmZThkYzZkZGJlMjYwZTI0OTUxZTE2MDJfMDZmZmMwOWVj</para>
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }
    }
}
