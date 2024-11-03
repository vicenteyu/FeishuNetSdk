// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1ChatsByChatIdMenuTreeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加群菜单 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 添加群菜单 请求体
/// <para>在指定群组中添加一个或多个群菜单。成功调用后接口会返回当前群组内所有群菜单信息。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 调用当前接口的机器人必须在对应的群组内。</para>
/// <para>## 使用限制</para>
/// <para>- 该接口是向群内追加菜单，群内已存在的菜单不会被覆盖。</para>
/// <para>- 一个群内最多有 3 个一级菜单，每个一级菜单最多配置 5 个二级菜单。</para>
/// <para>- 不支持在已有的一级菜单中追加二级菜单。</para>
/// <para>- 该接口仅支持群模式为 `group` 的群组，你可以调用[获取群信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/get)接口，在返回结果中查看 `chat_mode` 参数取值是否为 `group`。</para>
/// <para>接口ID：7174746098262638596</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-menu_tree/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-menu_tree%2fcreate</para>
/// </summary>
public record PostImV1ChatsByChatIdMenuTreeBodyDto
{
    /// <summary>
    /// <para>要向群内追加的菜单</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("menu_tree")]
    public ChatMenuTree MenuTree { get; set; } = new();

    /// <summary>
    /// <para>要向群内追加的菜单</para>
    /// </summary>
    public record ChatMenuTree
    {
        /// <summary>
        /// <para>一级菜单列表</para>
        /// <para>**注意**：一个群内最多有 3 个一级菜单。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("chat_menu_top_levels")]
        public ChatMenuTopLevel[] ChatMenuTopLevels { get; set; } = Array.Empty<ChatMenuTopLevel>();

        /// <summary>
        /// <para>一级菜单列表</para>
        /// <para>**注意**：一个群内最多有 3 个一级菜单。</para>
        /// </summary>
        public record ChatMenuTopLevel
        {
            /// <summary>
            /// <para>一级菜单信息</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("chat_menu_item")]
            public ChatMenuTopLevelChatMenuItem ChatMenuItem { get; set; } = new();

            /// <summary>
            /// <para>一级菜单信息</para>
            /// </summary>
            public record ChatMenuTopLevelChatMenuItem
            {
                /// <summary>
                /// <para>一级菜单类型</para>
                /// <para>**注意**：如果一级菜单有二级菜单，则此一级菜单的值必须为 `NONE`。</para>
                /// <para>必填：是</para>
                /// <para>示例值：NONE</para>
                /// <para>可选值：<list type="bullet">
                /// <item>NONE：无类型，如果需要在一级菜单内添加二级菜单，则该一级菜单需要设置为 NONE。</item>
                /// <item>REDIRECT_LINK：跳转链接类型，取该值时需要设置对应的跳转链接（redirect_link）。</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("action_type")]
                public string ActionType { get; set; } = string.Empty;

                /// <summary>
                /// <para>一级菜单的跳转链接</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("redirect_link")]
                public ChatMenuItemRedirectLink? RedirectLink { get; set; }

                /// <summary>
                /// <para>一级菜单的跳转链接</para>
                /// </summary>
                public record ChatMenuItemRedirectLink
                {
                    /// <summary>
                    /// <para>公用跳转链接，必须以 http/https 开头。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://open.feishu.cn/</para>
                    /// </summary>
                    [JsonPropertyName("common_url")]
                    public string? CommonUrl { get; set; }

                    /// <summary>
                    /// <para>iOS 端跳转链接，当该字段不设置时，iOS 端默认使用 `common_url` 值。必须以 http/https 开头。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://open.feishu.cn/</para>
                    /// </summary>
                    [JsonPropertyName("ios_url")]
                    public string? IosUrl { get; set; }

                    /// <summary>
                    /// <para>Android 端跳转链接，当该字段不设置时，Android 端默认使用 `common_url` 值。必须以 http/https 开头。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://open.feishu.cn/</para>
                    /// </summary>
                    [JsonPropertyName("android_url")]
                    public string? AndroidUrl { get; set; }

                    /// <summary>
                    /// <para>PC 端跳转链接，当该字段不设置时，PC 端默认使用 `common_url` 值。必须以 http/https 开头。</para>
                    /// <para>**使用说明**：在 PC 端点击群菜单后，如果需要 url 对应的页面在飞书侧边栏展开，可以在 url 前加上 `https://applink.feishu.cn/client/web_url/open?mode=sidebar-semi&amp;url=`，例如 `https://applink.feishu.cn/client/web_url/open?mode=sidebar-semi&amp;url=https://open.feishu.cn/`</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://open.feishu.cn/</para>
                    /// </summary>
                    [JsonPropertyName("pc_url")]
                    public string? PcUrl { get; set; }

                    /// <summary>
                    /// <para>Web 端跳转链接，当该字段不设置时，Web 端默认使用 `common_url` 值。必须以 http/https 开头。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://open.feishu.cn/</para>
                    /// </summary>
                    [JsonPropertyName("web_url")]
                    public string? WebUrl { get; set; }
                }

                /// <summary>
                /// <para>一级菜单图标的 key 值。通过 [上传图片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/create) 接口上传 message 类型图片获取 image_key，并传入该值。</para>
                /// <para>**注意**：如果一级菜单有二级菜单，则此一级菜单不能设置图标。</para>
                /// <para>必填：否</para>
                /// <para>示例值：img_v2_b0fbe905-7988-4282-b882-82edd010336j</para>
                /// </summary>
                [JsonPropertyName("image_key")]
                public string? ImageKey { get; set; }

