// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="GetHireV1InterviewRecordsAttachmentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取面试评价信息附件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取面试评价信息附件 响应体
/// <para>获取面试评价信息附件，附件为 PDF 格式。</para>
/// <para>接口ID：7215583964449849372</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/interview/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterview_record-attachment%2fget</para>
/// </summary>
public record GetHireV1InterviewRecordsAttachmentsResponseDto
{
    /// <summary>
    /// <para>附件信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("attachment")]
    public AttachmentInfo? Attachment { get; set; }

    /// <summary>
    /// <para>附件信息</para>
    /// </summary>
    public record AttachmentInfo
    {
        /// <summary>
        /// <para>附件id</para>
        /// <para>必填：否</para>
        /// <para>示例值：6949805467799537964</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>附件的url（链接有效时间半小时）</para>
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
        public string? CreateTime { get; set; }
    }
}
