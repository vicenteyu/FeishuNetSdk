namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 富文本消息
    /// </summary>
    public record PostContent(string MessageType = "post") : MessageContent(MessageType)
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
            public PostLanguage? ZhCn { get; set; }

            /// <summary>
            /// 英文消息
            /// </summary>
            [JsonPropertyName("en_us")]
            public PostLanguage? EnUs { get; set; }
        }

        /// <summary></summary>
        public record PostLanguage
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
            public object[][] Content { get; set; } = Array.Empty<object[]>();
        }

        /// <summary>
        /// 富文本消息
        /// </summary>
        /// <param name="Tag">标签</param>
        public record TagBase([property: JsonPropertyName("tag")] string Tag);

        /// <summary>
        /// 文本消息
        /// </summary>
        /// <param name="Tag">标签</param>
        public record TagText(string Tag = "text") : TagBase(Tag)
        {
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
        /// <param name="Tag">标签</param>
        public record TagLink(string Tag = "a") : TagBase(Tag)
        {
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
        /// <param name="Tag">标签</param>
        public record TagAt(string Tag = "at") : TagBase(Tag)
        {
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
        /// <param name="Tag">标签</param>
        public record TagImg(string Tag = "img") : TagBase(Tag)
        {
            /// <summary>
            /// 图片的唯一标识，可通过 上传图片 接口获取image_key。
            /// </summary>
            [JsonPropertyName("image_key")]
            public string ImageKey { get; set; } = string.Empty;
        }

        /// <summary>
        /// 媒体消息
        /// </summary>
        /// <param name="Tag">标签</param>
        public record TagMedia(string Tag = "media") : TagBase(Tag)
        {
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
        /// 表情消息
        /// </summary>
        /// <param name="Tag">标签</param>
        public record TagEmotion(string Tag = "emotion") : TagBase(Tag)
        {
            /// <summary>
            /// 表情类型，部分可选值请参见表情文案。
            /// </summary>
            [JsonPropertyName("emoji_type")]
            public string EmojiType { get; set; } = string.Empty;
        }

        /// <summary>
        /// 表示一条分割线
        /// </summary>
        /// <param name="Tag">标签</param>
        public record TagHr(string Tag = "hr") : TagBase(Tag);

        /// <summary>
        /// markdown 内容
        /// </summary>
        /// <param name="Tag">标签</param>
        public record TagMd(string Tag = "md") : TagBase(Tag)
        {
            /// <summary>
            /// markdown 内容
            /// </summary>
            [JsonPropertyName("text")]
            public string Text { get; set; } = string.Empty;
        }

        /// <summary>
        /// 代码块
        /// </summary>
        /// <param name="Tag">标签</param>
        public record TagCodeBlock(string Tag = "code_block") : TagBase(Tag)
        {
            /// <summary>
            /// 代码块内容
            /// </summary>
            [JsonPropertyName("text")]
            public string Text { get; set; } = string.Empty;

            /// <summary>
            /// 代码块语言，不填为文本类型，可选值有：，不区分大小写
            /// <list type="bullet">
            /// <item>PYTHON</item>
            /// <item>C</item>
            /// <item>CPP</item>
            /// <item>GO</item>
            /// <item>JAVA</item>
            /// <item>KOTLIN</item>
            /// <item>SWIFT</item>
            /// <item>PHP</item>
            /// <item>RUBY</item>
            /// <item>RUST</item>
            /// <item>JAVASCRIPT</item>
            /// <item>TYPESCRIPT</item>
            /// <item>BASH</item>
            /// <item>SHELL</item>
            /// <item>SQL</item>
            /// <item>JSON</item>
            /// <item>XML</item>
            /// <item>YAML</item>
            /// <item>HTML</item>
            /// <item>THRIFT</item>
            /// </list>
            /// </summary>
            [JsonPropertyName("language")]
            public string? Language { get; set; }
        }
    }
}
