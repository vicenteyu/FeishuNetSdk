// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetImV1ChatsByChatIdMenuTreeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取群菜单 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 获取群菜单 响应体
/// <para>获取指定群组内的群菜单信息，包括所有一级或二级菜单的名称、跳转链接、图标等信息。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 调用当前接口的机器人必须在对应的群组内。</para>
/// <para>## 使用限制</para>
/// <para>该接口仅支持群模式为 `group` 的群组，你可以调用[获取群信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/get)接口，在返回结果中查看 `chat_mode` 参数取值是否为 `group`。</para>
/// <para>接口ID：7174746098262671364</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-menu_tree/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-menu_tree%2fget</para>
/// </summary>
public record GetImV1ChatsByChatIdMenuTreeResponseDto
{
    /// <summary>
    /// <para>群内所有菜单的信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("menu_tree")]
    public ChatMenuTree? MenuTree { get; set; }

    /// <summary>
    /// <para>群内所有菜单的信息</para>
    /// </summary>
    public record ChatMenuTree
    {
        /// <summary>
        /// <para>一级菜单列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("chat_menu_top_levels")]
        public ChatMenuTopLevel[]? ChatMenuTopLevels { get; set; }

        /// <summary>
        /// <para>一级菜单列表</para>
        /// </summary>
        public record ChatMenuTopLevel
        {
            /// <summary>
            /// <para>一级菜单 ID。删除、修改、排序等群菜单管理操作均需要使用菜单 ID。</para>
            /// <para>必填：否</para>
            /// <para>示例值：7117116451961487361</para>
            /// </summary>
            [JsonPropertyName("chat_menu_top_level_id")]
            public string? ChatMenuTopLevelId { get; set; }

            /// <summary>
            /// <para>一级菜单信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("chat_menu_item")]
            public ChatMenuTopLevelChatMenuItem? ChatMenuItem { get; set; }

            /// <summary>
            /// <para>一级菜单信息</para>
            /// </summary>
            public record ChatMenuTopLevelChatMenuItem
            {
                /// <summary>
                /// <para>菜单类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：NONE</para>
                /// <para>可选值：<list type="bullet">
                /// <item>NONE：无类型，当一级菜单下有二级菜单时，类型取值为 NONE。</item>
                /// <item>REDIRECT_LINK：跳转链接类型</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("action_type")]
                public string? ActionType { get; set; }

                /// <summary>
                /// <para>跳转链接</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("redirect_link")]
                public ChatMenuItemRedirectLink? RedirectLink { get; set; }

                /// <summary>
                /// <para>跳转链接</para>
                /// </summary>
                public record ChatMenuItemRedirectLink
                {
                    /// <summary>
                    /// <para>公用跳转链接</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://open.feishu.cn/</para>
                    /// </summary>
                    [JsonPropertyName("common_url")]
                    public string? CommonUrl { get; set; }

                    /// <summary>
                    /// <para>iOS 端跳转链接，当该字段不设置时，iOS 端默认使用 `common_url` 值。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://open.feishu.cn/</para>
                    /// </summary>
                    [JsonPropertyName("ios_url")]
                    public string? IosUrl { get; set; }

                    /// <summary>
                    /// <para>Android 端跳转链接，当该字段不设置时，Android 端默认使用 `common_url` 值。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://open.feishu.cn/</para>
                    /// </summary>
                    [JsonPropertyName("android_url")]
                    public string? AndroidUrl { get; set; }

                    /// <summary>
                    /// <para>PC 端跳转链接，当该字段不设置时，PC 端默认使用 `common_url` 值。</para>
                    /// <para>**说明**：以 `https://applink.feishu.cn/client/web_url/open?mode=sidebar-semi&amp;url=` 开头的链接表示在飞书侧边栏展开。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://open.feishu.cn/</para>
                    /// </summary>
                    [JsonPropertyName("pc_url")]
                    public string? PcUrl { get; set; }

