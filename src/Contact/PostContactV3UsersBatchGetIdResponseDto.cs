using Newtonsoft.Json;
namespace FeishuNetSdk.Contact;
/// <summary>
/// 通过手机号或邮箱获取用户 ID 响应体
/// <para>通过该接口，可使用手机号/邮箱获取用户的 ID 信息，具体获取支持的 ID 类型包括 open_id、user_id、union_id，可通过查询参数指定。</para>
/// <para>接口ID：7026591401610526724</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/batch_get_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fbatch_get_id</para>
/// </summary>
public record PostContactV3UsersBatchGetIdResponseDto
{
    /// <summary>
    /// <para>手机号或者邮箱对应的用户id信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user_list")]
    public UserContactInfo[]? UserLists { get; set; }

    /// <summary>
    /// <para>手机号或者邮箱对应的用户id信息</para>
    /// </summary>
    public record UserContactInfo
    {
        /// <summary>
        /// <para>用户id，值为user_id_type所指定的类型。如果查询的手机号、邮箱不存在，或者无权限查看对应的用户，则不返回此项。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_979112345678741d29069abcdef089d4</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>手机号，通过手机号查询时返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：13812345678</para>
        /// </summary>
        [JsonProperty("mobile")]
        public string? Mobile { get; set; }

        /// <summary>
        /// <para>邮箱，通过邮箱查询时返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：lisi@z.com</para>
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; }
    }
}
