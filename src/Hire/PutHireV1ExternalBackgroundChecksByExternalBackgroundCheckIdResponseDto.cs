// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PutHireV1ExternalBackgroundChecksByExternalBackgroundCheckIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新外部背调 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新外部背调 响应体
/// <para>更新外部背调信息。</para>
/// <para>## 注意事项</para>
/// <para>该接口会对原背调内容进行全量覆盖更新。</para>
/// <para>接口ID：7407298680640929795</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-background-info/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_background_check%2fupdate</para>
/// </summary>
public record PutHireV1ExternalBackgroundChecksByExternalBackgroundCheckIdResponseDto
{
    /// <summary>
    /// <para>外部背调</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("external_background_check")]
    public PutHireV1ExternalBackgroundChecksByExternalBackgroundCheckIdResponseDtoExternalBackgroundCheck? ExternalBackgroundCheck { get; set; }

    /// <summary>
    /// <para>外部背调</para>
    /// </summary>
    public record PutHireV1ExternalBackgroundChecksByExternalBackgroundCheckIdResponseDtoExternalBackgroundCheck
    {
        /// <summary>
        /// <para>外部背调 ID，详情可查看：[查询外部背调列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/external_background_check/batch_query)</para>
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
            /// <para>示例值：2827182</para>
            /// </summary>
            [JsonPropertyName("size")]
            public int? Size { get; set; }
        }
    }
}
