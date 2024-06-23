// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHireV1AttachmentsByAttachmentIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取附件信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取附件信息 响应体
/// <para>根据人才简历附件 ID 获取招聘系统中附件的元信息，比如文件名、创建时间、文件 URL 等。,可通过[获取人才信息接口](https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/get)获取人才的简历附件</para>
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
        /// <para>附件id</para>
        /// <para>必填：否</para>
        /// <para>示例值：6949805467799537964</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>附件的url</para>
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
        /// <para>媒体类型/MIME</para>
        /// <para>必填：否</para>
        /// <para>示例值：application/pdf</para>
        /// </summary>
        [JsonPropertyName("mime")]
        public string? Mime { get; set; }

        /// <summary>
        /// <para>附件创建时间（单位ms）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618899376480</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public int? CreateTime { get; set; }
    }
}
