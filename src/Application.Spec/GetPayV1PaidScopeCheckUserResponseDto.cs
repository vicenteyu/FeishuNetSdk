using Newtonsoft.Json;
namespace FeishuNetSdk.Application.Spec;
/// <summary>
/// 查询用户是否在应用开通范围 响应体
/// <para>当付费套餐是按人数收费 或者 限制最大使用人数时，开放平台会引导企业管理员设置“付费功能开通范围”。  但是受开通范围限制，部分用户就无法使用对应的付费功能。  可以通过此接口，在付费功能点入口判断是否允许某个用户进入使用。</para>
/// <para>接口ID：6907569742384087042</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/appstore-paid-info/query-a-user's-app-access</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATNwUjLwUDM14CM1ATN</para>
/// </summary>
public record GetPayV1PaidScopeCheckUserResponseDto
{
    /// <summary>
    /// <para>用户是否在开通范围中，"valid" -该用户在开通范围中，"not_in_scope"-该用户不在开通范围中，"no_active_license"-企业未购买任何价格方案或价格方案已过期，"exceeds_maximum_limit"-企业当前配置的付费功能开通范围人数超出限制，需提醒管理员调整</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("status")]
    public string? Status { get; set; }

    /// <summary>
    /// <para>租户当前使用的「价格方案ID」，对应开发者后台中「付费方案配置」中的「价格方案ID」</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("price_plan_id")]
    public string? PricePlanId { get; set; }

    /// <summary>
    /// <para>是否为试用版本，true-是试用版本；false-非试用版本</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("is_trial")]
    public bool? IsTrial { get; set; }

    /// <summary>
    /// <para>租户当前有生效价格方案时表示价格方案的到期时间，为时间unix时间戳</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("service_stop_time")]
    public string? ServiceStopTime { get; set; }
}
