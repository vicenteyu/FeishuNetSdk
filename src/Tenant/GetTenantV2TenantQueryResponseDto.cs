// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetTenantV2TenantQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取企业信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tenant;
/// <summary>
/// 获取企业信息 响应体
/// <para>获取企业名称、企业编号等企业信息</para>
/// <para>接口ID：6954228485356568579</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/tenant-v2/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftenant-v2%2ftenant%2fquery</para>
/// </summary>
public record GetTenantV2TenantQueryResponseDto
{
    /// <summary>
    /// <para>企业信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tenant")]
    public GetTenantV2TenantQueryResponseDtoTenant? Tenant { get; set; }

    /// <summary>
    /// <para>企业信息</para>
    /// </summary>
    public record GetTenantV2TenantQueryResponseDtoTenant
    {
        /// <summary>
        /// <para>企业名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：企业名称</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>企业编号，平台内唯一</para>
        /// <para>必填：是</para>
        /// <para>示例值：F123456789</para>
        /// </summary>
        [JsonPropertyName("display_id")]
        public string DisplayId { get; set; } = string.Empty;

        /// <summary>
        /// <para>个人版/团队版标志</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：团队版</item>
        /// <item>2：个人版</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("tenant_tag")]
        public int TenantTag { get; set; }

        /// <summary>
        /// <para>企业标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：abcdefghi</para>
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string TenantKey { get; set; } = string.Empty;

        /// <summary>
        /// <para>企业头像</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("avatar")]
        public GetTenantV2TenantQueryResponseDtoTenantAvatar Avatar { get; set; } = new();

        /// <summary>
        /// <para>企业头像</para>
        /// </summary>
        public record GetTenantV2TenantQueryResponseDtoTenantAvatar
        {
            /// <summary>
            /// <para>企业头像</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_origin")]
            public string? AvatarOrigin { get; set; }

            /// <summary>
            /// <para>企业头像 72x72</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_72")]
            public string? Avatar72 { get; set; }

            /// <summary>
            /// <para>企业头像 240x240</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_240")]
            public string? Avatar240 { get; set; }

            /// <summary>
            /// <para>企业头像 640x640</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_640")]
            public string? Avatar640 { get; set; }
        }

        /// <summary>
        /// <para>企业完整域名。企业域名可用于企业成员访问管理后台、云文档等含URL地址的网页。</para>
        /// <para>必填：否</para>
        /// <para>示例值：example.feishu.cn</para>
        /// </summary>
        [JsonPropertyName("domain")]
        public string? Domain { get; set; }
    }
}
