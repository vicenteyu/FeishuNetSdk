// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="ElementsCardDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>卡片内容</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 卡片内容
    /// </summary>
    public record ElementsCardDto : MessageCard
    {
        /// <summary>
        /// 卡片标题
        /// </summary>
        [JsonPropertyName("header")]
        public HeaderSuffix? Header { get; set; }

        /// <summary>
        /// 卡片标题
        /// </summary>
        [JsonPropertyName("i18n_header")]
        public I18nLanguage<HeaderSuffix>? I18nHeader { get; set; }

        /// <summary>
        /// 卡片标题
        /// </summary>
        public record HeaderSuffix
        {
            /// <summary>
            /// 配置卡片的主标题信息。
            /// </summary>
            [JsonPropertyName("title")]
            public HeaderTitleElement? Title { get; set; }

            /// <summary>
            /// 配置卡片的副标题信息。
            /// </summary>
            [JsonPropertyName("subtitle")]
            public HeaderTitleElement? Subtitle { get; set; }

            /// <summary>
            /// 该对象用于设置标题的前缀图标。
            /// <para>一个卡片仅可配置一个标题图标。如果同时配置 icon 和 ud_icon，仅生效 ud_icon。</para>
            /// </summary>
            [JsonPropertyName("icon")]
            public HeaderIcon? Icon { get; set; }

            /// <summary>该对象用于设置标题的前缀图标。</summary>
            public record HeaderIcon
            {
                /// <summary>
                /// 前缀图标 key。
                /// <para>图标 key 的获取方式：调用上传图片接口，上传用于发送消息的图片，并在返回值中获取图片的 image_key。</para>
                /// </summary>
                [JsonPropertyName("img_key")]
                public string? ImgKey { get; set; }
            }

            /// <summary>
            /// 添加图标库中已有的图标。
            /// <para>一个卡片仅可配置一个标题图标。如果同时配置 icon 和 ud_icon，仅生效 ud_icon。</para>
            /// </summary>
            [JsonPropertyName("ud_icon")]
            public HeaderUdIcon? UdIcon { get; set; }

            /// <summary>添加图标库中已有的图标。</summary>
            public record HeaderUdIcon
            {
                /// <summary>
                /// 图标库中图标的 token。枚举值参见图标库。
                /// </summary>
                [JsonPropertyName("token")]
                public string? Token { get; set; }

                /// <summary>
                /// 图标的样式。支持自定义图标颜色。
                /// </summary>
                [JsonPropertyName("style")]
                public StyleSuffix? Style { get; set; }

                /// <summary>
                /// 图标的样式。支持自定义图标颜色。
                /// </summary>
                /// <param name="Color">图标的颜色。支持设置线性和面性图标（即 token 末尾为 outlined 或 filled 的图标）的颜色。默认为 template 字段设置的颜色。枚举值参见颜色枚举值。
                /// <list type="bullet">
                /// <item>blue</item>
                /// <item>wathet</item>
                /// <item>turquoise</item>
                /// <item>green</item>
                /// <item>yellow</item>
                /// <item>orange</item>
                /// <item>red</item>
                /// <item>carmine</item>
                /// <item>violet</item>
                /// <item>purple</item>
                /// <item>indigo</item>
                /// <item>grey</item>
                /// <item>default</item>
                /// </list>
                /// </param>
                public record StyleSuffix([property: JsonPropertyName("color")] string Color);
            }

            /// <summary>
            /// 标题主题颜色。可选值与示例效果参见下文的 标题样式表。
            /// <para>blue</para>
            /// <para>wathet</para>
            /// <para>turquoise</para>
            /// <para>green</para>
            /// <para>yellow</para>
            /// <para>orange</para>
            /// <para>red</para>
            /// <para>carmine</para>
            /// <para>violet</para>
            /// <para>purple</para>
            /// <para>indigo</para>
            /// <para>grey</para>
            /// <para>default</para>
            /// </summary>
            [JsonPropertyName("template")]
            public string? Template { get; set; }

            /// <summary>
            /// 标题的标签属性。最多可配置 3 个标签内容，如果配置的标签数量超过 3 个，则取前 3 个标签进行展示。标签展示顺序与数组顺序一致。
            /// <para>text_tag_list 和 i18n_text_tag_list 只能配置其中之一。如果同时配置两个字段，则优先生效国际化配置。</para>
            /// </summary>
            [JsonPropertyName("text_tag_list")]
            public HeaderTextTagElement[]? TextTagList { get; set; }

            /// <summary>
            /// 标题标签的国际化属性。你可以在该字段内配置多语言环境的标签内容。每个语言环境下最多可配置 3 个标签内容，如果配置的标签数量超过 3 个，则取前 3 个标签进行展示。标签展示顺序与数组顺序一致。
            /// <para>text_tag_list 和 i18n_text_tag_list 只能配置其中之一。如果同时配置两个字段，则优先生效国际化配置。</para>
            /// </summary>
            [JsonPropertyName("i18n_text_tag_list")]
            public I18nLanguage<HeaderTextTagElement[]>? I18nTextTagList { get; set; }
        }

        /// <summary>
        /// 卡片全局行为设置。用于配置卡片的全局行为，包括是否允许被转发、是否为共享卡片等。
        /// </summary>
        [JsonPropertyName("config")]
        public ConfigSuffix? Config { get; set; }

        /// <summary>
        /// 卡片全局行为设置
        /// </summary>
        public record ConfigSuffix
        {
            /// <summary>
            /// 是否允许转发卡片。取值：
            /// <para>true：允许</para>
            /// <para>false：不允许</para>
            /// </summary>
            [JsonPropertyName("enable_forward")]
            public bool? EnableForward { get; set; }

            /// <summary>
            /// 是否为共享卡片。取值：
            /// <para>true：是共享卡片，更新卡片的内容对所有收到这张卡片的人员可见。</para>
            /// <para>false：非共享卡片，即独享卡片，仅操作用户可见卡片的更新内容。</para>
            /// </summary>
            [JsonPropertyName("update_multi")]
            public bool? UpdateMulti { get; set; }

            /// <summary>
            /// 卡片宽度模式。支持 "compact"（紧凑宽度 400px）模式、"fill"（撑满聊天窗口宽度）模式和 "default" 默认模式(宽度上限为 600px)。
            /// </summary>
            /// <value>
            /// <list type="bullet">
            /// <item>compact：紧凑宽度 400px</item>
            /// <item>fill：撑满聊天窗口宽度</item>
            /// <item>default：默认模式(宽度上限为 600px)</item>
            /// </list>
            /// </value>
            [JsonPropertyName("width_mode")]
            public string? WidthMode { get; set; }

            /// <summary>
            /// 是否使用自定义翻译数据。默认值 false。
            /// <para>true：在用户点击消息翻译后，使用 i18n 对应的目标语种作为翻译结果。若 i18n 取不到，则使用当前内容请求飞书的机器翻译。</para>
            /// <para>false：不使用自定义翻译数据，直接请求飞书的机器翻译。</para>
            /// </summary>
            [JsonPropertyName("use_custom_translation")]
            public bool? UseCustomTranslation { get; set; }

            /// <summary>
            /// 转发的卡片是否仍然支持回传交互。默认值 false。
            /// </summary>
            [JsonPropertyName("enable_forward_interaction")]
            public bool? EnableForwardInteraction { get; set; }

            /// <summary>
            /// 添加自定义字号和颜色。可应用在组件 JSON 数据中，设置字号和颜色属性。
            /// </summary>
            [JsonPropertyName("style")]
            public StyleSuffix? Style { get; set; }

            /// <summary>
            /// 添加自定义字号和颜色。可应用在组件 JSON 数据中，设置字号和颜色属性。
            /// </summary>
            /// <param name="TextSize">分别为移动端和桌面端添加自定义字号，同时添加兜底字号。用于在组件 JSON 中设置字号属性。支持添加多个自定义字号对象。</param>
            /// <param name="Color">分别为飞书客户端浅色主题和深色主题添加 RGBA 语法。用于在组件 JSON 中设置颜色属性。支持添加多个自定义颜色对象。</param>
            public record StyleSuffix([property: JsonPropertyName("text_size")] Dictionary<string, TextSizeStyle>? TextSize = null,
                [property: JsonPropertyName("color")] Dictionary<string, ColorStyle>? Color = null);

            /// <summary>
            /// 分别为移动端和桌面端添加自定义字号，同时添加兜底字号。用于在组件 JSON 中设置字号属性。支持添加多个自定义字号对象。
            /// </summary>
            /// <param name="Default">
            /// 在无法差异化配置字号的旧版飞书客户端上，生效的字号属性。选填。
            /// <list type="bullet">
            /// <item>heading-0：特大标题（30px）</item>
            /// <item>heading-1：一级标题（24px）</item>
            /// <item>heading-2：二级标题（20 px）</item>
            /// <item>heading-3：三级标题（18px）</item>
            /// <item>heading-4：四级标题（16px）</item>
            /// <item>heading：标题（16px）</item>
            /// <item>normal：正文（14px）</item>
            /// <item>notation：辅助信息（12px）</item>
            /// <item>xxxx-large：30px</item>
            /// <item>xxx-large：24px</item>
            /// <item>xx-large：20px</item>
            /// <item>x-large：18px</item>
            /// <item>large：16px</item>
            /// <item>medium：14px</item>
            /// <item>small：12px</item>
            /// <item>x-small：10px</item>
            /// </list>
            /// </param>
            /// <param name="Pc">桌面端的字号。</param>
            /// <param name="Mobile">移动端的字号。</param>
            public record TextSizeStyle([property: JsonPropertyName("default")] string Default = "normal",
                [property: JsonPropertyName("pc")] string Pc = "normal",
                [property: JsonPropertyName("mobile")] string Mobile = "normal");

            /// <summary>
            /// 分别为飞书客户端浅色主题和深色主题添加 RGBA 语法。用于在组件 JSON 中设置颜色属性。支持添加多个自定义颜色对象。
            /// </summary>
            /// <param name="LightMode">浅色主题下的自定义颜色语法</param>
            /// <param name="DarkMode">浅色主题下的自定义颜色语法</param>
            public record ColorStyle([property: JsonPropertyName("light_mode")] string? LightMode = null,
                [property: JsonPropertyName("dark_mode")] string? DarkMode = null);
        }

        /// <summary>
        /// 卡片全局跳转链接
        /// <para>url 和各端的链接（android_url、ios_url、pc_url）必填其中一个。如果不填写 url，则必须完整填写 android_url、ios_url、pc_url 三个字段。如果同时填写了 url 和 android_url、ios_url、pc_url，url 字段生效。</para>
        /// </summary>
        [JsonPropertyName("card_link")]
        public UrlLink? CardLink { get; set; }

        /// <summary>
        /// 元素集合
        /// </summary>
        [JsonPropertyName("elements")]
        public object[]? Elements { get; set; }

        /// <summary>
        /// 元素集合
        /// </summary>
        [JsonPropertyName("i18n_elements")]
        public I18nLanguage<object[]>? I18nElements { get; set; }

    }
}
