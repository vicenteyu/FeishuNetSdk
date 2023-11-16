using Microsoft.VisualBasic;
namespace FeishuNetSdk.Application.Spec;
/// <summary>
/// 查询租户购买的付费方案 响应体
/// <para>该接口用于分页查询应用租户下的已付费订单，每次购买对应一个唯一的订单，订单会记录购买的套餐的相关信息，业务方需要自行处理套餐的有效期和付费方案的升级。</para>
/// <para>&gt; 备注：免费模式的应用不会产生订单，仅收费应用会产生订单 (含免费版)。</para>
/// <para>接口ID：6907569742384988162</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/appstore-paid-info/query-an-app-tenant’s-paid-orders</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuETNwUjLxUDM14SM1ATN</para>
/// </summary>
public record GetPayV1OrderListResponseDto
{
    /// <summary>
    /// <para>总订单数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }

    /// <summary>
    /// <para>是否还有数据，true还有数据，false没有数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>下一页数据的标识，可作为请求下一页数据的参数，当has_more为false时该字段为空</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>订单信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("order_list")]
    public string? OrderList { get; set; }

    /// <summary></summary>
    public record Order
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
        /// <para>价格方案类型 。 可选值包括："trial" -试用；"permanent"-免费；"per_year"-企业年付费；"per_month"-企业月付费；"per_seat_per_year"-按人按年付费；"per_seat_per_month"-按人按月付费；"permanent_count"-按次付费；</para>
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
