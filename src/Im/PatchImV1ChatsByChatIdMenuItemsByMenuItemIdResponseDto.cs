using Newtonsoft.Json;
namespace FeishuNetSdk.Im;
/// <summary>
/// 修改群菜单元信息 响应体
/// <para>修改某个一级菜单或者二级菜单的元信息，包括群菜单的图标、名称、国际化名称和跳转链接。</para>
/// <para>接口ID：7174746098262704132</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-menu_tree/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-menu_item%2fpatch</para>
/// </summary>
public record PatchImV1ChatsByChatIdMenuItemsByMenuItemIdResponseDto
{
    /// <summary>
    /// <para>修改后的菜单元信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("chat_menu_item")]
    public PatchImV1ChatsByChatIdMenuItemsByMenuItemIdResponseDtoChatMenuItem? ChatMenuItem { get; set; }

    /// <summary>
    /// <para>修改后的菜单元信息</para>
    /// </summary>
    public record PatchImV1ChatsByChatIdMenuItemsByMenuItemIdResponseDtoChatMenuItem
    {
        /// <summary>
        /// <para>菜单类型</para>
        /// <para>**注意**</para>
        /// <para>- 如果一级菜单有二级菜单时，则此一级菜单的值必须为NONE。</para>
        /// <para>必填：否</para>
        /// <para>示例值：NONE</para>
        /// <para>可选值：<list type="bullet">
        /// <item>NONE：无类型</item>
        /// <item>REDIRECT_LINK：跳转链接类型</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("action_type")]
        public string? ActionType { get; set; }

        /// <summary>
        /// <para>跳转链接</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("redirect_link")]
        public ChatMenuItemRedirectLink? RedirectLink { get; set; }

        /// <summary>
        /// <para>跳转链接</para>
        /// </summary>
        public record ChatMenuItemRedirectLink
        {
            /// <summary>
            /// <para>公用跳转链接，必须以http开头。</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://open.feishu.cn/</para>
            /// </summary>
            [JsonProperty("common_url")]
            public string? CommonUrl { get; set; }

            /// <summary>
            /// <para>IOS端跳转链接，当该字段不设置时，IOS端会使用common_url。必须以http开头。</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://open.feishu.cn/</para>
            /// </summary>
            [JsonProperty("ios_url")]
            public string? IosUrl { get; set; }

            /// <summary>
            /// <para>Android端跳转链接，当该字段不设置时，Android端会使用common_url。必须以http开头。</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://open.feishu.cn/</para>
            /// </summary>
            [JsonProperty("android_url")]
            public string? AndroidUrl { get; set; }

            /// <summary>
            /// <para>PC端跳转链接，当该字段不设置时，PC端会使用common_url。必须以http开头。在PC端点击群菜单后，如果需要url对应的页面在飞书侧边栏展开，可以在url前加上https://applink.feishu.cn/client/web_url/open?mode=sidebar-semi&amp;url=，比如https://applink.feishu.cn/client/web_url/open?mode=sidebar-semi&amp;url=https://open.feishu.cn/</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://open.feishu.cn/</para>
            /// </summary>
            [JsonProperty("pc_url")]
            public string? PcUrl { get; set; }

            /// <summary>
            /// <para>Web端跳转链接，当该字段不设置时，Web端会使用common_url。必须以http开头。</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://open.feishu.cn/</para>
            /// </summary>
            [JsonProperty("web_url")]
            public string? WebUrl { get; set; }
        }

        /// <summary>
        /// <para>图片的key值。通过 [上传图片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/create) 接口上传message类型图片获取image_key</para>
        /// <para>**注意**</para>
        /// <para>- 如果一级菜单有二级菜单，则此一级菜单不能有图标。</para>
        /// <para>必填：否</para>
        /// <para>示例值：img_v2_b0fbe905-7988-4282-b882-82edd010336j</para>
        /// </summary>
        [JsonProperty("image_key")]
        public string? ImageKey { get; set; }

        /// <summary>
        /// <para>菜单名称。</para>
        /// <para>**注意**</para>
        /// <para>- 一级、二级菜单名称字符数要在1到120范围内</para>
        /// <para>必填：否</para>
        /// <para>示例值：群聊</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>菜单国际化名称。</para>
        /// <para>**注意**</para>
        /// <para>- 一级、二级菜单名称字符数要在1到120范围内</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("i18n_names")]
        public PatchImV1ChatsByChatIdMenuItemsByMenuItemIdResponseDtoChatMenuItemI18nNames? I18nNames { get; set; }

        /// <summary>
        /// <para>菜单国际化名称。</para>
        /// <para>**注意**</para>
        /// <para>- 一级、二级菜单名称字符数要在1到120范围内</para>
        /// </summary>
        public record PatchImV1ChatsByChatIdMenuItemsByMenuItemIdResponseDtoChatMenuItemI18nNames
        {
            /// <summary>
            /// <para>中文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：评审报名</para>
            /// </summary>
            [JsonProperty("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：Signup</para>
            /// </summary>
            [JsonProperty("en_us")]
            public string? EnUs { get; set; }

            /// <summary>
            /// <para>日文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：サインアップ</para>
            /// </summary>
            [JsonProperty("ja_jp")]
            public string? JaJp { get; set; }
        }
    }
}
