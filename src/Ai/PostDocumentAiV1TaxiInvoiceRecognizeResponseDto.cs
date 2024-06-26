// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDocumentAiV1TaxiInvoiceRecognizeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>识别文件中的出租车发票 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别文件中的出租车发票 响应体
/// <para>出租车发票识别接口，支持JPG/JPEG/PNG/PDF/OFD五种文件类型的一次性的识别。</para>
/// <para>接口ID：7249730096956620803</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/ai/document_ai-v1/taxi_invoice/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2ftaxi_invoice%2frecognize</para>
/// </summary>
public record PostDocumentAiV1TaxiInvoiceRecognizeResponseDto
{
    /// <summary>
    /// <para>出租车票信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("taxi_invoices")]
    public TaxiInvoice[]? TaxiInvoices { get; set; }

    /// <summary>
    /// <para>出租车票信息</para>
    /// </summary>
    public record TaxiInvoice
    {
        /// <summary>
        /// <para>识别出的实体类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("entities")]
        public TaxiEntity[]? Entities { get; set; }

        /// <summary>
        /// <para>识别出的实体类型</para>
        /// </summary>
        public record TaxiEntity
        {
            /// <summary>
            /// <para>识别的字段种类</para>
            /// <para>必填：否</para>
            /// <para>示例值：car_number</para>
            /// <para>可选值：<list type="bullet">
            /// <item>car_number：车号</item>
            /// <item>start_time：上车时间</item>
            /// <item>end_time：下车时间</item>
            /// <item>distance：里程</item>
            /// <item>start_date：日期</item>
            /// <item>total_amount：出租车价格</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>识别出字段的文本信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：BDK6231</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }
    }
}