                /// <summary>
                /// <para>菜单名称</para>
                /// <para>**注意**：一级、二级菜单名称字符数要在 1 ~ 120 范围内。</para>
                /// <para>必填：是</para>
                /// <para>示例值：群聊</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// <para>菜单国际化名称</para>
                /// <para>**注意**：一级、二级菜单名称字符数要在 1 ~ 120 范围内。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("i18n_names")]
                public ChatMenuTopLevelChatMenuItemI18nNames? I18nNames { get; set; }

                /// <summary>
                /// <para>菜单国际化名称</para>
                /// <para>**注意**：一级、二级菜单名称字符数要在 1 ~ 120 范围内。</para>
                /// </summary>
                public record ChatMenuTopLevelChatMenuItemI18nNames
                {
                    /// <summary>
                    /// <para>中文名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：评审报名</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>英文名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Sign up</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }

                    /// <summary>
                    /// <para>日文名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：サインアップ</para>
                    /// </summary>
                    [JsonPropertyName("ja_jp")]
                    public string? JaJp { get; set; }
                }
            }

            /// <summary>
            /// <para>二级菜单列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("children")]
            public ChatMenuSecondLevel[]? Childrens { get; set; }

            /// <summary>
            /// <para>二级菜单列表</para>
            /// </summary>
            public record ChatMenuSecondLevel
            {
                /// <summary>
                /// <para>二级菜单信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("chat_menu_item")]
                public ChatMenuSecondLevelChatMenuItem? ChatMenuItem { get; set; }

                /// <summary>
                /// <para>二级菜单信息</para>
                /// </summary>
                public record ChatMenuSecondLevelChatMenuItem
                {
                    /// <summary>
                    /// <para>二级菜单类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：NONE</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>NONE：无类型</item>
                    /// <item>REDIRECT_LINK：跳转链接类型，取该值时需要设置跳转链接（redirect_link）。</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("action_type")]
                    public string? ActionType { get; set; }

                    /// <summary>
                    /// <para>二级菜单跳转链接</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("redirect_link")]
                    public ChatMenuItemRedirectLink? RedirectLink { get; set; }

                    /// <summary>
                    /// <para>二级菜单跳转链接</para>
                    /// </summary>
                    public record ChatMenuItemRedirectLink
                    {
                        /// <summary>
                        /// <para>公用跳转链接，必须以 http/https 开头。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://open.feishu.cn/</para>
                        /// </summary>
                        [JsonPropertyName("common_url")]
                        public string? CommonUrl { get; set; }

                        /// <summary>
                        /// <para>iOS 端跳转链接，当该字段不设置时，iOS 端默认使用 `common_url` 值。必须以 http/https 开头。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://open.feishu.cn/</para>
                        /// </summary>
                        [JsonPropertyName("ios_url")]
                        public string? IosUrl { get; set; }

                        /// <summary>
                        /// <para>Android 端跳转链接，当该字段不设置时，Android 端默认使用 `common_url` 值。必须以 http/https 开头。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://open.feishu.cn/</para>
                        /// </summary>
                        [JsonPropertyName("android_url")]
                        public string? AndroidUrl { get; set; }

                        /// <summary>
                        /// <para>PC 端跳转链接，当该字段不设置时，PC 端默认使用 `common_url` 值。必须以 http/https 开头。</para>
                        /// <para>**使用说明**：在 PC 端点击群菜单后，如果需要 url 对应的页面在飞书侧边栏展开，可以在 url 前加上 `https://applink.feishu.cn/client/web_url/open?mode=sidebar-semi&amp;url=`，例如 `https://applink.feishu.cn/client/web_url/open?mode=sidebar-semi&amp;url=https://open.feishu.cn/`</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://open.feishu.cn/</para>
                        /// </summary>
                        [JsonPropertyName("pc_url")]
                        public string? PcUrl { get; set; }

                        /// <summary>
                        /// <para>Web 端跳转链接，当该字段不设置时，Web 端默认使用 `common_url` 值。必须以 http/https 开头。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://open.feishu.cn/</para>
                        /// </summary>
                        [JsonPropertyName("web_url")]
                        public string? WebUrl { get; set; }
                    }

                    /// <summary>
                    /// <para>二级菜单图标的 key 值。通过 [上传图片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/create) 接口上传 message 类型图片获取 image_key，并传入该值。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：img_v2_b0fbe905-7988-4282-b882-82edd010336j</para>
                    /// </summary>
                    [JsonPropertyName("image_key")]
                    public string? ImageKey { get; set; }

                    /// <summary>
                    /// <para>菜单名称</para>
                    /// <para>**注意**：一级、二级菜单名称字符数要在 1 ~ 120 范围内</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：群聊</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }

                    /// <summary>
                    /// <para>菜单国际化名称</para>
                    /// <para>**注意**：一级、二级菜单名称字符数要在 1 ~ 120 范围内</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("i18n_names")]
                    public ChatMenuSecondLevelChatMenuItemI18nNames? I18nNames { get; set; }

                    /// <summary>
                    /// <para>菜单国际化名称</para>
                    /// <para>**注意**：一级、二级菜单名称字符数要在 1 ~ 120 范围内</para>
                    /// </summary>
                    public record ChatMenuSecondLevelChatMenuItemI18nNames
                    {
                        /// <summary>
                        /// <para>中文名</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：评审报名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文名</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Sign up</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }

                        /// <summary>
                        /// <para>日文名</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：サインアップ</para>
                        /// </summary>
                        [JsonPropertyName("ja_jp")]
                        public string? JaJp { get; set; }
                    }
                }
            }
        }
    }
}
