// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDocumentAiV1BusinessCardRecognizeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>识别文件中的名片 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别文件中的名片 响应体
/// <para>名片识别接口，通过上传 JPG / PNG / PDF 等文件类型进行一次性的名片识别。接口适用于20MB以下的文件，适用于英文、日语的名片。</para>
/// <para>接口ID：7205462689421066244</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/document_ai-v1/business_card/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fbusiness_card%2frecognize</para>
/// </summary>
public record PostDocumentAiV1BusinessCardRecognizeResponseDto
{
    /// <summary>
    /// <para>名片信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("business_cards")]
    public RecognizedEntities[]? BusinessCards { get; set; }

    /// <summary>
    /// <para>名片信息</para>
    /// </summary>
    public record RecognizedEntities
    {
        /// <summary>
        /// <para>识别的实体列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("entities")]
        public RecognizedEntity[]? Entities { get; set; }

        /// <summary>
        /// <para>识别的实体列表</para>
        /// </summary>
        public record RecognizedEntity
        {
            /// <summary>
            /// <para>识别的字段种类</para>
            /// <para>必填：否</para>
            /// <para>示例值：contact_names</para>
            /// <para>可选值：<list type="bullet">
            /// <item>contact_names：联系人名</item>
            /// <item>company_names：公司名</item>
            /// <item>departments：部门</item>
            /// <item>job_titles：职位</item>
            /// <item>emails：邮箱</item>
            /// <item>websites：网站</item>
            /// <item>addresses：地址</item>
            /// <item>mobile_phones：移动电话</item>
            /// <item>work_phones：工作电话</item>
            /// <item>other_phones：其他电话</item>
            /// <item>faxes：传真</item>
            /// </list></para>
            /// <para>默认值：名片中识别出来的人名</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>识别出字段的文本信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }
    }
}
