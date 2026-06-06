// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="PutOkrV2CyclesByCycleIdObjectivesPositionResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改 OKR 目标位置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 修改 OKR 目标位置 响应体
/// <para>通过提供按顺序排列的目标 ID 列表，在指定的 OKR 周期内重新排序目标。</para>
/// <para>接口ID：7644764969658321868</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-cycle/objectives_position</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-cycle%2fobjectives_position</para>
/// </summary>
public record PutOkrV2CyclesByCycleIdObjectivesPositionResponseDto
{
    /// <summary>
    /// <para>目标列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Objective[]? Items { get; set; }

    /// <summary>
    /// <para>目标列表</para>
    /// </summary>
    public record Objective
    {
        /// <summary>
        /// <para>目标的 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7342342398472398473</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>目标的创建时间，毫秒级时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1760604634563</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>目标的更新时间，毫秒级时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1760604634563</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>所有者</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("owner")]
        public OwnerSuffix Owner { get; set; } = new();

        /// <summary>
        /// <para>所有者</para>
        /// </summary>
        public record OwnerSuffix
        {
            /// <summary>
            /// <para>所有者类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：user</para>
            /// <para>可选值：<list type="bullet">
            /// <item>user：员工</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("owner_type")]
            public string OwnerType { get; set; } = string.Empty;

            /// <summary>
            /// <para>员工 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_3bbe8a09c20e89cce9bff989ed840674</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }
        }

        /// <summary>
        /// <para>目标的用户周期 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7342342398472398473</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("cycle_id")]
        public string CycleId { get; set; } = string.Empty;

        /// <summary>
        /// <para>目标的序号：从 1 开始计数</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>最大值：100</para>
        /// <para>最小值：1</para>
        /// </summary>
        [JsonPropertyName("position")]
        public int Position { get; set; }

        /// <summary>
        /// <para>目标的内容</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("content")]
        public ContentBlock? Content { get; set; }

        /// <summary>
        /// <para>目标的内容</para>
        /// </summary>
        public record ContentBlock
        {
            /// <summary>
            /// <para>文档结构是按行排列的，每行内容是一个 Block</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
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
                [JsonPropertyName("block_element_type")]
                public string? BlockElementType { get; set; }

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
                            [JsonPropertyName("list_type")]
                            public string? ListType { get; set; }

                            /// <summary>
                            /// <para>列表的缩进级别，支持指定一行的缩进 除代码块以外的列表都支持设置缩进，支持 1-16 级缩进，取值范围：[1,16]</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>最大值：100</para>
                            /// <para>最小值：0</para>
                            /// </summary>
                            [JsonPropertyName("indent_level")]
                            public int? IndentLevel { get; set; }

                            /// <summary>
                            /// <para>用于指定列表的行号，仅对有序列表和代码块生效 如果为有序列表设置了缩进，行号可能会显示为字母或者罗马数字</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>最大值：100</para>
                            /// <para>最小值：0</para>
                            /// </summary>
                            [JsonPropertyName("number")]
                            public int? Number { get; set; }
                        }
                    }

                    /// <summary>
                    /// <para>段落元素组成一个段落</para>
                    /// <para>必填：否</para>
                    /// <para>最大长度：100</para>
                    /// <para>最小长度：0</para>
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
                        /// <item>mention：艾特对象型元素</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("paragraph_element_type")]
                        public string? ParagraphElementType { get; set; }

                        /// <summary>
                        /// <para>文本</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("text_run")]
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
                                [JsonPropertyName("strike_through")]
                                public bool? StrikeThrough { get; set; }

                                /// <summary>
                                /// <para>背景颜色</para>
                                /// <para>必填：否</para>
                                /// </summary>
                                [JsonPropertyName("back_color")]
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
                                    /// <para>最大值：255</para>
                                    /// <para>最小值：0</para>
                                    /// </summary>
                                    [JsonPropertyName("red")]
                                    public int? Red { get; set; }

                                    /// <summary>
                                    /// <para>绿 取值范围[0,255]</para>
                                    /// <para>必填：否</para>
                                    /// <para>示例值：191</para>
                                    /// <para>最大值：255</para>
                                    /// <para>最小值：0</para>
                                    /// </summary>
                                    [JsonPropertyName("green")]
                                    public int? Green { get; set; }

