// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetApplicationV6ApplicationsByAppIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取应用信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 获取应用信息 响应体
/// <para>根据app_id获取应用的基础信息</para>
/// <para>接口ID：6989432329400238081</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/application/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication%2fget</para>
/// </summary>
public record GetApplicationV6ApplicationsByAppIdResponseDto
{
    /// <summary>
    /// <para>应用数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app")]
    public Application? App { get; set; }

    /// <summary>
    /// <para>应用数据</para>
    /// </summary>
    public record Application
    {
        /// <summary>
        /// <para>应用的 app_id</para>
        /// <para>必填：是</para>
        /// <para>示例值：cli_9b445f5258795107</para>
        /// </summary>
        [JsonPropertyName("app_id")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// <para>应用创建者（所有者）</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_d317f090b7258ad0372aa53963cda70d</para>
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string? CreatorId { get; set; }

        /// <summary>
        /// <para>应用状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：停用状态</item>
        /// <item>1：启用状态</item>
        /// <item>2：未启用状态</item>
        /// <item>3：未知状态</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// <para>应用类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：自建应用</item>
        /// <item>1：应用商店应用</item>
        /// <item>2：个人应用商店应用</item>
        /// <item>3：未知应用类型</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("scene_type")]
        public int? SceneType { get; set; }

        /// <summary>
        /// <para>付费类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：免费</item>
        /// <item>1：付费</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("payment_type")]
        public int? PaymentType { get; set; }

        /// <summary>
        /// <para>安全设置中的重定向 URL</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("redirect_urls")]
        public string[]? RedirectUrls { get; set; }

        /// <summary>
        /// <para>发布在线上的应用版本 ID，若没有则为空</para>
        /// <para>必填：否</para>
        /// <para>示例值：oav_d317f090b7258ad0372aa53963cda70d</para>
        /// </summary>
        [JsonPropertyName("online_version_id")]
        public string? OnlineVersionId { get; set; }

        /// <summary>
        /// <para>在审核中的版本 ID，若没有则为空</para>
        /// <para>必填：否</para>
        /// <para>示例值：oav_d317f090b7258ad0372aa53963cda70d</para>
        /// </summary>
        [JsonPropertyName("unaudit_version_id")]
        public string? UnauditVersionId { get; set; }

        /// <summary>
        /// <para>应用名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：应用名称</para>
        /// </summary>
        [JsonPropertyName("app_name")]
        public string? AppName { get; set; }

        /// <summary>
        /// <para>应用图标 url</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://sf1-ttcdn-tos.pstatp.com/img/avatar/d279000ca4d3f7f6aaff~72x72.jpg</para>
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// <para>应用默认描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：应用描述</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>应用权限列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("scopes")]
        public AppScope[]? Scopes { get; set; }

        /// <summary>
        /// <para>应用权限列表</para>
        /// </summary>
        public record AppScope
        {
            /// <summary>
            /// <para>应用权限</para>
            /// <para>必填：是</para>
            /// <para>示例值：contact:user.base</para>
            /// </summary>
            [JsonPropertyName("scope")]
            public string Scope { get; set; } = string.Empty;

            /// <summary>
            /// <para>应用权限的国际化描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：获取应用信息</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }

            /// <summary>
            /// <para>权限等级描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：普通权限</item>
            /// <item>2：高级权限</item>
            /// <item>3：超敏感权限</item>
            /// <item>0：未知等级</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("level")]
            public int? Level { get; set; }
        }

        /// <summary>
        /// <para>后台主页地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.example.com</para>
        /// </summary>
        [JsonPropertyName("back_home_url")]
        public string? BackHomeUrl { get; set; }

        /// <summary>
        /// <para>应用的国际化信息列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n")]
        public AppI18nInfo[]? I18ns { get; set; }

        /// <summary>
        /// <para>应用的国际化信息列表</para>
        /// </summary>
        public record AppI18nInfo
        {
            /// <summary>
            /// <para>国际化语言的 key</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh_cn</para>
            /// <para>可选值：<list type="bullet">
            /// <item>zh_cn：中文</item>
            /// <item>en_us：英文</item>
            /// <item>ja_jp：日文</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("i18n_key")]
            public string I18nKey { get; set; } = string.Empty;

            /// <summary>
            /// <para>应用国际化名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：应用名称</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>应用国际化描述（副标题）</para>
            /// <para>必填：否</para>
            /// <para>示例值：应用描述</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }

            /// <summary>
            /// <para>国际化帮助文档链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://www.example.com</para>
            /// </summary>
            [JsonPropertyName("help_use")]
            public string? HelpUse { get; set; }
        }

        /// <summary>
        /// <para>应用主语言</para>
        /// <para>必填：否</para>
        /// <para>示例值：zh_cn</para>
        /// <para>可选值：<list type="bullet">
        /// <item>zh_cn：中文</item>
        /// <item>en_us：英文</item>
        /// <item>ja_jp：日文</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("primary_language")]
        public string? PrimaryLanguage { get; set; }

        /// <summary>
        /// <para>应用分类的国际化描述</para>
        /// <para>必填：否</para>
        /// <para>最大长度：3</para>
        /// </summary>
        [JsonPropertyName("common_categories")]
        public string[]? CommonCategories { get; set; }

        /// <summary>
        /// <para>应用的所有者信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("owner")]
        public ApplicationOwner? Owner { get; set; }

        /// <summary>
        /// <para>应用的所有者信息</para>
        /// </summary>
        public record ApplicationOwner
        {
            /// <summary>
            /// <para>应用所有者类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：飞书科技</item>
            /// <item>1：飞书合作伙伴</item>
            /// <item>2：企业内成员</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public int Type { get; set; }

            /// <summary>
            /// <para>应用所有者ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_d317f090b7258ad0372aa53963cda70d</para>
            /// </summary>
            [JsonPropertyName("owner_id")]
            public string? OwnerId { get; set; }

            /// <summary>
            /// <para>应用开发商名称(仅商店应用返回)</para>
            /// <para>必填：否</para>
            /// <para>示例值：testtenant</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>应用开发商服务台链接(仅商店应用返回)</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://applink.feishu.cn/client/helpdesk/open?id=6940534140529803284</para>
            /// </summary>
            [JsonPropertyName("help_desk")]
            public string? HelpDesk { get; set; }

            /// <summary>
            /// <para>应用开发商的邮箱(仅商店应用返回)</para>
            /// <para>必填：否</para>
            /// <para>示例值：test123@163.com</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>应用开发商的手机号(仅商店应用返回)</para>
            /// <para>必填：否</para>
            /// <para>示例值：1234534234234</para>
            /// </summary>
            [JsonPropertyName("phone")]
            public string? Phone { get; set; }
        }
    }
}
