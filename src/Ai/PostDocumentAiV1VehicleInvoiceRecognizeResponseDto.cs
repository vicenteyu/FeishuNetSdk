// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDocumentAiV1VehicleInvoiceRecognizeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>识别文件中的机动车发票 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别文件中的机动车发票 响应体
/// <para>机动车发票识别接口，支持JPG/JPEG/PNG/BMP四种文件类型的一次性的识别。</para>
/// <para>接口ID：7319756481343750148</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/ai/document_ai-v1/vehicle_invoice/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fvehicle_invoice%2frecognize</para>
/// </summary>
public record PostDocumentAiV1VehicleInvoiceRecognizeResponseDto
{
    /// <summary>
    /// <para>机动车发票信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("vehicle_invoice")]
    public PostDocumentAiV1VehicleInvoiceRecognizeResponseDtoVehicleInvoice? VehicleInvoice { get; set; }

    /// <summary>
    /// <para>机动车发票信息</para>
    /// </summary>
    public record PostDocumentAiV1VehicleInvoiceRecognizeResponseDtoVehicleInvoice
    {
        /// <summary>
        /// <para>识别出的实体类型</para>
        /// <para>必填：否</para>
        /// <para>最大长度：22</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("entities")]
        public VehicleInvoiceEntity[]? Entities { get; set; }

        /// <summary>
        /// <para>识别出的实体类型</para>
        /// </summary>
        public record VehicleInvoiceEntity
        {
            /// <summary>
            /// <para>识别的字段种类</para>
            /// <para>必填：否</para>
            /// <para>示例值：SalerName</para>
            /// <para>可选值：<list type="bullet">
            /// <item>invoice_code：发票代码</item>
            /// <item>invoice_num：发票号码</item>
            /// <item>date：开票日期</item>
            /// <item>print_code：机打代码</item>
            /// <item>print_num：机打号码</item>
            /// <item>machine_num：机器编码</item>
            /// <item>buyer_name：购买方名称</item>
            /// <item>buyer_id：购买方纳税人识别号</item>
            /// <item>vehicle_type：车辆类型</item>
            /// <item>product_model：厂牌型号</item>
            /// <item>certificate_num：合格证号</item>
            /// <item>engine_num：发动机号码</item>
            /// <item>vin：车架号</item>
            /// <item>total_price：价税合计</item>
            /// <item>total_price_little：小写金额</item>
            /// <item>saler_name：销货单位名称</item>
            /// <item>saler_id：销售方纳税人识别号</item>
            /// <item>saler_addr：地址</item>
            /// <item>tax_rate：税率</item>
            /// <item>tax：税额</item>
            /// <item>price：不含税价格</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>识别出字段的文本信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxx公司</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }
    }
}