                                    /// <summary>
                                    /// <para>蓝 取值范围[0,255]</para>
                                    /// <para>必填：否</para>
                                    /// <para>示例值：188</para>
                                    /// <para>最大值：255</para>
                                    /// <para>最小值：0</para>
                                    /// </summary>
                                    [JsonPropertyName("blue")]
                                    public int? Blue { get; set; }

                                    /// <summary>
                                    /// <para>透明度 取值范围[0,1]</para>
                                    /// <para>必填：否</para>
                                    /// <para>示例值：0.1</para>
                                    /// <para>最大值：1</para>
                                    /// <para>最小值：0</para>
                                    /// </summary>
                                    [JsonPropertyName("alpha")]
                                    public double? Alpha { get; set; }
                                }

                                /// <summary>
                                /// <para>字体颜色</para>
                                /// <para>必填：否</para>
                                /// </summary>
                                [JsonPropertyName("text_color")]
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
                                    /// <para>最小长度：1</para>
                                    /// </summary>
                                    [JsonPropertyName("url")]
                                    public string? Url { get; set; }
                                }
                            }
                        }

                        /// <summary>
                        /// <para>文档链接，可以根据链接自动识别为标题</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("docs_link")]
                        public ContentDocsLink? DocsLink { get; set; }

                        /// <summary>
                        /// <para>文档链接，可以根据链接自动识别为标题</para>
                        /// </summary>
                        public record ContentDocsLink
                        {
                            /// <summary>
                            /// <para>链接地址</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：open.feishu.cn</para>
                            /// <para>最小长度：1</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string? Url { get; set; }

                            /// <summary>
                            /// <para>链接文案</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：百度</para>
                            /// <para>最小长度：1</para>
                            /// </summary>
                            [JsonPropertyName("title")]
                            public string? Title { get; set; }
                        }

                        /// <summary>
                        /// <para>艾特对象</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("mention")]
                        public ContentMention? Mention { get; set; }

                        /// <summary>
                        /// <para>艾特对象</para>
                        /// </summary>
                        public record ContentMention
                        {
                            /// <summary>
                            /// <para>员工 ID</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：ou_3bbe8a09c20e89cce9bff989ed840674</para>
                            /// </summary>
                            [JsonPropertyName("user_id")]
                            public string? UserId { get; set; }
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
                    /// <para>最大长度：100</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("images")]
                    public ContentImageItem[]? Images { get; set; }

                    /// <summary>
                    /// <para>图片元素</para>
                    /// </summary>
                    public record ContentImageItem
                    {
                        /// <summary>
                        /// <para>图片 token，比如boxcnOj88GDkmWGm2zsTyCBqoLb，不支持编辑</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：boxcnOj88GDkmWGm2zsTyCBqoLb</para>
                        /// <para>最小长度：1</para>
                        /// </summary>
                        [JsonPropertyName("file_token")]
                        public string? FileToken { get; set; }

                        /// <summary>
                        /// <para>图片链接</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://bytedance.feishu.cn/drive/home/</para>
                        /// <para>最小长度：1</para>
                        /// </summary>
                        [JsonPropertyName("src")]
                        public string? Src { get; set; }

                        /// <summary>
                        /// <para>图片宽，单位px</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：458</para>
                        /// <para>最大值：10000</para>
                        /// <para>最小值：0</para>
                        /// </summary>
                        [JsonPropertyName("width")]
                        public double? Width { get; set; }

                        /// <summary>
                        /// <para>图片高，单位px</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：372</para>
                        /// <para>最大值：10000</para>
                        /// <para>最小值：0</para>
                        /// </summary>
                        [JsonPropertyName("height")]
                        public double? Height { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>目标的分数：[0,1]，支持一位小数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0.5</para>
        /// <para>最大值：1</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// <para>目标的备注</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("notes")]
        public ContentBlock? Notes { get; set; }

        /// <summary>
        /// <para>目标的权重：[0,1]，支持三位小数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0.5</para>
        /// <para>最大值：1</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// <para>目标的截止时间，毫秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1760604634563</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("deadline")]
        public string? Deadline { get; set; }

        /// <summary>
        /// <para>目标的分类 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7342342398472398473</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("category_id")]
        public string? CategoryId { get; set; }
    }
}
