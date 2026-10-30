// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-10-30
//
// Last Modified By : yxr
// Last Modified On : 2026-10-30
// ************************************************************************
// <copyright file="PostBotV3BotMenuResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建千人千面菜单 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 创建千人千面菜单 响应体
/// <para>为指定用户创建仅其可见的机器人菜单。</para>
/// <para>接口ID：7570924844655640595</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bot-v3/bot_menu/set_bot_menu</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fbot-v3%2fbot_menu%2fset_bot_menu</para>
/// </summary>
public record PostBotV3BotMenuResponseDto
{
    /// <summary>
    /// <para>机器人菜单信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("bot_menu")]
    public BotMenuSuffix? BotMenu { get; set; }

    /// <summary>
    /// <para>机器人菜单信息。</para>
    /// </summary>
    public record BotMenuSuffix
    {
        /// <summary>
        /// <para>机器人菜单 ID。可忽略。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("bot_menu_id")]
        public string? BotMenuId { get; set; }

        /// <summary>
        /// <para>机器人菜单选项列表。最多支持五个选项。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：5</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("bot_menu_items")]
        public BotMenuItem1[]? BotMenuItems { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public record BotMenuItemBase
    {
        /// <summary>
        /// <para>选项默认名称。</para>
        /// <para>必填：是</para>
        /// <para>示例值：测试按钮</para>
        /// <para>最大长度：60</para>
        /// <para>最小长度：2</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>选项的多语言配置。了解支持语种，参考配置卡片多语言。示例配置如下所示： "en_us": "New topic" 数据校验规则：2 ~60 个字符</para>
        /// <para>必填：是</para>
        /// <para>示例值：{ "en_us": "New topic"}</para>
        /// </summary>
        [JsonPropertyName("i18n_name")]
        public I18nLanguage<string> I18nName { get; set; } = new();

        /// <summary>
        /// <para>菜单选项中的前缀图标设置。支持自定义图片或使用图标库中的图标。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("icon")]
        public BotMenuIcon? Icon { get; set; }

        /// <summary>
        /// <para>用户点击菜单项时上报的字段。不可超过 20 字符。（仅字节）</para>
        /// <para>必填：否</para>
        /// <para>示例值：kkk111</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("tag")]
        public string? Tag { get; set; }
    }

    /// <summary>
    /// <para>为当前菜单项配置子菜单项。可参考 bot_menu 字段配置。 注意： - 你需至少为菜单项配置一个动作类型，或选择配置子菜单项。即必须在 behaviors 和 children 参数中选择且只能选择一个传入。 - 一个机器人菜单最多可配置三层菜单选项。总菜单选项数量不可超过 100 项，第一层菜单不可超过五项，第二层菜单不可超过 30 项，第三层菜单不可超过三项。</para>
    /// </summary>
    public record BotMenuItem1 : BotMenuItemBase
    {
        /// <summary>
        /// <para>用户点击菜单项后，执行的动作列表。 注意：你需至少为菜单项配置一个动作类型，或选择配置子菜单项。即必须 behaviors 和 children 参数中选择且只能选择一个传入。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("behaviors")]
        public BotMenuBehavior[]? Behaviors { get; set; }

        /// <summary>
        /// <para>为当前菜单项配置子菜单项。可参考 bot_menu 字段配置。 注意： - 你需至少为菜单项配置一个动作类型，或选择配置子菜单项。即必须在 behaviors 和 children 参数中选择且只能选择一个传入。 - 一个机器人菜单最多可配置三层菜单选项。总菜单选项数量不可超过 100 项，第一层菜单不可超过五项，第二层菜单不可超过 30 项，第三层菜单不可超过三项。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：5</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("children")]
        public BotMenuItem2[]? Childrens { get; set; }
    }

    /// <summary>
    /// <para>为当前菜单项配置子菜单项。可参考 bot_menu 字段配置。 注意： - 你需至少为菜单项配置一个动作类型，或选择配置子菜单项。即必须在 behaviors 和 children 参数中选择且只能选择一个传入。 - 一个机器人菜单最多可配置三层菜单选项。总菜单选项数量不可超过 100 项，第一层菜单不可超过五项，第二层菜单不可超过 30 项，第三层菜单不可超过三项。</para>
    /// </summary>
    public record BotMenuItem2 : BotMenuItemBase
    {
        /// <summary>
        /// <para>用户点击菜单项后，执行的动作列表。 注意：你需至少为菜单项配置一个动作类型，或选择配置子菜单项。即必须 behaviors 和 children 参数中选择且只能选择一个传入。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("behaviors")]
        public BotMenuBehavior[]? Behaviors { get; set; }

        /// <summary>
        /// <para>为当前菜单项配置子菜单项。可参考 bot_menu 字段配置。 注意： - 你需至少为菜单项配置一个动作类型，或选择配置子菜单项。即必须在 behaviors 和 children 参数中选择且只能选择一个传入。 - 一个机器人菜单最多可配置三层菜单选项。总菜单选项数量不可超过 100 项，第一层菜单不可超过五项，第二层菜单不可超过 30 项，第三层菜单不可超过三项。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：5</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("children")]
        public BotMenuItem3[]? Childrens { get; set; }
    }

    /// <summary>
    /// <para>为当前菜单项配置子菜单项。可参考 bot_menu 字段配置。 注意： - 你需至少为菜单项配置一个动作类型，或选择配置子菜单项。即必须在 behaviors 和 children 参数中选择且只能选择一个传入。 - 一个机器人菜单最多可配置三层菜单选项。总菜单选项数量不可超过 100 项，第一层菜单不可超过五项，第二层菜单不可超过 30 项，第三层菜单不可超过三项。</para>
    /// </summary>
    public record BotMenuItem3 : BotMenuItemBase
    {
        /// <summary>
        /// <para>用户点击菜单项后，执行的动作列表。 注意：你需至少为菜单项配置一个动作类型，或选择配置子菜单项。即必须 behaviors 和 children 参数中选择且只能选择一个传入。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("behaviors")]
        public BotMenuBehavior? Behaviors { get; set; }
    }

    /// <summary>
    /// <para>菜单选项中的前缀图标设置。支持自定义图片或使用图标库中的图标。</para>
    /// </summary>
    public record BotMenuIcon
    {
        /// <summary>
        /// <para>图标库中的图标。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("ud_icon")]
        public BotMenuUdIcon? UdIcon { get; set; }

        /// <summary>
        /// <para>自定义图标的图片 key。获取方式：调用上传图片接口，上传用于发送消息的图片，并在返回值中获取图片的 image_key。</para>
        /// <para>必填：否</para>
        /// <para>示例值：img_v3_02xxxxxxxx</para>
        /// </summary>
        [JsonPropertyName("file_key")]
        public string? FileKey { get; set; }
    }

    /// <summary>
    /// <para>图标库中的图标。</para>
    /// </summary>
    public record BotMenuUdIcon
    {
        /// <summary>
        /// <para>图标库中图标的 token。枚举值参见图标库。</para>
        /// <para>必填：否</para>
        /// <para>示例值：add_outlined</para>
        /// </summary>
        [JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// <para>图标的颜色。枚举值参见颜色枚举值。</para>
        /// <para>必填：否</para>
        /// <para>示例值：blue</para>
        /// </summary>
        [JsonPropertyName("color")]
        public string? Color { get; set; }
    }

    /// <summary>
    /// <para>用户点击菜单项后，执行的动作列表。 注意：你需至少为菜单项配置一个动作类型，或选择配置子菜单项。即必须 behaviors 和 children 参数中选择且只能选择一个传入。</para>
    /// </summary>
    public record BotMenuBehavior
    {
        /// <summary>
        /// <para>动作类型。可选值如下所示，支持同时配置以下所有类型。 - target：在客户端内打开链接 - event_key：向注册的事件回调地址发送回调事件 - send_message：将菜单项名称作为消息内容，以用户身份发送到会话中</para>
        /// <para>必填：否</para>
        /// <para>示例值：target</para>
        /// <para>可选值：<list type="bullet">
        /// <item>target：在客户端内打开链接</item>
        /// <item>event_key：向注册的事件回调地址发送回调事件</item>
        /// <item>send_message：将菜单项名称作为消息内容，以用户身份发送到会话中</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>在客户端内打开链接。当 type 为 target 时必填。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("target")]
        public BotMenuRedirectLink? Target { get; set; }

        /// <summary>
        /// <para>向注册的事件回调地址发送事件 key。当用户点击菜单项时，机器人自定义菜单事件（application.bot.menu_v6）将发送给事件订阅者，你可在事件结构体中找到 event_key 的值。当 type 为 event_key 时必填。</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxx</para>
        /// </summary>
        [JsonPropertyName("event_key")]
        public string? EventKey { get; set; }

        /// <summary>
        /// <para>当前动作类型是否是主要类型。当你为一个按钮配置多个动作类型时，你需选择一个动作作为主要类型。 注意： 若当前动作是主要类型，但客户端未能正常处理该动作类型，最终该菜单项将在机器人菜单中隐藏。</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_primary")]
        public bool? IsPrimary { get; set; }
    }

    /// <summary>
    /// <para>在客户端内打开链接。当 type 为 target 时必填。</para>
    /// </summary>
    public record BotMenuRedirectLink
    {
        /// <summary>
        /// <para>默认兜底链接。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.google.com</para>
        /// </summary>
        [JsonPropertyName("common_url")]
        public string? CommonUrl { get; set; }

        /// <summary>
        /// <para>iOS 端打开的链接。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.google.com</para>
        /// </summary>
        [JsonPropertyName("ios_url")]
        public string? IosUrl { get; set; }

        /// <summary>
        /// <para>Android 端打开的链接。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.google.com</para>
        /// </summary>
        [JsonPropertyName("android_url")]
        public string? AndroidUrl { get; set; }

        /// <summary>
        /// <para>PC 端打开的链接。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.google.com</para>
        /// </summary>
        [JsonPropertyName("pc_url")]
        public string? PcUrl { get; set; }

        /// <summary>
        /// <para>客户端为浏览器时打开的链接。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.google.com</para>
        /// </summary>
        [JsonPropertyName("web_url")]
        public string? WebUrl { get; set; }
    }
}
