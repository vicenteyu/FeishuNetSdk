// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="PatchApplicationV7ApplicationsByAppIdConfigBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新应用开发配置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 更新应用开发配置 请求体
/// <para>通过该接口可更新自建应用的应用的开发配置（通讯录、安全、可见性等），不传入的参数则保持不变，仅针对传入的参数则进行更新。如果应用正在审核中，则无法更新配置</para>
/// <para>接口ID：7621030901518617559</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v7/application-v7/application-config/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v7%2fapplication-v7%2fapplication-config%2fpatch</para>
/// </summary>
public record PatchApplicationV7ApplicationsByAppIdConfigBodyDto
{
    /// <summary>
    /// <para>权限配置[API 权限列表](https://open.feishu.cn/document/ukTMukTMukTM/uYTM5UjL2ETO14iNxkTN/scope-list)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("scope")]
    public AppConfigScope? Scope { get; set; }

    /// <summary>
    /// <para>权限配置[API 权限列表](https://open.feishu.cn/document/ukTMukTMukTM/uYTM5UjL2ETO14iNxkTN/scope-list)</para>
    /// </summary>
    public record AppConfigScope
    {
        /// <summary>
        /// <para>新增权限</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("add_scopes")]
        public AppConfigScopeItem[]? AddScopes { get; set; }

        /// <summary>
        /// <para>新增权限</para>
        /// </summary>
        public record AppConfigScopeItem
        {
            /// <summary>
            /// <para>权限名称</para>
            /// <para>必填：是</para>
            /// <para>示例值：im:message</para>
            /// </summary>
            [JsonPropertyName("scope_name")]
            public string ScopeName { get; set; } = string.Empty;

            /// <summary>
            /// <para>身份类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：tenant</para>
            /// <para>可选值：<list type="bullet">
            /// <item>user：以用户身份申请, 调用API时使用user_access_token</item>
            /// <item>tenant：以应用身份申请, 调用API时使用tenant_access_token</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("token_type")]
            public string TokenType { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>删除权限</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("remove_scopes")]
        public AppConfigScopeItem[]? RemoveScopes { get; set; }
    }

    /// <summary>
    /// <para>事件配置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("event")]
    public AppConfigEvent? Event { get; set; }

    /// <summary>
    /// <para>事件配置</para>
    /// </summary>
    public record AppConfigEvent
    {
        /// <summary>
        /// <para>订阅方式</para>
        /// <para>必填：是</para>
        /// <para>示例值：webhook</para>
        /// <para>可选值：<list type="bullet">
        /// <item>webhook：将事件发送至开发者服务器</item>
        /// <item>websocket：将事件发送至websocket长链接</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("subscription_type")]
        public string SubscriptionType { get; set; } = string.Empty;

        /// <summary>
        /// <para>接收事件的服务器地址，当subscription_type为webhook需要填写</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://open.feishu.cn/</para>
        /// </summary>
        [JsonPropertyName("request_url")]
        public string? RequestUrl { get; set; }

        /// <summary>
        /// <para>添加事件列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("add_events")]
        public string[]? AddEvents { get; set; }

        /// <summary>
        /// <para>删除事件列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("remove_events")]
        public string[]? RemoveEvents { get; set; }
    }

    /// <summary>
    /// <para>安全配置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("security")]
    public AppConfigSecurity? Security { get; set; }

    /// <summary>
    /// <para>安全配置</para>
    /// </summary>
    public record AppConfigSecurity
    {
        /// <summary>
        /// <para>新增项</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("add")]
        public AppConfigSecurityItem? Add { get; set; }

        /// <summary>
        /// <para>新增项</para>
        /// </summary>
        public record AppConfigSecurityItem
        {
            /// <summary>
            /// <para>重定向URL</para>
            /// <para>必填：否</para>
            /// <para>最大长度：300</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("redirect_urls")]
            public string[]? RedirectUrls { get; set; }

            /// <summary>
            /// <para>IP白名单 IP需要填写调用方出口公网IP地址</para>
            /// <para>必填：否</para>
            /// <para>最大长度：300</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("allowed_ips")]
            public string[]? AllowedIps { get; set; }

            /// <summary>
            /// <para>H5可信域名仅可信域名内的 H5 可以访问 JSAPI，部分需要鉴权的 JSAPI 必填。</para>
            /// <para>必填：否</para>
            /// <para>最大长度：300</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("h5_trusted_domains")]
            public string[]? H5TrustedDomains { get; set; }

            /// <summary>
            /// <para>Web-View 可信域名</para>
            /// <para>必填：否</para>
            /// <para>最大长度：300</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("web_view_trusted_domains")]
            public string[]? WebViewTrustedDomains { get; set; }

            /// <summary>
            /// <para>小程序协议名白名单</para>
            /// <para>必填：否</para>
            /// <para>最大长度：20</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("allowed_schemas")]
            public string[]? AllowedSchemas { get; set; }

            /// <summary>
            /// <para>服务器可信域名</para>
            /// <para>必填：否</para>
            /// <para>最大长度：300</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("allowed_server_domains")]
            public string[]? AllowedServerDomains { get; set; }
        }

        /// <summary>
        /// <para>删除列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("remove")]
        public AppConfigSecurityItem? Remove { get; set; }

