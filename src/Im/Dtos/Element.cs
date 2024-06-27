// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="Element.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>元素</summary>
// ************************************************************************
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
    /// <param name="Mode">
    /// 图片显示模式。取值：
    /// <para>注意：设置该参数后，会覆盖 custom_width 参数。更多信息参见消息卡片设计规范。</para>
    /// <list type="bullet">
    /// <item>crop_center：居中裁剪模式，对长图会限高，并居中裁剪后展示。</item>
    /// <item>fit_horizontal：平铺模式，宽度撑满卡片完整展示上传的图片。</item>
    /// <item>stretch：自适应。图片宽度撑满卡片宽度，当图片 高:宽 小于 16:9 时，完整展示原图。当图片 高:宽 大于 16:9 时，顶部对齐裁剪图片，并在图片底部展示 长图 脚标。</item>
    /// <item>large：大图，尺寸为 160 × 160，适用于多图混排。</item>
    /// <item>medium：中图，尺寸为 80 × 80，适用于图文混排的封面图。</item>
    /// <item>small：小图，尺寸为 40 × 40，适用于人员头像。</item>
    /// <item>tiny：超小图，尺寸为 16 × 16，适用于图标、备注。</item>
    /// </list>
    /// </param>
    /// <param name="Alt">悬浮（hover）在图片上时展示的说明文案。</param>
    /// <param name="Title">图片标题。</param>
    /// <param name="CornerRadius">
    /// 图片的圆角半径，单位是像素（px）。取值遵循以下格式：
    /// <list type="bullet">
    /// <item>[0,∞]px</item>
    /// <item>[0,100]%</item>
    /// </list>
    /// </param>
    /// <param name="ScaleType">
    /// 图片的裁剪模式，当 size 字段的比例和图片的比例不一致时会触发裁剪。可取值：
    /// <list type="bullet">
    /// <item>crop_center：居中裁剪</item>
    /// <item>crop_top：顶部裁剪</item>
    /// <item>fit_horizontal：完整展示不裁剪</item>
    /// </list>
    /// </param>
    /// <param name="Size">
    /// 图片尺寸。仅在 scale_type 字段为 crop_center 或 crop_top 时生效。可取值：
    /// <list type="bullet">
    /// <item>large：大图，尺寸为 160 × 160，适用于多图混排。</item>
    /// <item>medium：中图，尺寸为 80 × 80，适用于图文混排的封面图。</item>
    /// <item>small：小图，尺寸为 40 × 40，适用于人员头像。</item>
    /// <item>tiny：超小图，尺寸为 16 × 16，适用于图标、备注。</item>
    /// <item>stretch_without_padding：通栏图，适用于高宽比小于 16:9 的图片，图片的宽度将撑满卡片宽度。</item>
    /// <item>stretch：超大图，适用于高宽比小于 16:9 的图片。</item>
    /// <item>[1,999]px [1,999]px：自定义图片尺寸，单位为像素，中间用空格分隔。</item>
    /// </list>
    /// </param>
    /// <param name="CustomWidth">自定义图片的最大展示宽度，支持在 278px ~ 580px 范围内指定最大展示宽度。默认情况下图片宽度与图片组件所占区域的宽度一致。</param>
    /// <param name="Transparent">是否为透明底色。默认为 false，即图片为白色底色。</param>
    /// <param name="Preview">
    /// 点击后是否放大图片。
    /// <para>提示：如果你为卡片配置了跳转链接card_link参数，可将该参数设置为 false，后续用户点击卡片上的图片也能响应 card_link 链接跳转。</para>
    /// <list type="bullet">
    /// <item>true：点击图片后，弹出图片查看器放大查看当前点击的图片。</item>
    /// <item>false：点击图片后，响应卡片本身的交互事件，不弹出图片查看器。</item>
    /// </list>
    /// </param>
    /// <param name="CompactWidth">是否展示为紧凑型的图片。如果配置为 true，则展示最大宽度为 278px 的紧凑型图片。</param>
    public record ImgElement([property: JsonPropertyName("image_key")] string ImageKey = "",
        [property: JsonPropertyName("mode")] string? Mode = null,
        [property: JsonPropertyName("alt")] PlainTextElement? Alt = null,
        [property: JsonPropertyName("title")] PlainTextElement? Title = null,
        [property: JsonPropertyName("corner_radius")] string? CornerRadius = null,
        [property: JsonPropertyName("scale_type")] string? ScaleType = null,
        [property: JsonPropertyName("size")] string? Size = null,
        [property: JsonPropertyName("custom_width")] string? CustomWidth = null,
        [property: JsonPropertyName("transparent")] bool? Transparent = null,
        [property: JsonPropertyName("preview")] bool? Preview = null,
        [property: JsonPropertyName("compact_width")] bool? CompactWidth = null) : Element("img"), IAmNoteElement;

    /// <summary>
    /// 多图混排组件
    /// </summary>
    /// <param name="CombinationMode">
    /// 多图混排的方式，可取值：
    /// <para>注意：若上传的图片数量超过混排方式可容纳的上限，则系统将根据图片上传的顺序，优先展示排列顺序中靠前的图片。超出上限的图片将不再显示。</para>
    /// <para>若上传的图片数量未达到混排方式可容纳的上限，则未排布的部分将保留空白。</para>
    /// <list type="bullet">
    /// <item>double：双图混排，最多可排布两张图。</item>
    /// <item>triple：三图混排，最多可排布三张图。</item>
    /// <item>bisect：等分双列图混排，每行两个等大的正方形图，最多可排布三行，即六张图。</item>
    /// <item>trisect：等分三列图混排，每行三个等大的正方形图，最多可排布三行，即九张图。</item>
    /// </list>
    /// </param>
    /// <param name="CornerRadius">
    /// 多图混排图片的圆角半径，单位是像素（px）。取值遵循以下格式：
    /// <list type="bullet">
    /// <item>[0,∞]px</item>
    /// <item>[0,100]%</item>
    /// </list>
    /// </param>
    /// <param name="ImgList">图片资源的 img_key 数组，顺序与图片排列顺序一致。</param>
    public record ImgCombinationElement([property: JsonPropertyName("combination_mode")] string CombinationMode = "",
        [property: JsonPropertyName("corner_radius")] string? CornerRadius = null,
        [property: JsonPropertyName("img_list")] ImgCombinationElement.Img[] ImgList = default!) : Element("img_combination")
    {
        /// <summary>
        /// 图片资源
        /// </summary>
        /// <param name="ImgKey">图片资源的 Key。你可以调用上传图片接口或在搭建工具中上传图片，获取图片的 key。</param>
        public record Img([property: JsonPropertyName("img_key")] string ImgKey = "");
    }

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
    /// 人员组件
    /// </summary>
    /// <param name="UserId">
    /// 人员的 ID。可选值有：
    /// <list type="bullet">
    /// <item>人员的 Open ID：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。详情参考如何获取 Open ID</item>
    /// <item>人员的 Union ID：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。详情参考如何获取 Union ID</item>
    /// <item>人员的 User ID ：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。详情参考如何获取User ID</item>
    /// </list>
    /// </param>
    /// <param name="Size">
    /// 人员的头像尺寸。可取值：
    /// <list type="bullet">
    /// <item>extra_small：超小尺寸</item>
    /// <item>small：小尺寸</item>
    /// <item>medium：中尺寸</item>
    /// <item>large：大尺寸</item>
    /// </list>
    /// </param>
    public record PersonElement([property: JsonPropertyName("user_id")] string UserId = "",
        [property: JsonPropertyName("size")] string? Size = null) : Element("person");

    /// <summary>
    /// 人员列表组件
    /// </summary>
    /// <param name="Lines">最大显示行数，默认不限制最大显示行数。</param>
    /// <param name="ShowName">是否展示人员的用户名。</param>
    /// <param name="ShowAvatar">是否展示人员的头像。</param>
    /// <param name="Size">
    /// 人员的头像尺寸。可取值：
    /// <list type="bullet">
    /// <item>extra_small：超小尺寸</item>
    /// <item>small：小尺寸</item>
    /// <item>medium：中尺寸</item>
    /// <item>large：大尺寸</item>
    /// </list>
    /// </param>
    /// <param name="Persons">人员列表。</param>
    /// <param name="Icon">添加图标作为文本前缀图标。支持自定义或使用图标库中的图标。</param>
    public record PersonListElement([property: JsonPropertyName("lines")] int? Lines = null,
        [property: JsonPropertyName("show_name")] bool? ShowName = null,
        [property: JsonPropertyName("show_avatar")] bool? ShowAvatar = null,
        [property: JsonPropertyName("size")] string? Size = null,
        [property: JsonPropertyName("persons")] PersonListElement.Person[] Persons = default!,
        object? Icon = null) : Element("person_list")
    {
        /// <summary>
        /// 文本前缀图标
        /// </summary>
        [JsonPropertyName("icon")]
        public object? Icon { get; set; } = Icon;

        /// <summary>
        /// 人员
        /// </summary>
        /// <param name="Id">
        /// 人员的 ID。可选值有：
        /// <list type="bullet">
        /// <item>人员的 Open ID：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。详情参考如何获取 Open ID</item>
        /// <item>人员的 Union ID：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。详情参考如何获取 Union ID</item>
        /// <item>人员的 User ID ：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。详情参考如何获取User ID</item>
        /// </list>
        /// </param>
        public record Person([property: JsonPropertyName("id")] string Id = "");
    }

    /// <summary>
    /// markdown 内容
    /// </summary>
    /// <param name="Text">markdown 内容</param>
    public record MdElement([property: JsonPropertyName("text")] string Text = "") : Element("md");

    /// <summary>
    /// 普通文本内容
    /// </summary>
    public interface IAmDivTextElement { }

    /// <summary>
    /// 普通文本图标
    /// </summary>
    public interface IAmDivIconElement { }

    /// <summary>
    /// 普通文本组件
    /// <para>扩展方法：
    /// <list type="bullet">
    /// <item>SetText：设置文本内容，支持组件为：PlainTextElement、LarkMdElement</item>
    /// <item>SetIcon：设置文本图标，支持组件为：StandardIconElement、CustomIconElement</item>
    /// </list>
    /// </para>
    /// </summary>
    /// <param name="Text">文本内容</param>
    /// <param name="Icon">文本图标</param>
    public record DivElement(object? Text = null, object? Icon = null) : Element("div")
    {
        /// <summary>
        /// 文本内容
        /// </summary>
        [JsonPropertyName("text")]
        public object? Text { get; set; } = Text;

        /// <summary>
        /// 文本图标
        /// </summary>
        [JsonPropertyName("icon")]
        public object? Icon { get; set; } = Icon;
    }

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

    /// <summary>
    /// 普通文本
    /// </summary>
    /// <param name="Content">文本内容</param>
    /// <param name="TextSize">文本大小。
    /// <para>可取值如下所示。如果你填写了其它值，卡片将展示为 normal 字段对应的字号。你也可分别为移动端和桌面端定义不同的字号，详细步骤参考下文 为移动端和桌面端定义不同的字号。</para>
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
    /// <param name="TextColor">
    /// 文本的颜色。仅在 tag 为 plain_text 时生效。可取值：
    /// <list type="bullet">
    /// <item>default：客户端浅色主题模式下为黑色；客户端深色主题模式下为白色</item>
    /// <item>颜色的枚举值。详情参考颜色枚举值</item>
    /// </list>
    /// </param>
    /// <param name="TextAlign">
    /// 文本对齐方式。可取值：
    /// <list type="bullet">
    /// <item>left：左对齐</item>
    /// <item>center：居中对齐</item>
    /// <item>right：右对齐</item>
    /// </list>
    /// </param>
    /// <param name="Lines">内容最大显示行数，超出设置行的内容用 ... 省略。</param>
    public record PlainTextElement([property: JsonPropertyName("content")] string Content = "",
        [property: JsonPropertyName("text_size")] string? TextSize = null,
        [property: JsonPropertyName("text_color")] string? TextColor = null,
        [property: JsonPropertyName("text_align")] string? TextAlign = null,
        [property: JsonPropertyName("lines")] int? Lines = null) : Element("plain_text"), IAmDivTextElement, IAmNoteElement;

    /// <summary>
    /// 普通文本的Markdown
    /// </summary>
    /// <param name="Content">按钮上的文本，支持部分 Markdown 语法的文本内容。详情参考下文 lark_md 支持的 Markdown 语法。
    /// <para>
    /// 支持的 Markdown 语法：
    /// <list type="bullet">
    /// <item>换行：第一行\n第二行</item>
    /// <item>斜体：*斜体*</item>
    /// <item>粗体：**粗体** 或 __粗体__</item>
    /// <item>删除线：~~删除线~~</item>
    /// <item>文字链接：[文字链接](https://www.feishu.cn)</item>
    /// <item>超链接：&lt;a href='https://open.feishu.cn'&gt;&lt;/a&gt;</item>
    /// <item>@ 人：&lt;at id=all&gt;&lt;/at&gt;、&lt;at id={{open_id}}&gt;&lt;/at&gt;、&lt;at id={{user_id}}&gt;&lt;/at&gt;、&lt;at email=test@email.com&gt;&lt;/at&gt;</item>
    /// <item>彩色文本：&lt;font color=red&gt;红色&lt;/font&gt; 提示：要查看 color 枚举，参考颜色枚举值。</item>
    /// <item>emoji：😁😢🌞💼🏆❌✅</item>
    /// <item>飞书表情：:OK:&gt; 要查看表情枚举，参考表情文案说明。</item>
    /// <item>标签：&lt;text_tag color='neutral'&gt; neutral &lt;/text_tag&gt; color 的枚举值有：neutral、blue、turquoise、lime、orange、violet、indigo、wathet、green、yellow、red、purple、carmine</item>
    /// </list>
    /// </para>
    /// </param>
    /// <param name="TextSize">文本大小。
    /// <para>可取值如下所示。如果你填写了其它值，卡片将展示为 normal 字段对应的字号。你也可分别为移动端和桌面端定义不同的字号，详细步骤参考下文 为移动端和桌面端定义不同的字号。</para>
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
    /// <param name="TextAlign">
    /// 文本对齐方式。可取值：
    /// <list type="bullet">
    /// <item>left：左对齐</item>
    /// <item>center：居中对齐</item>
    /// <item>right：右对齐</item>
    /// </list>
    /// </param>
    /// <param name="Lines">内容最大显示行数，超出设置行的内容用 ... 省略。</param>
    public record LarkMdElement([property: JsonPropertyName("content")] string Content = "",
        [property: JsonPropertyName("text_size")] string? TextSize = null,
        [property: JsonPropertyName("text_align")] string? TextAlign = null,
        [property: JsonPropertyName("lines")] int? Lines = null) : Element("lark_md"), IAmDivTextElement, IAmNoteElement;

    /// <summary>
    /// 文本前缀图标
    /// </summary>
    /// <param name="Token">图标库中图标的 token。</param>
    /// <param name="Color">图标的颜色。支持设置线性和面性图标（即 token 末尾为 outlined 或 filled 的图标）的颜色。枚举值参见颜色枚举值。
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
    public record StandardIconElement([property: JsonPropertyName("token")] string? Token = null,
        [property: JsonPropertyName("color")] string? Color = null) : Element("standard_icon")
        , IAmDivIconElement, IAmNoteElement;

    /// <summary>
    /// 文本前缀图标
    /// </summary>
    /// <param name="ImgKey">自定义前缀图标的图片 key。图标 key 的获取方式：调用上传图片接口，上传用于发送消息的图片，并在返回值中获取图片的 image_key。</param>
    public record CustomIconElement([property: JsonPropertyName("img_key")] string? ImgKey = null) : Element("custom_icon")
        , IAmDivIconElement, IAmNoteElement;

    /// <summary>
    /// 富文本的（Markdown）
    /// </summary>
    /// <param name="Icon"></param>
    /// <param name="Content">文本内容</param>
    /// <param name="TextSize">文本大小。
    /// <para>可取值如下所示。如果你填写了其它值，卡片将展示为 normal 字段对应的字号。你也可分别为移动端和桌面端定义不同的字号，详细步骤参考下文 为移动端和桌面端定义不同的字号。</para>
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
    /// <param name="TextAlign">文本对齐方式
    /// <list type="bullet">
    /// <item>left：左对齐</item>
    /// <item>center：居中对齐</item>
    /// <item>right：右对齐</item>
    /// </list>
    /// </param>
    /// <param name="Href">配置差异化跳转链接，实现“不同设备跳转链接不同”的效果。</param>
    public record MarkdownElement(object? Icon = null,
        [property: JsonPropertyName("content")] string Content = "",
        [property: JsonPropertyName("text_size")] string? TextSize = null,
        [property: JsonPropertyName("text_align")] string? TextAlign = null,
        [property: JsonPropertyName("href")] MarkdownElement.HrefSuffix? Href = null) : Element("markdown")
    {
        /// <summary>
        /// 文本图标
        /// </summary>
        [JsonPropertyName("icon")]
        public object? Icon { get; set; } = Icon;

        /// <summary>
        /// 配置差异化跳转链接，实现“不同设备跳转链接不同”的效果。
        /// </summary>
        /// <param name="UrlVal">URL 的变量。</param>
        public record HrefSuffix([property: JsonPropertyName("urlVal")] UrlLink? UrlVal = null);
    }

    /// <summary>
    /// 设置点击分栏时的交互配置。当前仅支持跳转交互。如果布局容器内有交互组件，则优先响应交互组件定义的交互。
    /// </summary>
    /// <param name="MultiUrl">配置各个端的链接地址。</param>
    public record ColumnAction([property: JsonPropertyName("multi_url")] UrlLink? MultiUrl = null);

    /// <summary>
    /// 分栏-列
    /// </summary>
    /// <param name="BackgroundStyle">
    /// 列的背景色样式。可取值：
    /// <list type="bullet">
    /// <item>default：默认的白底样式，客户端深色主题下为黑底样式</item>
    /// <item>卡片支持的颜色枚举值和 RGBA 语法自定义颜色。参考颜色枚举值</item>
    /// </list>
    /// </param>
    /// <param name="Width">
    /// 列宽度。仅 flex_mode 为 none 时，生效此属性。取值：
    /// <list type="bullet">
    /// <item>auto：列宽度与列内元素宽度一致</item>
    /// <item>weighted：列宽度按 weight 参数定义的权重分布</item>
    /// <item>具体数值，如 100px。取值范围为 [16,600]px。V7.4 及以上版本支持该枚举</item>
    /// </list>
    /// </param>
    /// <param name="Weight">
    /// 当 width 字段取值为 weighted 时生效，表示当前列的宽度占比。取值范围为 1 ~ 5 之间的整数。
    /// </param>
    /// <param name="VerticalAlign">
    /// 列垂直居中的方式。可取值：
    /// <list type="bullet">
    /// <item>top：上对齐</item>
    /// <item>center：居中对齐</item>
    /// <item>bottom：下对齐</item>
    /// </list>
    /// </param>
    /// <param name="VerticalSpacing">
    /// 列内组件的纵向间距。取值：
    /// <list type="bullet">
    /// <item>default：默认间距，8px</item>
    /// <item>medium：中等间距</item>
    /// <item>large：大间距</item>
    /// <item>具体数值，如 8px。取值范围为 [0,28]px</item>
    /// </list>
    /// </param>
    /// <param name="Padding">
    /// 列的内边距。值的取值范围为 [0,28]px。可选值：
    /// <list type="bullet">
    /// <item>单值，如 "10px"，表示列的四个外边距都为 10 px。</item>
    /// <item>多值，如 "4px 12px 4px 12px"，表示列的上、右、下、左的外边距分别为 4px，12px，4px，12px。四个值必填，使用空格间隔。</item>
    /// </list>
    /// </param>
    /// <param name="Elements">列容器中内嵌的组件。可内嵌组件参考上文嵌套关系。</param>
    /// <param name="Action">设置点击列时的交互配置。当前仅支持跳转交互。如果布局容器内有交互组件，则优先响应交互组件定义的交互。</param>
    public record ColumnElement([property: JsonPropertyName("background_style")] string? BackgroundStyle = null,
        [property: JsonPropertyName("width")] string? Width = null,
        [property: JsonPropertyName("weight")] int? Weight = null,
        [property: JsonPropertyName("vertical_align")] string? VerticalAlign = null,
        [property: JsonPropertyName("vertical_spacing")] string? VerticalSpacing = null,
        [property: JsonPropertyName("padding")] string? Padding = null,
        [property: JsonPropertyName("elements")] object[] Elements = default!,
        [property: JsonPropertyName("action")] ColumnAction? Action = null) : Element("column");

    /// <summary>
    /// 分栏组件
    /// </summary>
    /// <param name="HorizontalSpacing">
    /// 各列之间的水平分栏间距。取值：
    /// <list type="bullet">
    /// <item>default：默认间距，8px</item>
    /// <item>small：窄间距，4px</item>
    /// <item>large：大间距，12px</item>
    /// <item>[0,28px]：自定义间距</item>
    /// </list>
    /// </param>
    /// <param name="HorizontalAlign">
    /// 列容器水平对齐的方式。可取值：
    /// <para>首行列的上外边距强制为 0，末行列的下外边距强制为 0。</para>
    /// <list type="bullet">
    /// <item>left：左对齐</item>
    /// <item>center：居中对齐</item>
    /// <item>right：右对齐</item>
    /// </list>
    /// </param>
    /// <param name="Margin">
    /// 列的外边距。值的取值范围为 [0,28]px。可选值：
    /// <list type="bullet">
    /// <item>单值，如 "10px"，表示列的四个外边距都为 10 px。</item>
    /// <item>多值，如 "4px 12px 4px 12px"，表示列的上、右、下、左的外边距分别为 4px，12px，4px，12px。四个值必填，使用空格间隔。</item>
    /// </list>
    /// </param>
    /// <param name="FlexMode">
    /// 移动端和 PC 端的窄屏幕下，各列的自适应方式。取值：
    /// <list type="bullet">
    /// <item>none：不做布局上的自适应，在窄屏幕下按比例压缩列宽度</item>
    /// <item>stretch：列布局变为行布局，且每列（行）宽度强制拉伸为 100%，所有列自适应为上下堆叠排布</item>
    /// <item>flow：列流式排布（自动换行），当一行展示不下一列时，自动换至下一行展示</item>
    /// <item>bisect：两列等分布局</item>
    /// <item>trisect：三列等分布局</item>
    /// </list>
    /// </param>
    /// <param name="BackgroundStyle">
    /// 分栏的背景色样式。可取值：
    /// <list type="bullet">
    /// <item>default：默认的白底样式，客户端深色主题下为黑底样式</item>
    /// <item>卡片支持的颜色枚举值和 RGBA 语法自定义颜色。参考颜色枚举值。</item>
    /// </list>
    /// </param>
    /// <param name="Columns">分栏中列的配置。</param>
    /// <param name="Action">设置点击分栏时的交互配置。当前仅支持跳转交互。如果布局容器内有交互组件，则优先响应交互组件定义的交互。</param>
    public record ColumnSetElement([property: JsonPropertyName("horizontal_spacing")] string? HorizontalSpacing = null,
        [property: JsonPropertyName("horizontal_align")] string? HorizontalAlign = null,
        [property: JsonPropertyName("margin")] string? Margin = null,
        [property: JsonPropertyName("flex_mode")] string? FlexMode = null,
        [property: JsonPropertyName("background_style")] string? BackgroundStyle = null,
        [property: JsonPropertyName("columns")] ColumnElement[] Columns = default!,
        [property: JsonPropertyName("action")] ColumnAction? Action = null) : Element("column_set");

    /// <summary>
    /// 备注组件 子元素节点
    /// </summary>
    public interface IAmNoteElement { }

    /// <summary>
    /// 备注组件
    /// <para>扩展方法
    /// <list type="bullet">
    /// <item>AddElement：添加子元素组件</item>
    /// </list>
    /// </para>
    /// </summary>
    /// <param name="Elements">备注信息</param>
    public record NoteElement(object[] Elements = default!) : Element("note")
    {
        /// <summary>
        /// 备注信息 子元素节点
        /// </summary>
        [property: JsonPropertyName("elements")]
        public object[] Elements { get; set; } = Elements ?? Array.Empty<object>();
    }

    /// <summary>
    /// 表格组件
    /// </summary>
    /// <param name="Columns">列对象数组。详见下方 column 字段说明。</param>
    /// <param name="Rows">行对象数组。与列定义对应的数据。用 "name":VALUE 的形式，定义每一行的数据内容。name即你自定义的列标记。</param>
    /// <param name="PageSize">每页最大展示的数据行数。支持 [1,10] 整数。</param>
    /// <param name="RowHeight">
    /// 表格的行高。单元格高度如无法展示一整行内容，则上下裁剪内容。可取值：
    /// <list type="bullet">
    /// <item>low：低</item>
    /// <item>middle：中</item>
    /// <item>high：高</item>
    /// <item>[32,124]px：自定义行高，单位为像素，如 40px。取值范围是 [32,124]</item>
    /// </list>
    /// </param>
    /// <param name="HeaderStyle">表头样式风格。详见下方 header_style 字段说明。</param>
    public record TableElement(TableElement.Column[] Columns = default!,
        Dictionary<string, object>[] Rows = default!,
        [property: JsonPropertyName("page_size")] int? PageSize = null,
        [property: JsonPropertyName("row_height")] string? RowHeight = null,
        [property: JsonPropertyName("header_style")] TableElement.Style? HeaderStyle = null) : Element("table")
    {
        /// <summary>
        /// 列对象数组
        /// </summary>
        [property: JsonPropertyName("columns")]
        public Column[] Columns { get; set; } = Columns ?? Array.Empty<Column>();

        /// <summary>
        /// 行对象数组
        /// </summary>
        [property: JsonPropertyName("rows")]
        public Dictionary<string, object>[] Rows { get; set; } = Rows ?? Array.Empty<Dictionary<string, object>>();

        /// <summary>
        /// 用于设置表头的样式、风格等
        /// </summary>
        /// <param name="TextAlign">
        /// 表头文本对齐方式。可取值：
        /// <list type="bullet">
        /// <item>left：左对齐</item>
        /// <item>center：居中对齐</item>
        /// <item>right：右对齐</item>
        /// </list>
        /// </param>
        /// <param name="TextSize">
        /// 表头文本大小。可取值：
        /// <list type="bullet">
        /// <item>normal：正文（14px）</item>
        /// <item>heading：标题（16px）</item>
        /// </list>
        /// </param>
        /// <param name="BackgroundStyle">
        /// 表头背景色。可取值：
        /// <list type="bullet">
        /// <item>grey：灰色</item>
        /// <item>none：无背景色</item>
        /// </list>
        /// </param>
        /// <param name="TextColor">
        /// 文本颜色。可取值：
        /// <list type="bullet">
        /// <item>default：客户端浅色主题模式下为黑色；客户端深色主题模式下为白色</item>
        /// <item>grey：灰色</item>
        /// </list>
        /// </param>
        /// <param name="Bold">
        /// 表头文本是否加粗。可取值：
        /// <list type="bullet">
        /// <item>true：加粗</item>
        /// <item>false：不加粗</item>
        /// </list>
        /// </param>
        /// <param name="Lines">表头文本的行数。支持大于等于 1 的整数。</param>
        public record Style([property: JsonPropertyName("text_align")] string? TextAlign = null,
            [property: JsonPropertyName("text_size")] string? TextSize = null,
            [property: JsonPropertyName("background_style")] string? BackgroundStyle = null,
            [property: JsonPropertyName("text_color")] string? TextColor = null,
            [property: JsonPropertyName("bold")] bool? Bold = null,
            [property: JsonPropertyName("lines")] int? Lines = null);

        /// <summary>
        /// 用于定义表格的列。最多支持添加 10 列，超出 10 列的内容不展示。
        /// </summary>
        /// <param name="Name">自定义列的标记。用于唯一指定行数据对象数组中，需要将数据填充至这一行的具体哪个单元格中。</param>
        /// <param name="DataType">列数据类型。可选值：
        /// <list type="bullet">
        /// <item>true：加粗</item>
        /// <item>false：不加粗</item>
        /// </list>
        /// </param>
        /// <param name="DisplayName">在表头展示的列名称。不填或为空则不展示列名称。</param>
        /// <param name="Width">
        /// 列宽度。可取值：
        /// <list type="bullet">
        /// <item>auto：自适应内容宽度</item>
        /// <item>自定义宽度：自定义表格的列宽度，如 120px。取值范围是 [80px,600px] 的整数</item>
        /// <item>自定义宽度百分比：自定义列宽度占当前表格画布宽度的百分比（表格画布宽度 = 卡片宽度-卡片左右内边距），如 25%。取值范围是 [1%,100%]</item>
        /// </list>
        /// </param>
        /// <param name="HorizontalAlign">
        /// 列内数据对齐方式。可选值：
        /// <list type="bullet">
        /// <item>left：左对齐</item>
        /// <item>center：居中对齐</item>
        /// <item>right：右对齐</item>
        /// </list>
        /// </param>
        /// <param name="Format">该字段仅当 data_type 为 number 时生效，你可以在该字段内选择设置小数点位数、货币单位以及千分位样式。</param>
        public record Column([property: JsonPropertyName("name")] string Name = "",
            [property: JsonPropertyName("data_type")] string DataType = "",
            [property: JsonPropertyName("display_name")] string? DisplayName = null,
            [property: JsonPropertyName("width")] string? Width = null,
            [property: JsonPropertyName("horizontal_align")] string? HorizontalAlign = null,
            [property: JsonPropertyName("format")] Column.FormatSuffix? Format = null)
        {
            /// <summary>
            /// 仅当 data_type 为 number 时生效，你可以在该字段内选择设置小数点位数、货币单位以及千分位样式。
            /// </summary>
            /// <param name="Precision">数字的小数点位数。默认不限制小数点位数，原样透传展示开发者输入的数字。可填 0~10 的整数。小数点位数为 0 表示取整数。</param>
            /// <param name="Symbol">数字前的货币单位。不填或为空不展示。可填 1 个字符的货币单位文本，如 “¥”。</param>
            /// <param name="Separator">是否生效按千分位逗号分割的数字样式。</param>
            public record FormatSuffix([property: JsonPropertyName("precision")] int? Precision = null,
                [property: JsonPropertyName("symbol")] string? Symbol = null,
                [property: JsonPropertyName("separator")] bool? Separator = null);
        }
    }

    /// <summary>
    /// 表单内部控件基类
    /// </summary>
    /// <param name="Tag">控件标签</param>
    public abstract record FormElement(string Tag) : Element(Tag);

    /// <summary>
    /// 表单容器交互控件
    /// </summary>
    /// <param name="Tag">控件标签</param>
    /// <param name="Name">组件的唯一标识</param>
    public abstract record FormBaseElement(string Tag, string Name = "") : Element(Tag)
    {
        /// <summary>
        /// 组件的唯一标识。用于识别用户在交互后，提交的是哪个表单项的数据。在表单容器中所有的交互组件中，该字段必填，否则数据会发送失败。
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = Name;
    }

    /// <summary>
    /// 输入框组件
    /// <para>扩展方法：
    /// <list type="bullet">
    /// <item>SetElements</item>
    /// </list>
    /// </para>
    /// </summary>
    /// <param name="Name">组件的唯一标识。</param>
    /// <param name="Required">是否必填
    /// <para>true：必填。当用户点击表单容器的“提交”时，未填写该组件，则前端提示“有必填项未填写”，不会向开发者的服务端发起回传请求。</para>
    /// <para>false：选填。当用户点击表单容器的“提交”时，未填写该组件，仍提交表单容器中的数据。</para>
    /// </param>
    public record InputFormElement(string Name = "", [property: JsonPropertyName("required")] bool? Required = null)
        : FormBaseElement("input", Name);

    /// <summary>
    /// 按钮组件
    /// </summary>
    /// <param name="Name">用于提交表单的按钮组件的唯一标识，用于识别用户在交互后，点击的是哪个按钮。在表单容器中所有的交互组件中，该字段必填，否则数据会发送失败。</param>
    /// <param name="Text">用于提交表单的按钮上的文本。</param>
    /// <param name="Type">按钮的类型。可选值：
    /// <list type="bullet">
    /// <item>default：黑色字体按钮，有边框</item>
    /// <item>primary：蓝色字体按钮，有边框</item>
    /// <item>danger：红色字体按钮，有边框</item>
    /// <item>text：黑色字体按钮，无边框</item>
    /// <item>primary_text：蓝色字体按钮，无边框</item>
    /// <item>danger_text：红色字体按钮，无边框</item>
    /// <item>primary_filled：蓝底白字按钮</item>
    /// <item>danger_filled：红底白字按钮</item>
    /// <item>laser：镭射按钮</item>
    /// </list></param>
    /// <param name="ActionType">内嵌在表单容器中的按钮的交互类型。
    /// <list type="bullet">
    /// <item>link：当前按钮仅支持链接跳转</item>
    /// <item>request：当前按钮仅支持回传交互</item>
    /// <item>multi：当前按钮同时支持链接跳转和回传交互</item>
    /// <item>form_submit：将当前按钮与提交事件绑定。用户点击后，将触发表单容器的提交事件，异步提交所有已填写的表单项内容</item>
    /// <item>form_reset：将当前按钮与取消提交事件绑定。用户点击后，将触发表单容器的取消提交事件，重置所有表单组件的输入值为初始值</item>
    /// </list>
    /// </param>
    /// <param name="Confirm">二次确认弹窗配置。指在用户提交时弹出二次确认弹窗提示；只有用户点击确认后，才提交输入的内容。该字段默认提供了确认和取消按钮，你只需要配置弹窗的标题与内容即可。
    /// <para>confirm 字段仅在用户点击包含提交属性的按钮时才会触发二次确认弹窗。</para>
    /// </param>
    public record ButtonFormElement(string Name = "",
        [property: JsonPropertyName("text")] LarkMdElement Text = default!,
        [property: JsonPropertyName("type")] string? Type = null,
        [property: JsonPropertyName("action_type")] string ActionType = "",
        [property: JsonPropertyName("confirm")] ButtonFormElement.ConfirmSuffix? Confirm = null) : FormBaseElement("button", Name)
    {
        ///// <summary>
        ///// 用于提交表单的按钮组件的交互类型。固定取值 form_submit，表示提交表单。
        ///// </summary>
        //[JsonPropertyName("action_type")]
        //public string ActionType { get; } = "form_submit";

        /// <summary>
        /// 二次确认弹窗配置。指在用户提交时弹出二次确认弹窗提示；只有用户点击确认后，才提交输入的内容。该字段默认提供了确认和取消按钮，你只需要配置弹窗的标题与内容即可。
        /// <para>confirm 字段仅在用户点击包含提交属性的按钮时才会触发二次确认弹窗。</para>
        /// </summary>
        /// <param name="Title">二次确认弹窗标题。</param>
        /// <param name="Text">二次确认弹窗的文本内容。</param>
        public record ConfirmSuffix([property: JsonPropertyName("title")] PlainTextElement Title = default!,
            [property: JsonPropertyName("text")] PlainTextElement Text = default!);
    }

    /// <summary>
    /// 表单容器组件
    /// </summary>
    /// <param name="Name">表单容器的唯一标识。用于识别用户提交的数据属于哪个表单容器。在同一张卡片内，该字段的值全局唯一。</param>
    /// <param name="Elements">表单容器的子节点。可内嵌其它容器类组件和展示、交互组件，不支持内嵌表格、图表、和表单容器组件。</param>
    public record FormContainerElement(string Name = "", object[] Elements = default!) : FormBaseElement("form", Name)
    {
        /// <summary>
        /// 表单容器的子节点。可内嵌其它容器类组件和展示、交互组件，不支持内嵌表格、图表、和表单容器组件。
        /// </summary>
        [property: JsonPropertyName("elements")]
        public object[] Elements { get; set; } = Elements ?? Array.Empty<object>();
    }



}