                    /// <summary>
                    /// <para>Web 端跳转链接，当该字段不设置时，Web 端默认使用 `common_url` 值。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://open.feishu.cn/</para>
                    /// </summary>
                    [JsonPropertyName("web_url")]
                    public string? WebUrl { get; set; }
                }

                /// <summary>
                /// <para>图标的 key 值。通过[下载图片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/get)接口可将图标下载到本地（只能下载由当前机器人上传的图片）。</para>
                /// <para>**注意**：一级菜单下存在二级菜单时不能设置图标。</para>
                /// <para>必填：否</para>
                /// <para>示例值：img_v2_b0fbe905-7988-4282-b882-82edd010336j</para>
                /// </summary>
                [JsonPropertyName("image_key")]
                public string? ImageKey { get; set; }

                /// <summary>
                /// <para>菜单名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：评审报名</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// <para>菜单国际化名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("i18n_names")]
                public ChatMenuTopLevelChatMenuItemI18nNames? I18nNames { get; set; }

                /// <summary>
                /// <para>菜单国际化名称</para>
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
                /// <para>二级菜单 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：7039638308221468675</para>
                /// </summary>
                [JsonPropertyName("chat_menu_second_level_id")]
                public string? ChatMenuSecondLevelId { get; set; }

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
                    /// <para>菜单类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：NONE</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>NONE：无类型</item>
                    /// <item>REDIRECT_LINK：跳转链接类型</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("action_type")]
                    public string? ActionType { get; set; }

                    /// <summary>
                    /// <para>跳转链接</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("redirect_link")]
                    public ChatMenuItemRedirectLink? RedirectLink { get; set; }

                    /// <summary>
                    /// <para>跳转链接</para>
                    /// </summary>
                    public record ChatMenuItemRedirectLink
                    {
                        /// <summary>
                        /// <para>公用跳转链接</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://open.feishu.cn/</para>
                        /// </summary>
                        [JsonPropertyName("common_url")]
                        public string? CommonUrl { get; set; }

                        /// <summary>
                        /// <para>iOS 端跳转链接，当该字段不设置时，iOS 端默认使用 `common_url` 值。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://open.feishu.cn/</para>
                        /// </summary>
                        [JsonPropertyName("ios_url")]
                        public string? IosUrl { get; set; }

                        /// <summary>
                        /// <para>Android 端跳转链接，当该字段不设置时，Android 端默认使用 `common_url` 值。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://open.feishu.cn/</para>
                        /// </summary>
                        [JsonPropertyName("android_url")]
                        public string? AndroidUrl { get; set; }

                        /// <summary>
                        /// <para>PC 端跳转链接，当该字段不设置时，PC 端默认使用 `common_url` 值。</para>
                        /// <para>**说明**：以 `https://applink.feishu.cn/client/web_url/open?mode=sidebar-semi&amp;url=` 开头的链接表示在飞书侧边栏展开。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://open.feishu.cn/</para>
                        /// </summary>
                        [JsonPropertyName("pc_url")]
                        public string? PcUrl { get; set; }

                        /// <summary>
                        /// <para>Web 端跳转链接，当该字段不设置时，Web 端默认使用 `common_url` 值。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://open.feishu.cn/</para>
                        /// </summary>
                        [JsonPropertyName("web_url")]
                        public string? WebUrl { get; set; }
                    }

                    /// <summary>
                    /// <para>图标的 key 值。通过[下载图片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/get)接口可将图标下载到本地（只能下载由当前机器人上传的图片）。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：img_v2_b0fbe905-7988-4282-b882-82edd010336j</para>
                    /// </summary>
                    [JsonPropertyName("image_key")]
                    public string? ImageKey { get; set; }

                    /// <summary>
                    /// <para>菜单名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：评审报名</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }

                    /// <summary>
                    /// <para>菜单国际化名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("i18n_names")]
                    public ChatMenuSecondLevelChatMenuItemI18nNames? I18nNames { get; set; }

                    /// <summary>
                    /// <para>菜单国际化名称</para>
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
