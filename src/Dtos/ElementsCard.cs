using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeishuNetSdk.Dtos
{
    /// <summary>
    /// 卡片内容
    /// </summary>
    public record ElementsCardDto
    {
        /// <summary>
        /// 卡片标题
        /// </summary>
        [JsonPropertyName("header")]
        public HeaderSuffix? Header { get; set; }

        /// <summary>
        /// 用于配置卡片的属性，包括是否允许被转发、是否为共享卡片等。
        /// </summary>
        [JsonPropertyName("config")]
        public ConfigSuffix? Config { get; set; }

        /// <summary>
        /// 用于指定卡片整体的跳转链接。
        /// </summary>
        [JsonPropertyName("card_link")]
        public CardLinkSuffix? CardLink { get; set; }

        /// <summary>
        /// 元素集合
        /// </summary>
        [JsonPropertyName("elements")]
        public Element[] Elements { get; set; } = Array.Empty<Element>();

        /// <summary>
        /// 用于指定卡片整体的跳转链接。
        /// </summary>
        public record CardLinkSuffix
        {
            /// <summary>
            /// 默认的链接地址。
            /// </summary>
            [JsonPropertyName("url")]
            public string Url { get; set; } = string.Empty;

            /// <summary>
            /// PC 端的链接地址。
            /// </summary>
            [JsonPropertyName("pc_url")]
            public string? PcUrl { get; set; }

            /// <summary>
            /// iOS 端的链接地址。
            /// </summary>
            [JsonPropertyName("ios_url")]
            public string? IosUrl { get; set; }

            /// <summary>
            /// Android 端的链接地址。
            /// </summary>
            [JsonPropertyName("android_url")]
            public string? AndroidUrl { get; set; }
        }

        /// <summary>
        /// 配置卡片属性
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
        }

        /// <summary>
        /// 卡片标题
        /// </summary>
        public record HeaderSuffix
        {
            /// <summary>
            /// 配置卡片的主标题信息。
            /// </summary>
            [JsonPropertyName("title")]
            public HeaderTitle Title { get; set; } = new();

            /// <summary>
            /// 配置卡片的副标题信息。
            /// </summary>
            [JsonPropertyName("subtitle")]
            public HeaderTitle? Subtitle { get; set; }

            /// <summary>
            /// 该对象用于设置标题的前缀图标。一个卡片仅可配置一个标题图标。
            /// </summary>
            [JsonPropertyName("icon")]
            public HeaderIcon? Icon { get; set; }

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
            public HeaderTextTagList[]? TextTagList { get; set; }

            /// <summary>
            /// 标题标签的国际化属性。你可以在该字段内配置多语言环境的标签内容。每个语言环境下最多可配置 3 个标签内容，如果配置的标签数量超过 3 个，则取前 3 个标签进行展示。标签展示顺序与数组顺序一致。
            /// <para>text_tag_list 和 i18n_text_tag_list 只能配置其中之一。如果同时配置两个字段，则优先生效国际化配置。</para>
            /// </summary>
            [JsonPropertyName("i18n_text_tag_list")]
            public I18nSuffix<HeaderTextTagList[]>? I18nTextTagList { get; set; }

            /// <summary></summary>
            public record HeaderTitle
            {
                /// <summary>
                /// 文本标识。固定取值：plain_text
                /// </summary>
                [JsonPropertyName("tag")]
                public string Tag { get; } = "plain_text";

                /// <summary>
                /// 卡片主标题内容。
                /// <para>必须配置 content 或 i18n 两个属性的其中一个。如果同时配置仅生效 i18n。</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// 国际化文本内容，其中：
                /// <para>zh_cn：简体中文</para>
                /// <para>en_us：英文</para>
                /// <para>ja_jp：日文</para>
                /// <para>zh_hk：繁体中文（中国香港）</para>
                /// <para>zh_tw：繁体中文（中国台湾）</para>
                /// <para>必须配置 content 或 i18n 两个属性的其中一个。如果同时配置仅生效 i18n。</para>
                /// </summary>
                [JsonPropertyName("i18n")]
                public I18nSuffix<string>? I18n { get; set; }
            }

            /// <summary></summary>
            public record HeaderIcon
            {
                /// <summary>
                /// 前缀图标 key。
                /// <para>图标 key 的获取方式：调用上传图片接口，上传用于发送消息的图片，并在返回值中获取图片的 image_key。</para>
                /// </summary>
                [JsonPropertyName("img_key")]
                public string? ImgKey { get; set; }
            }

            /// <summary></summary>
            public record HeaderTextTagList
            {
                /// <summary>
                /// 标题标签的标识。固定取值：text_tag
                /// </summary>
                [JsonPropertyName("tag")]
                public string Tag { get; } = "text_tag";

                /// <summary>
                /// 标题标签的内容。基于文本组件的 plain_text 模式定义内容。
                /// </summary>
                [JsonPropertyName("text")]
                public PlainText? Text { get; set; }

                /// <summary>
                /// 标题标签的颜色，默认为蓝色（blue）。可选值与示例效果参见下文的 标签样式表。
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
                [JsonPropertyName("color")]
                public string? Color { get; }

            }
        }

        /// <summary>
        /// 国际化
        /// </summary>
        public record I18nSuffix<T>
        {
            /// <summary>
            /// 简体中文
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public T? ZhCn { get; set; }

            /// <summary>
            /// 英文
            /// </summary>
            [JsonPropertyName("en_us")]
            public T? EnUs { get; set; }

            /// <summary>
            /// 日文
            /// </summary>
            [JsonPropertyName("ja_jp")]
            public T? JaJp { get; set; }

            /// <summary>
            /// 繁体中文（中国香港）
            /// </summary>
            [JsonPropertyName("zh_hk")]
            public T? ZhHk { get; set; }

            /// <summary>
            /// 繁体中文（中国台湾）
            /// </summary>
            [JsonPropertyName("zh_tw")]
            public T? ZhTw { get; set; }
        }

        /// <summary>
        /// 基于文本组件的 plain_text 模式定义内容
        /// </summary>
        public record PlainText
        {
            /// <summary>
            /// 标签
            /// </summary>
            [JsonPropertyName("tag")]
            public string Tag { get; } = "plain_text";

            /// <summary>
            /// 内容
            /// </summary>
            [JsonPropertyName("content")]
            public string Content { get; set; } = string.Empty;
        }
    }
}
