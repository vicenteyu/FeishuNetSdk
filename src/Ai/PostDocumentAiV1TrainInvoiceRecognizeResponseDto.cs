namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别文件中的火车票 响应体
/// <para>火车票识别接口，支持JPG/JPEG/PNG/PDF/OFD五种文件类型的一次性的识别。</para>
/// <para>接口ID：7249730096956686339</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/ai/document_ai-v1/train_invoice/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2ftrain_invoice%2frecognize</para>
/// </summary>
public record PostDocumentAiV1TrainInvoiceRecognizeResponseDto
{
    /// <summary>
    /// <para>火车票信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("train_invoices")]
    public TrainInvoice[]? TrainInvoices { get; set; }

    /// <summary>
    /// <para>火车票信息</para>
    /// </summary>
    public record TrainInvoice
    {
        /// <summary>
        /// <para>识别出的实体列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("entities")]
        public TrainEntity[]? Entities { get; set; }

        /// <summary>
        /// <para>识别出的实体列表</para>
        /// </summary>
        public record TrainEntity
        {
            /// <summary>
            /// <para>识别的字段种类</para>
            /// <para>必填：否</para>
            /// <para>示例值：end_station</para>
            /// <para>可选值：<list type="bullet">
            /// <item>start_station：出发站</item>
            /// <item>end_station：到达站</item>
            /// <item>train_num：车次编号</item>
            /// <item>name：火车票姓名</item>
            /// <item>seat_num：座位号</item>
            /// <item>ticket_num：车票编号</item>
            /// <item>total_amount：价格</item>
            /// <item>time：出发时间</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>识别出字段的文本信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：长沙南</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }
    }
}
