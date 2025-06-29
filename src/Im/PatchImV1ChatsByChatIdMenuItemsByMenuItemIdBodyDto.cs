// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchImV1ChatsByChatIdMenuItemsByMenuItemIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改群菜单元信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 修改群菜单元信息 请求体
/// <para>修改指定群组内的某个一级菜单或者二级菜单的元信息，包括图标、名称、国际化名称和跳转链接。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 调用当前接口的机器人必须在对应的群组内。</para>
/// <para>## 使用限制</para>
/// <para>- 该接口仅支持群模式为 `group` 的群组，你可以调用[获取群信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/get)接口，在返回结果中查看 `chat_mode` 参数取值是否为 `group`。</para>
/// <para>- 本接口不支持在一级菜单上添加或删除二级菜单。</para>
/// <para>接口ID：7174746098262704132</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-menu_tree/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-menu_item%2fpatch</para>
/// </summary>
public record PatchImV1ChatsByChatIdMenuItemsByMenuItemIdBodyDto
{
    /// <summary>
    /// <para>要修改的元信息</para>
    /// <para>必填：是</para>
    /// <para>示例值：["ICON"]</para>
    /// <para>可选值：<list type="bullet">
    /// <item>ICON：图标</item>
    /// <item>NAME：名称</item>
    /// <item>I18N_NAME：国际化名称</item>
    /// <item>REDIRECT_LINK：跳转链接</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("update_fields")]
    public string[] UpdateFields { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>群菜单的元信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("chat_menu_item")]
    public PatchImV1ChatsByChatIdMenuItemsByMenuItemIdBodyDtoChatMenuItem ChatMenuItem { get; set; } = new();

    /// <summary>
    /// <para>群菜单的元信息</para>
    /// </summary>
    public record PatchImV1ChatsByChatIdMenuItemsByMenuItemIdBodyDtoChatMenuItem
    {
        /// <summary>
        /// <para>菜单类型</para>
        /// <para>**注意**：</para>
        /// <para>- 如果一级菜单有二级菜单，则此一级菜单的值必须为 `NONE`。</para>
        /// <para>- 菜单类型创建后不可更改。</para>
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
        /// <para>图标的 key 值。通过 [上传图片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/create) 接口上传 message 类型图片获取 image_key，并传入该值。</para>
        /// <para>**注意**：如果一级菜单有二级菜单，则此一级菜单不能设置图标。</para>
        /// <para>必填：否</para>
        /// <para>示例值：img_v2_b0fbe905-7988-4282-b882-82edd010336j</para>
        /// </summary>
        [JsonPropertyName("image_key")]
        public string? ImageKey { get; set; }

        /// <summary>
        /// <para>菜单名称</para>
        /// <para>**注意**：一级、二级菜单名称字符数要在 1 ~ 120 范围内。</para>
        /// <para>必填：否</para>
        /// <para>示例值：群聊</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>菜单国际化名称</para>
        /// <para>**注意**：一级、二级菜单名称字符数要在 1 ~ 120 范围内。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_names")]
        public PatchImV1ChatsByChatIdMenuItemsByMenuItemIdBodyDtoChatMenuItemI18nNames? I18nNames { get; set; }

        /// <summary>
        /// <para>菜单国际化名称</para>
        /// <para>**注意**：一级、二级菜单名称字符数要在 1 ~ 120 范围内。</para>
        /// </summary>
        public record PatchImV1ChatsByChatIdMenuItemsByMenuItemIdBodyDtoChatMenuItemI18nNames
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
