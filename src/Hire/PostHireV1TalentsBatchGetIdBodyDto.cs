using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 通过手机号或邮箱获取人才 ID 请求体
/// <para>通过手机号或邮箱获取人才 ID。</para>
/// <para>接口ID：7125370772851458076</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/batch_get_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fbatch_get_id</para>
/// </summary>
public record PostHireV1TalentsBatchGetIdBodyDto
{
    /// <summary>
    /// <para>手机国家区号，默认值：86，即中国大陆地区</para>
    /// <para>必填：否</para>
    /// <para>示例值：86</para>
    /// </summary>
    [JsonProperty("mobile_code")]
    public string? MobileCode { get; set; }

    /// <summary>
    /// <para>手机号，区号均采用 mobile_code 参数的值，最多 100 个</para>
    /// <para>必填：否</para>
    /// <para>示例值：182900291190</para>
    /// </summary>
    [JsonProperty("mobile_number_list")]
    public string[]? MobileNumberList { get; set; }

    /// <summary>
    /// <para>邮箱信息列表，最多 100 个</para>
    /// <para>必填：否</para>
    /// <para>示例值：foo@bytedance.com</para>
    /// </summary>
    [JsonProperty("email_list")]
    public string[]? EmailList { get; set; }

    /// <summary>
    /// <para>证件类型，可参考招聘枚举常量文档下的 IdentificationType 枚举定义</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonProperty("identification_type")]
    public int? IdentificationType { get; set; }

    /// <summary>
    /// <para>证件号</para>
    /// <para>必填：否</para>
    /// <para>示例值：130xxxxxxx</para>
    /// </summary>
    [JsonProperty("identification_number_list")]
    public string[]? IdentificationNumberList { get; set; }
}
