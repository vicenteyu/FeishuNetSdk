// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetOkrV1ProgressRecordsByProgressIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取 OKR 进展记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 获取 OKR 进展记录 响应体
/// <para>根据 ID 获取 OKR 进展记录详情。</para>
/// <para>接口ID：7047056455665926145</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/progress_record/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fprogress_record%2fget</para>
/// </summary>
public record GetOkrV1ProgressRecordsByProgressIdResponseDto
{
    /// <summary>
    /// <para>OKR 进展ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7041469619902693396</para>
    /// </summary>
    [JsonPropertyName("progress_id")]
    public string? ProgressId { get; set; }

    /// <summary>
    /// <para>进展更新时间 毫秒</para>
    /// <para>必填：否</para>
    /// <para>示例值：1618500278663</para>
    /// </summary>
    [JsonPropertyName("modify_time")]
    public string? ModifyTime { get; set; }

    /// <summary>
    /// <para>进展 对应的 Content 详细内容</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("content")]
    public ContentBlock? Content { get; set; }

    /// <summary>
    /// <para>进展 对应的 Content 详细内容</para>
    /// </summary>
    public record ContentBlock
    {
        /// <summary>
        /// <para>文档结构是按行排列的，每行内容是一个 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("blocks")]
        public ContentBlockElement[]? Blocks { get; set; }

        /// <summary>
        /// <para>文档结构是按行排列的，每行内容是一个 Block</para>
        /// </summary>
        public record ContentBlockElement
        {
            /// <summary>
            /// <para>文档元素类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：paragraph</para>
            /// <para>可选值：<list type="bullet">
            /// <item>paragraph：文本段落</item>
            /// <item>gallery：图片</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>文本段落</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("paragraph")]
            public ContentParagraph? Paragraph { get; set; }

            /// <summary>
            /// <para>文本段落</para>
            /// </summary>
            public record ContentParagraph
            {
                /// <summary>
                /// <para>段落样式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("style")]
                public ContentParagraphStyle? Style { get; set; }

                /// <summary>
                /// <para>段落样式</para>
                /// </summary>
                public record ContentParagraphStyle
                {
                    /// <summary>
                    /// <para>有序列表/无序列表/任务列表</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("list")]
                    public ContentList? List { get; set; }

                    /// <summary>
                    /// <para>有序列表/无序列表/任务列表</para>
                    /// </summary>
                    public record ContentList
                    {
                        /// <summary>
                        /// <para>列表类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：number</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>number：有序列表</item>
                        /// <item>bullet：无序列表</item>
                        /// <item>checkBox：任务列表</item>
                        /// <item>checkedBox：已完成的任务列表</item>
                        /// <item>indent：tab缩进</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("type")]
                        public string? Type { get; set; }

                        /// <summary>
                        /// <para>列表的缩进级别，支持指定一行的缩进 除代码块以外的列表都支持设置缩进，支持 1-16 级缩进，取值范围：[1,16]</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// </summary>
                        [JsonPropertyName("indentLevel")]
                        public int? IndentLevel { get; set; }

                        /// <summary>
                        /// <para>用于指定列表的行号，仅对有序列表和代码块生效 如果为有序列表设置了缩进，行号可能会显示为字母或者罗马数字</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// </summary>
                        [JsonPropertyName("number")]
                        public int? Number { get; set; }
                    }
                }

                /// <summary>
                /// <para>段落元素组成一个段落</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("elements")]
                public ContentParagraphElement[]? Elements { get; set; }

                /// <summary>
                /// <para>段落元素组成一个段落</para>
                /// </summary>
                public record ContentParagraphElement
                {
                    /// <summary>
                    /// <para>元素类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：textRun</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>textRun：文本型元素</item>
                    /// <item>docsLink：文档链接型元素</item>
                    /// <item>person：艾特用户型元素</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public string? Type { get; set; }

                    /// <summary>
                    /// <para>文本</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("textRun")]
                    public ContentTextRun? TextRun { get; set; }

                    /// <summary>
                    /// <para>文本</para>
                    /// </summary>
                    public record ContentTextRun
                    {
                        /// <summary>
                        /// <para>具体的文本内容</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：周报内容</para>
                        /// </summary>
                        [JsonPropertyName("text")]
                        public string? Text { get; set; }

                        /// <summary>
                        /// <para>文本内容的样式，支持 BIUS、颜色等</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("style")]
                        public ContentTextStyle? Style { get; set; }

