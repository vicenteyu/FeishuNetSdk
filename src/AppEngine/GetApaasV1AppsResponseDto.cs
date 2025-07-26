// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-07-26
// ************************************************************************
// <copyright file="GetApaasV1AppsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查看应用基本信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 查看应用基本信息 响应体
/// <para>获取企业下应用基本信息，如应用名称 、应用命名空间等。</para>
/// <para>接口ID：7483060846336999428</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/app/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapp%2flist</para>
/// </summary>
public record GetApaasV1AppsResponseDto : IPageableResponse<GetApaasV1AppsResponseDto.App>
{
    /// <summary>
    /// <para>应用基本信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public App[]? Items { get; set; }

    /// <summary>
    /// <para>应用基本信息列表</para>
    /// </summary>
    public record App
    {
        /// <summary>
        /// <para>aPaaS 产品应用的名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[]? Names { get; set; }

        /// <summary>
        /// <para>aPaaS 产品应用的名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>语种</para>
            /// <para>必填：否</para>
            /// <para>示例值：2052</para>
            /// </summary>
            [JsonPropertyName("language_code")]
            public string? LanguageCode { get; set; }

            /// <summary>
            /// <para>文本</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试应用</para>
            /// </summary>
            [JsonPropertyName("text")]
            public string? Text { get; set; }
        }

        /// <summary>
        /// <para>aPaaS 产品应用的命名空间</para>
        /// <para>必填：否</para>
        /// <para>示例值：package_35f605__c</para>
        /// </summary>
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// <para>aPaaS 产品应用的创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1736480945563</para>
        /// <para>最大值：99999999999999999</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>aPaaS 产品应用的创建者</para>
        /// <para>必填：否</para>
        /// <para>示例值：1818624575806604</para>
        /// <para>最大值：99999999999999999</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("creator")]
        public long? Creator { get; set; }

        /// <summary>
        /// <para>aPaaS 产品应用的所有者</para>
        /// <para>必填：否</para>
        /// <para>示例值：1818624575806604</para>
        /// <para>最大值：99999999999999999</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("owner")]
        public long? Owner { get; set; }

        /// <summary>
        /// <para>aPaaS 产品应用的状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：enabled</para>
        /// <para>可选值：<list type="bullet">
        /// <item>pending_launch：应用待发布</item>
        /// <item>enabled：应用已发布</item>
        /// <item>disabled：应用已停用</item>
        /// <item>stopped：应用已停服</item>
        /// <item>unspecified：应用状态未确定</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>aPaaS 产品应用的成员管理信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("app_roles_info")]
        public AppAppRolesInfo? AppRolesInfo { get; set; }

        /// <summary>
        /// <para>aPaaS 产品应用的成员管理信息</para>
        /// </summary>
        public record AppAppRolesInfo
        {
            /// <summary>
            /// <para>aPaaS 产品应用管理员的 ID</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("admins")]
            public long[]? Admins { get; set; }

            /// <summary>
            /// <para>aPaaS 产品应用开发者的 ID</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("developers")]
            public long[]? Developers { get; set; }

            /// <summary>
            /// <para>aPaaS 产品应用测试人员的 ID</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("test_users")]
            public long[]? TestUsers { get; set; }

            /// <summary>
            /// <para>aPaaS 产品应用数据管理员的 ID</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("data_admins")]
            public long[]? DataAdmins { get; set; }
        }

        /// <summary>
        /// <para>aPaaS 产品应用的图标</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://ae.feishu.cn/img/namespaces/_global/download/namespace_8aed421832fa4586968596f70e6eaebd_p.jpg</para>
        /// </summary>
        [JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// <para>aPaaS 产品应用的描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public I18n[]? Descriptions { get; set; }

        /// <summary>
        /// <para>aPaaS 产品应用的类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：custom</para>
        /// <para>可选值：<list type="bullet">
        /// <item>custom：自建应用</item>
        /// <item>client_isv_saas：来自服务商的 SaaS 应用</item>
        /// <item>client_isv_project：来自服务商的项目制应用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>aPaaS 产品应用的启用状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：enabled</para>
        /// <para>可选值：<list type="bullet">
        /// <item>enabled：启用</item>
        /// <item>disabled：停用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("enable_status")]
        public string? EnableStatus { get; set; }

        /// <summary>
        /// <para>aPaaS 产品应用的发布状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：released</para>
        /// <para>可选值：<list type="bullet">
        /// <item>released：已发布</item>
        /// <item>unreleased：未发布</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("release_status")]
        public string? ReleaseStatus { get; set; }

        /// <summary>
        /// <para>aPaaS 产品应用的服务状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：available</para>
        /// <para>可选值：<list type="bullet">
        /// <item>available：可用</item>
        /// <item>unavailable：不可用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("service_status")]
        public string? ServiceStatus { get; set; }

        /// <summary>
        /// <para>aPaaS 产品应用的停服原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：entitlement_expire</para>
        /// <para>可选值：<list type="bullet">
        /// <item>from_isv：ISV服务商停服</item>
        /// <item>entitlement_expire：企业权益到期停服</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("service_unavailable_reason")]
        public string? ServiceUnavailableReason { get; set; }

        /// <summary>
        /// <para>aPaaS 产品应用的版本</para>
        /// <para>必填：否</para>
        /// <para>示例值：paid</para>
        /// <para>可选值：<list type="bullet">
        /// <item>paid：付费版</item>
        /// <item>free：免费版</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("feature_set")]
        public string? FeatureSet { get; set; }

        /// <summary>
        /// <para>aPaaS 产品应用的计费方式</para>
        /// <para>必填：否</para>
        /// <para>示例值：per_user_per_app</para>
        /// <para>可选值：<list type="bullet">
        /// <item>per_user_per_app：应用席位计费</item>
        /// <item>per_user：不限应用席位计费</item>
        /// <item>independent：独立计费</item>
        /// <item>free：免费</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("charge_mode")]
        public string? ChargeMode { get; set; }

        /// <summary>
        /// <para>aPaaS 产品应用的服务商信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("isv_tenant")]
        public ClientIsvTenant? IsvTenant { get; set; }

        /// <summary>
        /// <para>aPaaS 产品应用的服务商信息</para>
        /// </summary>
        public record ClientIsvTenant
        {
            /// <summary>
            /// <para>服务商ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：798456</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>服务商名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：北京飞书科技有限公司</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
