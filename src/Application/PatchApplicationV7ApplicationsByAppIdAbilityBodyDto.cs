// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-07-31
// ************************************************************************
// <copyright file="PatchApplicationV7ApplicationsByAppIdAbilityBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新应用能力配置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 更新应用能力配置 请求体
/// <para>通过该接口可更新自建应用的应用能力（机器人、网页应用等）相关配置，不传入的参数则保持不变，仅针对传入的参数则进行更新。如果应用正在审核中，则无法更新配置</para>
/// <para>接口ID：7621030901518601175</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v7/application-v7/application-ability/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v7%2fapplication-v7%2fapplication-ability%2fpatch</para>
/// </summary>
public record PatchApplicationV7ApplicationsByAppIdAbilityBodyDto
{
    /// <summary>
    /// <para>网页应用</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("web_app")]
    public AppAbilityWeb? WebApp { get; set; }

    /// <summary>
    /// <para>网页应用</para>
    /// </summary>
    public record AppAbilityWeb
    {
        /// <summary>
        /// <para>是否开启网页应用能力</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// <para>PC端链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://open.feishu.cn/</para>
        /// <para>最大长度：512</para>
        /// </summary>
        [JsonPropertyName("pc_url")]
        public string? PcUrl { get; set; }

        /// <summary>
        /// <para>PC端新页面打开方式</para>
        /// <para>必填：否</para>
        /// <para>示例值：new_tab</para>
        /// <para>可选值：<list type="bullet">
        /// <item>new_tab：PC新页面在飞书打开</item>
        /// <item>browser：PC新页面在浏览器打开</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("pc_new_page_open_mode")]
        public string? PcNewPageOpenMode { get; set; }

        /// <summary>
        /// <para>移动端链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://open.feishu.cn/</para>
        /// <para>最大长度：512</para>
        /// </summary>
        [JsonPropertyName("mobile_url")]
        public string? MobileUrl { get; set; }
    }

    /// <summary>
    /// <para>机器人</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("bot")]
    public AppAbilityBot? Bot { get; set; }

    /// <summary>
    /// <para>机器人</para>
    /// </summary>
    public record AppAbilityBot
    {
        /// <summary>
        /// <para>是否开启</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// <para>消息卡片的回调地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://open.feishu.cn</para>
        /// </summary>
        [JsonPropertyName("message_card_callback_url")]
        public string? MessageCardCallbackUrl { get; set; }

        /// <summary>
        /// <para>国际化内容</para>
        /// <para>必填：否</para>
        /// <para>最大长度：200</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("i18ns")]
        public AppAbilityBotI18n[]? I18ns { get; set; }

        /// <summary>
        /// <para>国际化内容</para>
        /// </summary>
        public record AppAbilityBotI18n
        {
            /// <summary>
            /// <para>语种类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh_cn</para>
            /// <para>可选值：<list type="bullet">
            /// <item>zh_cn：中文</item>
            /// <item>en_us：英文</item>
            /// <item>ja_jp：日文</item>
            /// <item>zh_hk：繁体中文(中国香港)</item>
            /// <item>zh_tw：繁体中文(中国台湾)</item>
            /// <item>id_id：印度尼西亚语</item>
            /// <item>ms_my：马来语</item>
            /// <item>de_de：德语</item>
            /// <item>es_es：西班牙语</item>
            /// <item>fr_fr：法语</item>
            /// <item>it_it：意大利语</item>
            /// <item>pt_br：葡萄牙语(巴西)</item>
            /// <item>vi_vn：越南语</item>
            /// <item>ru_ru：俄语</item>
            /// <item>th_th：泰语</item>
            /// <item>ko_kr：韩语</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("i18n_key")]
            public string I18nKey { get; set; } = string.Empty;

            /// <summary>
            /// <para>如何开始使用描述文案</para>
            /// <para>必填：是</para>
            /// <para>示例值：如何使用机器人</para>
            /// <para>最大长度：64</para>
            /// </summary>
            [JsonPropertyName("get_started_desc")]
            public string GetStartedDesc { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>机器人菜单状态是否开启。如果不传，则不处理机器人菜单数据变更。如果该字段为true，bot_menu字段为空列表，返回400</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("bot_menu_enable")]
        public bool? BotMenuEnable { get; set; }

        /// <summary>
        /// <para>机器人菜单选项列表.非悬浮菜单最多支持两级菜单，一级菜单最多3个节点，二级菜单最多5个节点。悬浮菜单最多支持两级菜单，每级菜单最多支持五个节点</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("bot_menus")]
        public BotMenuNode[]? BotMenus { get; set; }

