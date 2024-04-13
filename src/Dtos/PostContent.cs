using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeishuNetSdk.Dtos
{
    /// <summary>
    /// 富文本消息
    /// </summary>
    public record PostContent : MessageContent
    {
        /// <summary>
        /// 富文本消息。post content格式请参见发送消息Content
        /// </summary>
        [JsonPropertyName("post")]
        public PostSuffix Post { get; set; } = new();

        /// <summary></summary>
        public record PostSuffix
        {
            /// <summary>
            /// 中文消息
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public PostLanguageSuffix? ZhCn { get; set; }

            /// <summary>
            /// 英文消息
            /// </summary>
            [JsonPropertyName("en_us")]
            public PostLanguageSuffix? EnUs { get; set; }
        }

        /// <summary></summary>
        public record PostLanguageSuffix
        {
            /// <summary>
            /// 标题
            /// </summary>
            [JsonPropertyName("title")]
            public string Title { get; set; } = string.Empty;

            /// <summary>
            /// 富文本 post
            /// <para>富文本可以在一条消息中同时支持文字、At、图片、视频、超链接等元素。</para>
            /// <para>一个富文本可分多个段落（由多个[]组成），每个段落可由多个元素组成，每个元素由tag和相应的字段描述组成。主要图片元素必须是独立的一个段落。</para>
            /// </summary>
            [JsonPropertyName("content")]
            public RichTextSuffix[][] Content { get; set; } = Array.Empty<RichTextSuffix[]>();
        }

        /// <summary>
        /// 富文本消息
        /// </summary>
        public abstract record RichTextSuffix
        {
            /// <summary>
            /// 标签
            /// </summary>
            [JsonPropertyName("tag")]
            public virtual string Tag { get; } = string.Empty;
        }

        /// <summary>
        /// 文本消息
        /// </summary>
        public record TagTextSuffix : RichTextSuffix
        {
            /// <summary>
            /// 标签
            /// </summary>
            public override string Tag => "text";

            /// <summary>
            /// 文本内容
            /// </summary>
            [JsonPropertyName("text")]
            public string Text { get; set; } = string.Empty;

            /// <summary>
            /// 表示是不是 unescape 解码，默认为 false ，不用可以不填。
            /// </summary>
            [JsonPropertyName("un_escape")]
            public bool UnEscape { get; set; }

            /// <summary>
            /// 用于配置文本内容加粗、下划线、删除线和斜体样式，可选值分别为bold、underline、lineThrough与italic，非可选值将被忽略。
            /// </summary>
            [JsonPropertyName("style")]
            public string[]? Style { get; set; }
        }

        /// <summary>
        /// 链接消息
        /// </summary>
        public record TagLinkSuffix : RichTextSuffix
        {
            /// <summary>
            /// 标签
            /// </summary>
            public override string Tag => "a";

            /// <summary>
            /// 文本内容
            /// </summary>
            [JsonPropertyName("text")]
            public string Text { get; set; } = string.Empty;

            /// <summary>
            /// 默认的链接地址，请确保链接地址的合法性，否则消息会发送失败。
            /// </summary>
            [JsonPropertyName("href")]
            public string Href { get; set; } = string.Empty;

            /// <summary>
            /// 用于配置文本内容加粗、下划线、删除线和斜体样式，可选值分别为bold、underline、lineThrough与italic，非可选值将被忽略。
            /// </summary>
            [JsonPropertyName("style")]
            public string[]? Style { get; set; }
        }

        /// <summary>
        /// At 消息
        /// </summary>
        public record TagAtSuffix : RichTextSuffix
        {
            /// <summary>
            /// 标签
            /// </summary>
            public override string Tag => "at";

            /// <summary>
            /// 用户的open_id，union_id 或 user_id，请参考如何获取 User ID、Open ID 和 Union ID。
            /// <para>注意: @单个用户时，user_id字段必须是有效值；@所有人填"all"。</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string UserId { get; set; } = string.Empty;

            /// <summary>
            /// 用于配置文本内容加粗、下划线、删除线和斜体样式，可选值分别为bold、underline、lineThrough与italic，非可选值将被忽略。
            /// </summary>
            [JsonPropertyName("style")]
            public string[]? Style { get; set; }
        }

        /// <summary>
        /// 图片消息
        /// </summary>
        public record TagImgSuffix : RichTextSuffix
        {
            /// <summary>
            /// 标签
            /// </summary>
            public override string Tag => "img";

            /// <summary>
            /// 图片的唯一标识，可通过 上传图片 接口获取image_key。
            /// </summary>
            [JsonPropertyName("image_key")]
            public string ImageKey { get; set; } = string.Empty;
        }

        /// <summary>
        /// 媒体消息
        /// </summary>
        public record TagMediaSuffix : RichTextSuffix
        {
            /// <summary>
            /// 标签
            /// </summary>
            public override string Tag => "media";

            /// <summary>
            /// 视频文件的唯一标识，可通过 上传文件 接口获取file_key。
            /// </summary>
            [JsonPropertyName("file_key")]
            public string FileKey { get; set; } = string.Empty;

            /// <summary>
            /// 视频封面图片的唯一标识，可通过 上传图片 接口获取image_key。
            /// </summary>
            [JsonPropertyName("image_key")]
            public string ImageKey { get; set; } = string.Empty;
        }

        /// <summary>
        /// 图片消息
        /// </summary>
        public record TagEmotionSuffix : RichTextSuffix
        {
            /// <summary>
            /// 标签
            /// </summary>
            public override string Tag => "emotion";

            /// <summary>
            /// 表情类型，部分可选值请参见表情文案。
            /// </summary>
            [JsonPropertyName("emoji_type")]
            public string EmojiType { get; set; } = string.Empty;
        }
    }
}
