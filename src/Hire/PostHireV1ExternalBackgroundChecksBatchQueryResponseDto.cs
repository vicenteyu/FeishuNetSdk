// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostHireV1ExternalBackgroundChecksBatchQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询外部背调列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 查询外部背调列表 响应体
/// <para>可根据外部投递 ID 或外部背调 ID 列表查询外部背调信息。</para>
/// <para>接口ID：7407298680641028099</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-background-info/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_background_check%2fbatch_query</para>
/// </summary>
public record PostHireV1ExternalBackgroundChecksBatchQueryResponseDto
{
    /// <summary>
    /// <para>外部背调</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public ExternalBackgroundCheck[]? Items { get; set; }

    /// <summary>
    /// <para>外部背调</para>
    /// </summary>
    public record ExternalBackgroundCheck
    {
        /// <summary>
        /// <para>外部背调 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6989202908470446380</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>外部投递 ID，详情可查看：[查询外部投递列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/external_application/list)</para>
        /// <para>必填：是</para>
        /// <para>示例值：7003247299220982060</para>
        /// </summary>
        [JsonPropertyName("external_application_id")]
        public string ExternalApplicationId { get; set; } = string.Empty;

        /// <summary>
        /// <para>背调日期，毫秒时间戳（字段类型为：int64）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1626602069393</para>
        /// </summary>
        [JsonPropertyName("date")]
        public long? Date { get; set; }

        /// <summary>
        /// <para>背调名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三的背调</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>背调结果</para>
        /// <para>必填：否</para>
        /// <para>示例值：已通过</para>
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }

        /// <summary>
        /// <para>背调附件列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("attachment_list")]
        public ExternalBackgroundCheckAttachment[]? AttachmentLists { get; set; }

        /// <summary>
        /// <para>背调附件列表</para>
        /// </summary>
        public record ExternalBackgroundCheckAttachment
        {
            /// <summary>
            /// <para>附件 ID，详情可查看：[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6987954043925432620</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>附件名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：test_resume.pdf</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>附件大小（单位：字节）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1928</para>
            /// </summary>
            [JsonPropertyName("size")]
            public int? Size { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
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
