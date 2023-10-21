using Newtonsoft.Json;
namespace FeishuNetSdk.Tenant.Spec;
/// <summary>
/// 获取企业信息 响应体
/// <para>获取企业名称、企业编号等企业信息{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=tenant&version=v2&resource=tenant&method=query)</para>
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
    [JsonProperty("tenant")]
    public TenantSuffix? Tenant { get; set; }

    public record TenantSuffix
    {
        /// <summary>
        /// <para>企业名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>企业编号，平台内唯一</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("display_id")]
        public string? DisplayId { get; set; }

        /// <summary>
        /// <para>个人版/团队版标志</para>
        /// <para>**可选值有**：</para>
        /// <para>0:团队版,2:个人版</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：团队版</item>
        /// <item>2：个人版</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("tenant_tag")]
        public int? TenantTag { get; set; }

        /// <summary>
        /// <para>企业标识</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("tenant_key")]
        public string? TenantKey { get; set; }

        /// <summary>
        /// <para>企业头像</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("avatar")]
        public AvatarSuffix? Avatar { get; set; }

        public record AvatarSuffix
        {
            /// <summary>
            /// <para>企业头像</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("avatar_origin")]
            public string? AvatarOrigin { get; set; }

            /// <summary>
            /// <para>企业头像 72x72</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("avatar_72")]
            public string? Avatar72 { get; set; }

            /// <summary>
            /// <para>企业头像 240x240</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("avatar_240")]
            public string? Avatar240 { get; set; }

            /// <summary>
            /// <para>企业头像 640x640</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("avatar_640")]
            public string? Avatar640 { get; set; }
        }
    }
}
