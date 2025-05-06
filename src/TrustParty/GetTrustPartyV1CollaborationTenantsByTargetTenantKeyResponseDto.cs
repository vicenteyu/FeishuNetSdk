// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-06
//
// Last Modified By : yxr
// Last Modified On : 2025-05-06
// ************************************************************************
// <copyright file="GetTrustPartyV1CollaborationTenantsByTargetTenantKeyResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取关联组织详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.TrustParty;
/// <summary>
/// 获取关联组织详情 响应体
/// <para>基于组织tenant key获取关联组织详情，需要对对方组织有可见权限才可以获取。</para>
/// <para>## 提示</para>
/// <para>使用 user_access_token 时，按照 admin 管理后台关联组织列表中针对用户设置的可见性规则进行校验，使用 tenant_access_token 时，按照应用互通界面中针对应用设置的可见性规则进行校验。</para>
/// <para>接口ID：7442539768884690972</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/-collaboraiton-organization/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftrust_party-v1%2fcollaboration_tenant%2fget</para>
/// </summary>
public record GetTrustPartyV1CollaborationTenantsByTargetTenantKeyResponseDto
{
    /// <summary>
    /// <para>对方关联组织详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("target_tenant")]
    public CollaborationTenant? TargetTenant { get; set; }

    /// <summary>
    /// <para>对方关联组织详情</para>
    /// </summary>
    public record CollaborationTenant
    {
        /// <summary>
        /// <para>关联组织的租户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：abcd</para>
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string? TenantKey { get; set; }

        /// <summary>
        /// <para>目标组织的名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("tenant_name")]
        public string? TenantName { get; set; }

        /// <summary>
        /// <para>目标组织的i18n名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_tenant_name")]
        public I18nName? I18nTenantName { get; set; }

        /// <summary>
        /// <para>目标组织的i18n名称</para>
        /// </summary>
        public record I18nName
        {
            /// <summary>
            /// <para>中文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn_name</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>日文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：ja_jp_name</para>
            /// </summary>
            [JsonPropertyName("ja_jp")]
            public string? JaJp { get; set; }

            /// <summary>
            /// <para>英文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：en_name</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>目标组织的简称</para>
        /// <para>必填：否</para>
        /// <para>示例值：tenant_short_name</para>
        /// </summary>
        [JsonPropertyName("tenant_short_name")]
        public string? TenantShortName { get; set; }

        /// <summary>
        /// <para>目标组织的i18n简称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_tenant_short_name")]
        public I18nName? I18nTenantShortName { get; set; }

        /// <summary>
        /// <para>关联时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1671107493</para>
        /// </summary>
        [JsonPropertyName("connect_time")]
        public int? ConnectTime { get; set; }

        /// <summary>
        /// <para>标签</para>
        /// <para>必填：否</para>
        /// <para>示例值：协作</para>
        /// </summary>
        [JsonPropertyName("tenant_tag")]
        public string? TenantTag { get; set; }

        /// <summary>
        /// <para>i18n标签</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_tenant_tag")]
        public I18nName? I18nTenantTag { get; set; }

        /// <summary>
        /// <para>组织icon信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("avatar")]
        public AvatarInfo? Avatar { get; set; }

        /// <summary>
        /// <para>组织icon信息</para>
        /// </summary>
        public record AvatarInfo
        {
            /// <summary>
            /// <para>72*72像素头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_72")]
            public string? Avatar72 { get; set; }

            /// <summary>
            /// <para>240*240像素头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_240")]
            public string? Avatar240 { get; set; }

            /// <summary>
            /// <para>640*640像素头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_640")]
            public string? Avatar640 { get; set; }

            /// <summary>
            /// <para>原始头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_origin")]
            public string? AvatarOrigin { get; set; }
        }

        /// <summary>
        /// <para>组织品牌</para>
        /// <para>必填：否</para>
        /// <para>示例值：feishu</para>
        /// </summary>
        [JsonPropertyName("brand")]
        public string? Brand { get; set; }
    }
}
