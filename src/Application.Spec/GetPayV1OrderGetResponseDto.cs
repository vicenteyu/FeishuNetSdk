namespace FeishuNetSdk.Application.Spec;
/// <summary>
/// 查询订单详情 响应体
/// <para>该接口用于查询某个订单的具体信息</para>
/// <para>接口ID：6907569742384037890</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/appstore-paid-info/query-order-information</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuITNwUjLyUDM14iM1ATN</para>
/// </summary>
public record GetPayV1OrderGetResponseDto
{
    /// <summary>
    /// <para>订单信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary></summary>
    public record OrderSuffix
    {
        /// <summary>
        /// <para>订单ID，唯一标识</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// <para>价格方案ID，唯一标识</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("price_plan_id")]
        public string? PricePlanId { get; set; }

        /// <summary>
        /// <para>价格方案类型 "trial" -试用；"permanent"-一次性付费；"per_year"-企业年付费；"per_month"-企业月付费；"per_seat_per_year"-按人按年付费；"per_seat_per_month"-按人按月付费；"permanent_count"-按次付费；</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("price_plan_type")]
        public string? PricePlanType { get; set; }

        /// <summary>
        /// <para>实际购买人数 仅对price_plan_type为per_seat_per_year和per_seat_per_month 有效</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("seats")]
        public int? Seats { get; set; }

        /// <summary>
        /// <para>购买数量 总是为1</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("buy_count")]
        public int? BuyCount { get; set; }

        /// <summary>
        /// <para>订单创建时间戳</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>订单支付时间戳</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("pay_time")]
        public string? PayTime { get; set; }

        /// <summary>
        /// <para>订单当前状态，"normal" -正常；"refund"-已退款；</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>购买类型，"buy" - 普通购买;"upgrade"-为升级购买(仅price_plan_type 为per_year，per_month，per_seat_per_year，per_seat_per_month时可升级购买);"renew" - 续费购买；</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("buy_type")]
        public string? BuyType { get; set; }

        /// <summary>
        /// <para>源订单ID，当前订单为升级购买时，即buy_type为upgrade时，此字段记录源订单等ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("src_order_id")]
        public string? SrcOrderId { get; set; }

        /// <summary>
        /// <para>升级后的新订单ID，当前订单如果做过升级购买，此字段记录升级购买后生成的新订单ID，当前订单仍然有效</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dst_order_id")]
        public string? DstOrderId { get; set; }

        /// <summary>
        /// <para>订单实际支付金额, 单位分</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("order_pay_price")]
        public int? OrderPayPrice { get; set; }

        /// <summary>
        /// <para>租户唯一标识</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string? TenantKey { get; set; }
    }
}
