namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 元素
    /// </summary>
    /// <param name="Tag">标签</param>
    public abstract record Element(string Tag)
    {
        /// <summary>
        /// 标签
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; } = Tag;
    }

    /// <summary>
    /// 文本消息
    /// </summary>
    /// <param name="Text">文本内容</param>
    /// <param name="UnEscape">表示是不是 unescape 解码，默认为 false ，不用可以不填。</param>
    /// <param name="Style">用于配置文本内容加粗、下划线、删除线和斜体样式，可选值分别为bold、underline、lineThrough与italic，非可选值将被忽略。</param>
    public record TextElement([property: JsonPropertyName("text")] string Text = "",
        [property: JsonPropertyName("un_escape")] bool UnEscape = false,
        [property: JsonPropertyName("style")] string[]? Style = null) : Element("text");

    /// <summary>
    /// 链接消息
    /// </summary>
    /// <param name="Text">文本内容</param>
    /// <param name="Href">默认的链接地址，请确保链接地址的合法性，否则消息会发送失败。</param>
    /// <param name="Style">用于配置文本内容加粗、下划线、删除线和斜体样式，可选值分别为bold、underline、lineThrough与italic，非可选值将被忽略。</param>
    public record LinkElement([property: JsonPropertyName("text")] string Text = "",
        [property: JsonPropertyName("href")] string Href = "",
        [property: JsonPropertyName("style")] string[]? Style = null) : Element("a");

    /// <summary>
    /// At 消息
    /// </summary>
    /// <param name="UserId">
    /// <para>用户的open_id，union_id 或 user_id，请参考如何获取 User ID、Open ID 和 Union ID。</para>
    /// <para>注意: @单个用户时，user_id字段必须是有效值；@所有人填"all"。</para>
    /// </param>
    /// <param name="Style">用于配置文本内容加粗、下划线、删除线和斜体样式，可选值分别为bold、underline、lineThrough与italic，非可选值将被忽略。</param>
    public record AtElement([property: JsonPropertyName("user_id")] string UserId = "",
        [property: JsonPropertyName("style")] string[]? Style = null) : Element("at");

    /// <summary>
    /// 图片消息
    /// </summary>
    /// <param name="ImageKey">图片的唯一标识，可通过 上传图片 接口获取image_key。</param>
    public record ImgElement([property: JsonPropertyName("image_key")] string ImageKey = "") : Element("img");

    /// <summary>
    /// 媒体消息
    /// </summary>
    /// <param name="FileKey">视频文件的唯一标识，可通过 上传文件 接口获取file_key。</param>
    /// <param name="ImageKey">视频封面图片的唯一标识，可通过 上传图片 接口获取image_key。</param>
    public record MediaElement([property: JsonPropertyName("file_key")] string FileKey = "",
        [property: JsonPropertyName("image_key")] string ImageKey = "") : Element("media");

    /// <summary>
    /// 表情消息
    /// </summary>
    /// <param name="EmojiType">表情类型，部分可选值请参见表情文案。</param>
    public record EmotionElement([property: JsonPropertyName("emoji_type")] string EmojiType = "") : Element("emotion");

    /// <summary>
    /// 表示一条分割线
    /// </summary>
    public record HrElement() : Element("hr");

    /// <summary>
    /// markdown 内容
    /// </summary>
    /// <param name="Text">markdown 内容</param>
    public record MdElement([property: JsonPropertyName("text")] string Text = "") : Element("md");

    /// <summary>
    /// 代码块
    /// </summary>
    /// <param name="Text">代码块内容</param>
    /// <param name="Language">
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
    /// </param>
    public record CodeBlockElement([property: JsonPropertyName("text")] string Text = "",
        [property: JsonPropertyName("language")] string? Language = null) : Element("code_block");
}
