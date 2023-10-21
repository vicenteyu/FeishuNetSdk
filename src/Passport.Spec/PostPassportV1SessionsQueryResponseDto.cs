using Newtonsoft.Json;
namespace FeishuNetSdk.Passport.Spec;
/// <summary>
/// 批量获取脱敏的用户登录信息 响应体
/// <para>该接口用于查询用户的登录信息。</para>
/// <para>接口ID：7096084771490578433</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/login-state-management/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpassport-v1%2fsession%2fquery</para>
/// </summary>
public record PostPassportV1SessionsQueryResponseDto
{
    /// <summary>
    /// <para>用户登录信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("mask_sessions")]
    public MaskSession[]? MaskSessions { get; set; }

    public record MaskSession
    {
        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>客户端类型</para>
        /// <para>**可选值有**：</para>
        /// <para>0:未知,1:个人电脑,2:浏览器,3:安卓手机,4:Apple手机,5:服务端</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：未知</item>
        /// <item>1：个人电脑</item>
        /// <item>2：浏览器</item>
        /// <item>3：安卓手机</item>
        /// <item>4：Apple手机</item>
        /// <item>5：服务端</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("terminal_type")]
        public int? TerminalType { get; set; }

        /// <summary>
        /// <para>用户ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }
    }
}
