using Newtonsoft.Json;
namespace FeishuNetSdk.Contact;
/// <summary>
/// 通过手机号或邮箱获取用户 ID 请求体
/// <para>通过该接口，可使用手机号/邮箱获取用户的 ID 信息，具体获取支持的 ID 类型包括 open_id、user_id、union_id，可通过查询参数指定。</para>
/// <para>接口ID：7026591401610526724</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/batch_get_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fbatch_get_id</para>
/// </summary>
public record PostContactV3UsersBatchGetIdBodyDto
{
    /// <summary>
    /// <para>要查询的用户邮箱（不支持企业邮箱），最多 50 条。</para>
    /// <para>注意，emails与mobiles相互独立，每条用户邮箱返回对应的用户ID。</para>
    /// <para>本接口返回的用户ID数量为emails数量与mobiles数量的和。</para>
    /// <para>必填：否</para>
    /// <para>示例值：zhangsan@a.com</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonProperty("emails")]
    public string[]? Emails { get; set; }

    /// <summary>
    /// <para>要查询的用户手机号，最多 50 条。</para>
    /// <para>注意</para>
    /// <para>1. emails与mobiles相互独立，每条用户手机号返回对应的用户ID。</para>
    /// <para>2.  非中国大陆地区的手机号需要添加以 “+” 开头的国家 / 地区代码。</para>
    /// <para>必填：否</para>
    /// <para>示例值：13812345678</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonProperty("mobiles")]
    public string[]? Mobiles { get; set; }
}