                        /// <summary>
                        /// <para>文本内容的样式，支持 BIUS、颜色等</para>
                        /// </summary>
                        public record ContentTextStyle
                        {
                            /// <summary>
                            /// <para>是否加粗</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// </summary>
                            [JsonPropertyName("bold")]
                            public bool? Bold { get; set; }

                            /// <summary>
                            /// <para>是否删除</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// </summary>
                            [JsonPropertyName("strikeThrough")]
                            public bool? StrikeThrough { get; set; }

                            /// <summary>
                            /// <para>背景颜色</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("backColor")]
                            public ContentColor? BackColor { get; set; }

                            /// <summary>
                            /// <para>背景颜色</para>
                            /// </summary>
                            public record ContentColor
                            {
                                /// <summary>
                                /// <para>红 取值范围[0,255]</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：216</para>
                                /// </summary>
                                [JsonPropertyName("red")]
                                public int? Red { get; set; }

                                /// <summary>
                                /// <para>绿 取值范围[0,255]</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：191</para>
                                /// </summary>
                                [JsonPropertyName("green")]
                                public int? Green { get; set; }

                                /// <summary>
                                /// <para>蓝 取值范围[0,255]</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：188</para>
                                /// </summary>
                                [JsonPropertyName("blue")]
                                public int? Blue { get; set; }

                                /// <summary>
                                /// <para>透明度 取值范围[0,1]</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：0.1</para>
                                /// </summary>
                                [JsonPropertyName("alpha")]
                                public float? Alpha { get; set; }
                            }

                            /// <summary>
                            /// <para>字体颜色</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("textColor")]
                            public ContentColor? TextColor { get; set; }

                            /// <summary>
                            /// <para>链接地址</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("link")]
                            public ContentLink? Link { get; set; }

                            /// <summary>
                            /// <para>链接地址</para>
                            /// </summary>
                            public record ContentLink
                            {
                                /// <summary>
                                /// <para>链接地址</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：open.feishu.cn</para>
                                /// </summary>
                                [JsonPropertyName("url")]
                                public string? Url { get; set; }
                            }
                        }
                    }

                    /// <summary>
                    /// <para>飞书云文档</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("docsLink")]
                    public ContentDocsLink? DocsLink { get; set; }

                    /// <summary>
                    /// <para>飞书云文档</para>
                    /// </summary>
                    public record ContentDocsLink
                    {
                        /// <summary>
                        /// <para>飞书云文档链接地址</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：open.feishu.cn</para>
                        /// </summary>
                        [JsonPropertyName("url")]
                        public string? Url { get; set; }

                        /// <summary>
                        /// <para>飞书云文档标题</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：百度</para>
                        /// </summary>
                        [JsonPropertyName("title")]
                        public string? Title { get; set; }
                    }

                    /// <summary>
                    /// <para>艾特用户</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("person")]
                    public ContentPerson? Person { get; set; }

                    /// <summary>
                    /// <para>艾特用户</para>
                    /// </summary>
                    public record ContentPerson
                    {
                        /// <summary>
                        /// <para>员工的OpenID</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：ou_3bbe8a09c20e89cce9bff989ed840674</para>
                        /// </summary>
                        [JsonPropertyName("openId")]
                        public string? OpenId { get; set; }
                    }
                }
            }

            /// <summary>
            /// <para>图片</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("gallery")]
            public ContentGallery? Gallery { get; set; }

            /// <summary>
            /// <para>图片</para>
            /// </summary>
            public record ContentGallery
            {
                /// <summary>
                /// <para>图片元素</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("imageList")]
                public ContentImageItem[]? ImageLists { get; set; }

                /// <summary>
                /// <para>图片元素</para>
                /// </summary>
                public record ContentImageItem
                {
                    /// <summary>
                    /// <para>图片 token，通过上传图片接口获取</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：boxcnOj88GDkmWGm2zsTyCBqoLb</para>
                    /// </summary>
                    [JsonPropertyName("fileToken")]
                    public string? FileToken { get; set; }

                    /// <summary>
                    /// <para>图片链接</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://bytedance.feishu.cn/drive/home/</para>
                    /// </summary>
                    [JsonPropertyName("src")]
                    public string? Src { get; set; }

                    /// <summary>
                    /// <para>图片宽，单位px</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：458</para>
                    /// </summary>
                    [JsonPropertyName("width")]
                    public float? Width { get; set; }

                    /// <summary>
                    /// <para>图片高，单位px</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：372</para>
                    /// </summary>
                    [JsonPropertyName("height")]
                    public float? Height { get; set; }
                }
            }
        }
    }
}
