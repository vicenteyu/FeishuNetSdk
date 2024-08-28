// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-12
// ************************************************************************
// <copyright file="GetHireV1AttachmentsByAttachmentIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取附件信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取附件信息 响应体
/// <para>根据附件 ID 和附件类型获取招聘系统中附件的信息，比如附件名称、附件创建时间、附件下载地址等。</para>
/// <para>接口ID：6964286393804898332</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/attachment/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fattachment%2fget</para>
/// </summary>
public record GetHireV1AttachmentsByAttachmentIdResponseDto
{
    /// <summary>
    /// <para>附件信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("attachment")]
    public GetHireV1AttachmentsByAttachmentIdResponseDtoAttachment? Attachment { get; set; }

    /// <summary>
    /// <para>附件信息</para>
    /// </summary>
    public record GetHireV1AttachmentsByAttachmentIdResponseDtoAttachment
    {
        /// <summary>
        /// <para>附件 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6949805467799537964</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>附件下载地址，有效期为 30 分钟</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://hire.feishu.cn/blob/xx/</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>附件文件名</para>
        /// <para>必填：否</para>
        /// <para>示例值：xx的简历.prd</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>附件媒体类型/MIME，遵守统一标准，请参考[百度百科-MIME](https://baike.baidu.com/item/MIME/2900607)</para>
        /// <para>必填：否</para>
        /// <para>示例值：application/pdf</para>
        /// </summary>
        [JsonPropertyName("mime")]
        public string? Mime { get; set; }

        /// <summary>
        /// <para>附件创建时间，毫秒时间戳（int64类型）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618899376480</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public long? CreateTime { get; set; }
    }
}