        /// <summary>
        /// <para>机器人菜单选项列表.非悬浮菜单最多支持两级菜单，一级菜单最多3个节点，二级菜单最多5个节点。悬浮菜单最多支持两级菜单，每级菜单最多支持五个节点</para>
        /// </summary>
        public record BotMenuNode
        {
            /// <summary>
            /// <para>节点唯一标识，同一次请求内唯一</para>
            /// <para>必填：否</para>
            /// <para>示例值：menu_1</para>
            /// <para>最大长度：128</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("menu_id")]
            public string? MenuId { get; set; }

            /// <summary>
            /// <para>父节点 menu_id，为空表示一级菜单</para>
            /// <para>必填：否</para>
            /// <para>示例值：menu_parent</para>
            /// <para>最大长度：128</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("parent_menu_id")]
            public string? ParentMenuId { get; set; }

            /// <summary>
            /// <para>同层级内排序，数值越小越靠前</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>最大值：999999</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("sort")]
            public int? Sort { get; set; }

            /// <summary>
            /// <para>默认名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：菜单名称</para>
            /// <para>最大长度：60</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("default_name")]
            public string? DefaultName { get; set; }

            /// <summary>
            /// <para>国际化名称配置。了解支持语种，参考配置卡片多语言。</para>
            /// <para>必填：否</para>
            /// <para>示例值："en_us": "New topic"</para>
            /// </summary>
            [JsonPropertyName("i18n_name")]
            public object? I18nName { get; set; }

            /// <summary>
            /// <para>在客户端内打开链接。当 menu_content_type = 1 时必填。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("redirect_link")]
            public BotMenuRedirectLink? RedirectLink { get; set; }

            /// <summary>
            /// <para>在客户端内打开链接。当 menu_content_type = 1 时必填。</para>
            /// </summary>
            public record BotMenuRedirectLink
            {
                /// <summary>
                /// <para>pc端链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：http://xxx</para>
                /// </summary>
                [JsonPropertyName("pc_url")]
                public string? PcUrl { get; set; }

                /// <summary>
                /// <para>移动端链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：xxx</para>
                /// </summary>
                [JsonPropertyName("mobile_url")]
                public string? MobileUrl { get; set; }
            }

            /// <summary>
            /// <para>向注册的事件回调地址发送事件 key。当用户点击菜单项时，机器人自定义菜单事件（application.bot.menu_v6）将发送给事件订阅者，你可在事件结构体中找到 event_key 的值。当 menu_content_type = 2时必填。</para>
            /// <para>必填：否</para>
            /// <para>示例值：event_key</para>
            /// <para>最大长度：256</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("event_key")]
            public string? EventKey { get; set; }

            /// <summary>
            /// <para>用于自定义icon,自定义图标的图片 key。获取方式：调用上传图片接口，上传用于发送消息的图片，并在返回值中获取图片的 image_key。</para>
            /// <para>必填：否</para>
            /// <para>示例值：file_key</para>
            /// <para>最大长度：256</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("icon_file_key")]
            public string? IconFileKey { get; set; }

            /// <summary>
            /// <para>图标库中的图标。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("ud_icon")]
            public BotMenuUdIcon? UdIcon { get; set; }

            /// <summary>
            /// <para>图标库中的图标。</para>
            /// </summary>
            public record BotMenuUdIcon
            {
                /// <summary>
                /// <para>图标库中图标的 token。枚举值参见图标库。</para>
                /// <para>必填：否</para>
                /// <para>示例值：xxx</para>
                /// </summary>
                [JsonPropertyName("token")]
                public string? Token { get; set; }

                /// <summary>
                /// <para>图标的颜色。枚举值参见颜色枚举值。</para>
                /// <para>必填：否</para>
                /// <para>示例值：xxx</para>
                /// </summary>
                [JsonPropertyName("color")]
                public string? Color { get; set; }
            }

            /// <summary>
            /// <para>菜单响应动作类型.0:未知，1：跳转链接，2：事件通知，3展开子菜单，4：发消息</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：未知</item>
            /// <item>1：跳转链接</item>
            /// <item>2：事件</item>
            /// <item>3：展开子菜单</item>
            /// <item>4：发送消息</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("menu_content_type")]
            public int? MenuContentType { get; set; }
        }

        /// <summary>
        /// <para>菜单展示类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：未知，不推荐用</item>
        /// <item>1：可切换菜单-默认展示菜单</item>
        /// <item>2：可切换菜单-默认展示输入框</item>
        /// <item>3：悬浮菜单</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("bot_menu_display_strategy")]
        public int? BotMenuDisplayStrategy { get; set; }

        /// <summary>
        /// <para>是否允许被其他应用邀请进群</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("allow_invited_to_group_by_other_app_switch_open")]
        public bool? AllowInvitedToGroupByOtherAppSwitchOpen { get; set; }
    }
}
