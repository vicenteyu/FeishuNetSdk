// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-10-12
// ************************************************************************
// <copyright file="PostPassportV1SessionsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取脱敏的用户登录信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Passport;
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
    /// <para>示例值：[{"create_time":"1644983127","terminal_type":2,"user_id":"47f621ff"},{"create_time":"1644980493","terminal_type":2,"user_id":"47f621ff"}]</para>
    /// </summary>
    [JsonPropertyName("mask_sessions")]
    public MaskSession[]? MaskSessions { get; set; }

    /// <summary>
    /// <para>用户登录信息</para>
    /// </summary>
    public record MaskSession
    {
        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1724233829</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>客户端类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：未知</item>
        /// <item>1：个人电脑</item>
        /// <item>2：浏览器</item>
        /// <item>3：安卓手机</item>
        /// <item>4：Apple手机</item>
        /// <item>5：服务端</item>
        /// <item>6：旧版小程序端</item>
        /// <item>8：其他移动端</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("terminal_type")]
        public int? TerminalType { get; set; }

        /// <summary>
        /// <para>用户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>需要登出的 session 标识符</para>
        /// <para>必填：否</para>
        /// <para>示例值：AAAAAAAAAANll6nQoIAAFA==</para>
        /// </summary>
        [JsonPropertyName("sid")]
        public string? Sid { get; set; }
    }
}
