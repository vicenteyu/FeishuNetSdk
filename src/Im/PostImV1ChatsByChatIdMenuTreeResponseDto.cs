namespace FeishuNetSdk.Im;
/// <summary>
/// 添加群菜单 响应体
/// <para>该接口用于向群组中添加群菜单。</para>
/// <para>接口ID：7174746098262638596</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-menu_tree/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-menu_tree%2fcreate</para>
/// </summary>
public record PostImV1ChatsByChatIdMenuTreeResponseDto
{
    /// <summary>
    /// <para>追加后群内现有菜单</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("menu_tree")]
    public ChatMenuTree? MenuTree { get; set; }

    /// <summary>
    /// <para>追加后群内现有菜单</para>
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
            /// <para>一级菜单ID</para>
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
                /// <para>**注意**</para>
                /// <para>- 如果一级菜单有二级菜单时，则此一级菜单的值必须为NONE。</para>
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
                    /// <para>公用跳转链接，必须以http开头。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://open.feishu.cn/</para>
                    /// </summary>
                    [JsonPropertyName("common_url")]
                    public string? CommonUrl { get; set; }

                    /// <summary>
                    /// <para>IOS端跳转链接，当该字段不设置时，IOS端会使用common_url。必须以http开头。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://open.feishu.cn/</para>
                    /// </summary>
                    [JsonPropertyName("ios_url")]
                    public string? IosUrl { get; set; }

                    /// <summary>
                    /// <para>Android端跳转链接，当该字段不设置时，Android端会使用common_url。必须以http开头。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://open.feishu.cn/</para>
                    /// </summary>
                    [JsonPropertyName("android_url")]
                    public string? AndroidUrl { get; set; }

                    /// <summary>
                    /// <para>PC端跳转链接，当该字段不设置时，PC端会使用common_url。必须以http开头。在PC端点击群菜单后，如果需要url对应的页面在飞书侧边栏展开，可以在url前加上https://applink.feishu.cn/client/web_url/open?mode=sidebar-semi&amp;url=，比如https://applink.feishu.cn/client/web_url/open?mode=sidebar-semi&amp;url=https://open.feishu.cn/</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://open.feishu.cn/</para>
                    /// </summary>
                    [JsonPropertyName("pc_url")]
                    public string? PcUrl { get; set; }

                    /// <summary>
                    /// <para>Web端跳转链接，当该字段不设置时，Web端会使用common_url。必须以http开头。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://open.feishu.cn/</para>
                    /// </summary>
                    [JsonPropertyName("web_url")]
                    public string? WebUrl { get; set; }
                }

                /// <summary>
                /// <para>图片的key值。通过 [上传图片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/create) 接口上传message类型图片获取image_key</para>
                /// <para>**注意**</para>
                /// <para>- 如果一级菜单有二级菜单，则此一级菜单不能有图标。</para>
                /// <para>必填：否</para>
                /// <para>示例值：img_v2_b0fbe905-7988-4282-b882-82edd010336j</para>
                /// </summary>
                [JsonPropertyName("image_key")]
                public string? ImageKey { get; set; }

                /// <summary>
                /// <para>菜单名称。</para>
                /// <para>**注意**</para>
                /// <para>- 一级、二级菜单名称字符数要在1到120范围内</para>
                /// <para>必填：否</para>
                /// <para>示例值：群聊</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// <para>菜单国际化名称。</para>
                /// <para>**注意**</para>
                /// <para>- 一级、二级菜单名称字符数要在1到120范围内</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("i18n_names")]
                public ChatMenuTopLevelChatMenuItemI18nNames? I18nNames { get; set; }

                /// <summary>
                /// <para>菜单国际化名称。</para>
                /// <para>**注意**</para>
                /// <para>- 一级、二级菜单名称字符数要在1到120范围内</para>
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
                    /// <para>示例值：Signup</para>
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
                /// <para>二级菜单ID</para>
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
                    /// <para>**注意**</para>
                    /// <para>- 如果一级菜单有二级菜单时，则此一级菜单的值必须为NONE。</para>
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
                        /// <para>公用跳转链接，必须以http开头。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://open.feishu.cn/</para>
                        /// </summary>
                        [JsonPropertyName("common_url")]
                        public string? CommonUrl { get; set; }

                        /// <summary>
                        /// <para>IOS端跳转链接，当该字段不设置时，IOS端会使用common_url。必须以http开头。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://open.feishu.cn/</para>
                        /// </summary>
                        [JsonPropertyName("ios_url")]
                        public string? IosUrl { get; set; }

                        /// <summary>
                        /// <para>Android端跳转链接，当该字段不设置时，Android端会使用common_url。必须以http开头。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://open.feishu.cn/</para>
                        /// </summary>
                        [JsonPropertyName("android_url")]
                        public string? AndroidUrl { get; set; }

                        /// <summary>
                        /// <para>PC端跳转链接，当该字段不设置时，PC端会使用common_url。必须以http开头。在PC端点击群菜单后，如果需要url对应的页面在飞书侧边栏展开，可以在url前加上https://applink.feishu.cn/client/web_url/open?mode=sidebar-semi&amp;url=，比如https://applink.feishu.cn/client/web_url/open?mode=sidebar-semi&amp;url=https://open.feishu.cn/</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://open.feishu.cn/</para>
                        /// </summary>
                        [JsonPropertyName("pc_url")]
                        public string? PcUrl { get; set; }

                        /// <summary>
                        /// <para>Web端跳转链接，当该字段不设置时，Web端会使用common_url。必须以http开头。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://open.feishu.cn/</para>
                        /// </summary>
                        [JsonPropertyName("web_url")]
                        public string? WebUrl { get; set; }
                    }

                    /// <summary>
                    /// <para>图片的key值。通过 [上传图片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/create) 接口上传message类型图片获取image_key</para>
                    /// <para>**注意**</para>
                    /// <para>- 如果一级菜单有二级菜单，则此一级菜单不能有图标。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：img_v2_b0fbe905-7988-4282-b882-82edd010336j</para>
                    /// </summary>
                    [JsonPropertyName("image_key")]
                    public string? ImageKey { get; set; }

                    /// <summary>
                    /// <para>菜单名称。</para>
                    /// <para>**注意**</para>
                    /// <para>- 一级、二级菜单名称字符数要在1到120范围内</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：群聊</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }

                    /// <summary>
                    /// <para>菜单国际化名称。</para>
                    /// <para>**注意**</para>
                    /// <para>- 一级、二级菜单名称字符数要在1到120范围内</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("i18n_names")]
                    public ChatMenuSecondLevelChatMenuItemI18nNames? I18nNames { get; set; }

                    /// <summary>
                    /// <para>菜单国际化名称。</para>
                    /// <para>**注意**</para>
                    /// <para>- 一级、二级菜单名称字符数要在1到120范围内</para>
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
                        /// <para>示例值：Signup</para>
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
