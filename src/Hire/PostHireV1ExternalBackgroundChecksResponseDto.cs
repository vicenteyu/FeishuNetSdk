// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1ExternalBackgroundChecksResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建外部背调 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建外部背调 响应体
/// <para>导入来自其他系统的背调信息，创建为外部背调。</para>
/// <para>接口ID：6992822583076372483</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_background_check%2fcreate</para>
/// </summary>
public record PostHireV1ExternalBackgroundChecksResponseDto
{
    /// <summary>
    /// <para>外部背调信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("external_background_check")]
    public PostHireV1ExternalBackgroundChecksResponseDtoExternalBackgroundCheck? ExternalBackgroundCheck { get; set; }

    /// <summary>
    /// <para>外部背调信息</para>
    /// </summary>
    public record PostHireV1ExternalBackgroundChecksResponseDtoExternalBackgroundCheck
    {
        /// <summary>
        /// <para>外部背调 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6989202908470446380</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>外部投递 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：1234111</para>
        /// </summary>
        [JsonPropertyName("external_application_id")]
        public string ExternalApplicationId { get; set; } = string.Empty;

        /// <summary>
        /// <para>背调日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：1626602069393</para>
        /// </summary>
        [JsonPropertyName("date")]
        public int? Date { get; set; }

        /// <summary>
        /// <para>背调名字</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试.pdf</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>背调结果</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }

        /// <summary>
        /// <para>背调附件ID列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：6989181065243969836</para>
        /// </summary>
        [JsonPropertyName("attachment_id_list")]
        public string[]? AttachmentIdList { get; set; }

        /// <summary>
        /// <para>背调附件</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("attachment_list")]
        public ExternalBackgroundCheckAttachment[]? AttachmentLists { get; set; }

        /// <summary>
        /// <para>背调附件</para>
        /// </summary>
        public record ExternalBackgroundCheckAttachment
        {
            /// <summary>
            /// <para>附件 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6987954043925432620</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>附件名字</para>
            /// <para>必填：否</para>
            /// <para>示例值：test_resume.pdf</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>附件大小</para>
            /// <para>必填：否</para>
            /// <para>示例值：126371</para>
            /// </summary>
            [JsonPropertyName("size")]
            public int? Size { get; set; }
        }
    }
}