        /// <summary>
        /// <para>是否允许刷新 user_access_token</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("allow_refresh_token")]
        public bool? AllowRefreshToken { get; set; }
    }

    /// <summary>
    /// <para>可见性范围配置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("visibility")]
    public AppConfigVisibility? Visibility { get; set; }

    /// <summary>
    /// <para>可见性范围配置</para>
    /// </summary>
    public record AppConfigVisibility
    {
        /// <summary>
        /// <para>是否全员可见,false:否;true:是;不填:继续当前状态不改变.如果可见范围为全员后添加的可用人员则无效,禁用人员仍然有效</para>
        /// <para>必填：是</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_visible_to_all")]
        public bool IsVisibleToAll { get; set; }

        /// <summary>
        /// <para>可用人员列表，当is_visible_to_all为true时，visible_list中的参数无效</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("visible_list")]
        public AppVisibilityIdList? VisibleList { get; set; }

        /// <summary>
        /// <para>可用人员列表，当is_visible_to_all为true时，visible_list中的参数无效</para>
        /// </summary>
        public record AppVisibilityIdList
        {
            /// <summary>
            /// <para>成员id列表(open_id/union_id/user_id)</para>
            /// <para>必填：否</para>
            /// <para>最大长度：2000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("user_ids")]
            public string[]? UserIds { get; set; }

            /// <summary>
            /// <para>部门id列表(自定义部门id/open_department_id)</para>
            /// <para>必填：否</para>
            /// <para>最大长度：2000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("department_ids")]
            public string[]? DepartmentIds { get; set; }
        }
    }

    /// <summary>
    /// <para>通讯录权限范围配置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("contacts")]
    public AppConfigContactsRange? Contacts { get; set; }

    /// <summary>
    /// <para>通讯录权限范围配置</para>
    /// </summary>
    public record AppConfigContactsRange
    {
        /// <summary>
        /// <para>更新范围方式</para>
        /// <para>必填：是</para>
        /// <para>示例值：some</para>
        /// <para>可选值：<list type="bullet">
        /// <item>equal_to_availability：和可见性保持一致</item>
        /// <item>some：部分成员</item>
        /// <item>all：全部成员范围</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("contacts_range_type")]
        public string ContactsRangeType { get; set; } = string.Empty;

        /// <summary>
        /// <para>通讯录可用人员列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("visible_list")]
        public AppContactsRangeIdList? VisibleList { get; set; }

        /// <summary>
        /// <para>通讯录可用人员列表</para>
        /// </summary>
        public record AppContactsRangeIdList
        {
            /// <summary>
            /// <para>成员id列表</para>
            /// <para>必填：否</para>
            /// <para>最大长度：2000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("user_ids")]
            public string[]? UserIds { get; set; }

            /// <summary>
            /// <para>部门id列表</para>
            /// <para>必填：否</para>
            /// <para>最大长度：2000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("department_ids")]
            public string[]? DepartmentIds { get; set; }
        }
    }

    /// <summary>
    /// <para>事件与回调加密策略</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("event_and_callback_encrypt_strategy")]
    public EventAndCallbackEncryptStrategySuffix? EventAndCallbackEncryptStrategy { get; set; }

    /// <summary>
    /// <para>事件与回调加密策略</para>
    /// </summary>
    public record EventAndCallbackEncryptStrategySuffix
    {
        /// <summary>
        /// <para>加密key, 配置 Encrypt Key 后，开放平台将向请求地址推送加密后的事件</para>
        /// <para>必填：否</para>
        /// <para>示例值：xE4k2SkQgtbC8jZEviGRxxxxxxxx</para>
        /// <para>最大长度：32</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("encryption_key")]
        public string? EncryptionKey { get; set; }

        /// <summary>
        /// <para>开放平台向应用推送的事件中都带有此 Token，应用可以据此 Token 验证推送的事件是否属于该应用。</para>
        /// <para>必填：否</para>
        /// <para>示例值：lVEjWtBAu6kVIgSLMV3C4fxxxx</para>
        /// <para>最大长度：32</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("verification_token")]
        public string? VerificationToken { get; set; }
    }

    /// <summary>
    /// <para>回调配置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("callback")]
    public AppConfigCallback? Callback { get; set; }

    /// <summary>
    /// <para>回调配置</para>
    /// </summary>
    public record AppConfigCallback
    {
        /// <summary>
        /// <para>回调类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：webhook</para>
        /// <para>可选值：<list type="bullet">
        /// <item>webhook：webhook</item>
        /// <item>websocket：websocket</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("callback_type")]
        public string CallbackType { get; set; } = string.Empty;

        /// <summary>
        /// <para>如果回调是 webhook，webhook 的请求地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://open.feishu.cn/callback</para>
        /// </summary>
        [JsonPropertyName("request_url")]
        public string? RequestUrl { get; set; }

        /// <summary>
        /// <para>添加哪些回调</para>
        /// <para>必填：否</para>
        /// <para>最大长度：50</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("add_callbacks")]
        public string[]? AddCallbacks { get; set; }

        /// <summary>
        /// <para>移除哪些回调</para>
        /// <para>必填：否</para>
        /// <para>最大长度：50</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("remove_callbacks")]
        public string[]? RemoveCallbacks { get; set; }
    }
}
