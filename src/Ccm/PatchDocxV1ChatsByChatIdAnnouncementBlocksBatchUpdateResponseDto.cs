// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PatchDocxV1ChatsByChatIdAnnouncementBlocksBatchUpdateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量更新群公告块的内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 批量更新群公告块的内容 响应体
/// <para>接口ID：7450053428095549468</para>
/// <para>文档地址：https://open.feishu.cn/document/group/upgraded-group-announcement/chat-announcement-block/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fchat-announcement-block%2fbatch_update</para>
/// </summary>
public record PatchDocxV1ChatsByChatIdAnnouncementBlocksBatchUpdateResponseDto
{
    /// <summary>
    /// <para>批量更新的 Block</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("blocks")]
    public Block[]? Blocks { get; set; }

    /// <summary>
    /// <para>批量更新的 Block</para>
    /// </summary>
    public record Block
    {
        /// <summary>
        /// <para>Block 唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：doxcnSS4ouQkQEouGSUkTg9NJPe</para>
        /// </summary>
        [JsonPropertyName("block_id")]
        public string? BlockId { get; set; }

        /// <summary>
        /// <para>block 的父亲 id</para>
        /// <para>必填：否</para>
        /// <para>示例值：doxcnePuYufKa49ISjhD8Ih0ikh</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// <para>block 的孩子 id 列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：[doxcnO6UW6wAw2qIcYf4hZpFIth]</para>
        /// </summary>
        [JsonPropertyName("children")]
        public string[]? Children { get; set; }

        /// <summary>
        /// <para>block 类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：页面 Block</item>
        /// <item>2：文本 Block</item>
        /// <item>3：标题 1 Block</item>
        /// <item>4：标题 2 Block</item>
        /// <item>5：标题 3 Block</item>
        /// <item>6：标题 4 Block</item>
        /// <item>7：标题 5 Block</item>
        /// <item>8：标题 6 Block</item>
        /// <item>9：标题 7 Block</item>
        /// <item>10：标题 8 Block</item>
        /// <item>11：标题 9 Block</item>
        /// <item>12：无序列表 Block</item>
        /// <item>13：有序列表 Block</item>
        /// <item>14：代码块 Block</item>
        /// <item>15：引用 Block</item>
        /// <item>17：待办事项 Block</item>
        /// <item>18：多维表格 Block</item>
        /// <item>19：高亮块 Block</item>
        /// <item>20：会话卡片 Block</item>
        /// <item>21：流程图 &amp; UML Block</item>
        /// <item>22：分割线 Block</item>
        /// <item>23：文件 Block</item>
        /// <item>24：分栏 Block</item>
        /// <item>25：分栏列 Block</item>
        /// <item>26：内嵌 Block Block</item>
        /// <item>27：图片 Block</item>
        /// <item>28：开放平台小组件 Block</item>
        /// <item>29：思维笔记 Block</item>
        /// <item>30：电子表格 Block</item>
        /// <item>31：表格 Block</item>
        /// <item>32：表格单元格 Block</item>
        /// <item>33：视图 Block</item>
        /// <item>34：引用容器 Block</item>
        /// <item>35：任务 Block</item>
        /// <item>36：OKR Block</item>
        /// <item>37：OKR Objective</item>
        /// <item>38：OKR Key Result</item>
        /// <item>39：OKR 进展</item>
        /// <item>40：文档小组件</item>
        /// <item>41：Jira Issue</item>
        /// <item>42：Wiki 子目录 Block</item>
        /// <item>43：画板 Block</item>
        /// <item>44：议程 Block</item>
        /// <item>45：议程项 Block</item>
        /// <item>46：议程项标题 Block</item>
        /// <item>47：议程项内容 Block</item>
        /// <item>48：链接预览 Block</item>
        /// <item>999：未支持 Block</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("block_type")]
        public int BlockType { get; set; }

        /// <summary>
        /// <para>文档 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("page")]
        public PageSuffix? Page { get; set; }

        /// <summary>
        /// <para>文档 Block</para>
        /// </summary>
        public record PageSuffix
        {
            /// <summary>
            /// <para>文本样式</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("style")]
            public TextStyle? Style { get; set; }

            /// <summary>
            /// <para>文本样式</para>
            /// </summary>
            public record TextStyle
            {
                /// <summary>
                /// <para>对齐方式</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：居左排版</item>
                /// <item>2：居中排版</item>
                /// <item>3：居右排版</item>
                /// </list></para>
                /// <para>默认值：1</para>
                /// </summary>
                [JsonPropertyName("align")]
                public int? Align { get; set; }

                /// <summary>
                /// <para>todo 的完成状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("done")]
                public bool? Done { get; set; }

                /// <summary>
                /// <para>文本的折叠状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("folded")]
                public bool? Folded { get; set; }

                /// <summary>
                /// <para>代码块语言</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：PlainText</item>
                /// <item>2：ABAP</item>
                /// <item>3：Ada</item>
                /// <item>4：Apache</item>
                /// <item>5：Apex</item>
                /// <item>6：Assembly Language</item>
                /// <item>7：Bash</item>
                /// <item>8：CSharp</item>
                /// <item>9：C++</item>
                /// <item>10：C</item>
                /// <item>11：COBOL</item>
                /// <item>12：CSS</item>
                /// <item>13：CoffeeScript</item>
                /// <item>14：D</item>
                /// <item>15：Dart</item>
                /// <item>16：Delphi</item>
                /// <item>17：Django</item>
                /// <item>18：Dockerfile</item>
                /// <item>19：Erlang</item>
                /// <item>20：Fortran</item>
                /// <item>21：FoxPro（已废弃）</item>
                /// <item>22：Go</item>
                /// <item>23：Groovy</item>
                /// <item>24：HTML</item>
                /// <item>25：HTMLBars</item>
                /// <item>26：HTTP</item>
                /// <item>27：Haskell</item>
                /// <item>28：JSON</item>
                /// <item>29：Java</item>
                /// <item>30：JavaScript</item>
                /// <item>31：Julia</item>
                /// <item>32：Kotlin</item>
                /// <item>33：LateX</item>
                /// <item>34：Lisp</item>
                /// <item>35：Logo（已废弃）</item>
                /// <item>36：Lua</item>
                /// <item>37：MATLAB</item>
                /// <item>38：Makefile</item>
                /// <item>39：Markdown</item>
                /// <item>40：Nginx</item>
                /// <item>41：Objective-C</item>
                /// <item>42：OpenEdgeABL（已废弃）</item>
                /// <item>43：PHP</item>
                /// <item>44：Perl</item>
                /// <item>45：PostScript（已废弃）</item>
                /// <item>46：Power Shell</item>
                /// <item>47：Prolog</item>
                /// <item>48：ProtoBuf</item>
                /// <item>49：Python</item>
                /// <item>50：R</item>
                /// <item>51：RPG（已废弃）</item>
                /// <item>52：Ruby</item>
                /// <item>53：Rust</item>
                /// <item>54：SAS</item>
                /// <item>55：SCSS</item>
                /// <item>56：SQL</item>
                /// <item>57：Scala</item>
                /// <item>58：Scheme</item>
                /// <item>59：Scratch（已废弃）</item>
                /// <item>60：Shell</item>
                /// <item>61：Swift</item>
                /// <item>62：Thrift</item>
                /// <item>63：TypeScript</item>
                /// <item>64：VBScript</item>
                /// <item>65：Visual Basic</item>
                /// <item>66：XML</item>
                /// <item>67：YAML</item>
                /// <item>68：CMake</item>
                /// <item>69：Diff</item>
                /// <item>70：Gherkin</item>
                /// <item>71：GraphQL</item>
                /// <item>72：OpenGL Shading Language</item>
                /// <item>73：Properties</item>
                /// <item>74：Solidity</item>
                /// <item>75：TOML</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("language")]
                public int? Language { get; set; }

                /// <summary>
                /// <para>代码块是否自动换行</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("wrap")]
                public bool? Wrap { get; set; }

                /// <summary>
                /// <para>块背景色</para>
                /// <para>必填：否</para>
                /// <para>示例值：LightGrayBackground</para>
                /// <para>可选值：<list type="bullet">
                /// <item>LightGrayBackground：浅灰色</item>
                /// <item>LightRedBackground：浅红色</item>
                /// <item>LightOrangeBackground：浅橙色</item>
                /// <item>LightYellowBackground：浅黄色</item>
                /// <item>LightGreenBackground：浅绿色</item>
                /// <item>LightBlueBackground：浅蓝色</item>
                /// <item>LightPurpleBackground：浅紫色</item>
                /// <item>PaleGrayBackground：淡灰色</item>
                /// <item>DarkGrayBackground：深灰色</item>
                /// <item>DarkRedBackground：深红色</item>
                /// <item>DarkOrangeBackground：深橙色</item>
                /// <item>DarkYellowBackground：深黄色</item>
                /// <item>DarkGreenBackground：深绿色</item>
                /// <item>DarkBlueBackground：深蓝色</item>
                /// <item>DarkPurpleBackground：深紫色</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("background_color")]
                public string? BackgroundColor { get; set; }

                /// <summary>
                /// <para>首行缩进级别</para>
                /// <para>必填：否</para>
                /// <para>示例值：NoIndent</para>
                /// <para>可选值：<list type="bullet">
                /// <item>NoIndent：无缩进</item>
                /// <item>OneLevelIndent：一级缩进</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("indentation_level")]
                public string? IndentationLevel { get; set; }

                /// <summary>
                /// <para>用于确定有序列表项编号，为具体数值或'auto'</para>
                /// <para>必填：否</para>
                /// <para>示例值："auto"</para>
                /// </summary>
                [JsonPropertyName("sequence")]
                public string? Sequence { get; set; }
            }

            /// <summary>
            /// <para>文本元素</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("elements")]
            public TextElement[] Elements { get; set; } = Array.Empty<TextElement>();

            /// <summary>
            /// <para>文本元素</para>
            /// </summary>
            public record TextElement
            {
                /// <summary>
                /// <para>文字</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("text_run")]
                public TextElementTextRun? TextRun { get; set; }

                /// <summary>
                /// <para>文字</para>
                /// </summary>
                public record TextElementTextRun
                {
                    /// <summary>
                    /// <para>文本内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：文本</para>
                    /// </summary>
                    [JsonPropertyName("content")]
                    public string Content { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementTextRunTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementTextRunTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementTextRunTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementTextRunTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>@用户</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mention_user")]
                public TextElementMentionUser? MentionUser { get; set; }

                /// <summary>
                /// <para>@用户</para>
                /// </summary>
                public record TextElementMentionUser
                {
                    /// <summary>
                    /// <para>用户 OpenID</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：ou_3bbe8a09c20e89cce9bff989ed840674</para>
                    /// </summary>
                    [JsonPropertyName("user_id")]
                    public string UserId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementMentionUserTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementMentionUserTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementMentionUserTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementMentionUserTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>@文档</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mention_doc")]
                public TextElementMentionDoc? MentionDoc { get; set; }

                /// <summary>
                /// <para>@文档</para>
                /// </summary>
                public record TextElementMentionDoc
                {
                    /// <summary>
                    /// <para>云文档 token</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：doxbc873Y7cXD153gXqb76G1Y9b</para>
                    /// </summary>
                    [JsonPropertyName("token")]
                    public string Token { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>云文档类型</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：22</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：Doc</item>
                    /// <item>3：Sheet</item>
                    /// <item>8：Bitable</item>
                    /// <item>11：MindNote</item>
                    /// <item>12：File</item>
                    /// <item>15：Slide</item>
                    /// <item>16：Wiki</item>
                    /// <item>22：Docx</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("obj_type")]
                    public int ObjType { get; set; }

                    /// <summary>
                    /// <para>云文档链接（需要 url_encode)</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：https%3A%2F%2Fbytedance.feishu-boe.cn%2Fdocx%2Fdoxbc873Y7cXD153gXqb76G1Y9b</para>
                    /// </summary>
                    [JsonPropertyName("url")]
                    public string Url { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文档标题，只读属性</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：undefined</para>
                    /// <para>最大长度：800</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("title")]
                    public string? Title { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementMentionDocTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementMentionDocTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementMentionDocTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementMentionDocTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>日期提醒</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("reminder")]
                public TextElementReminder? Reminder { get; set; }

                /// <summary>
                /// <para>日期提醒</para>
                /// </summary>
                public record TextElementReminder
                {
                    /// <summary>
                    /// <para>创建者用户 ID</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：0e2633a3-aa1a-4171-af9e-0768ff863566</para>
                    /// </summary>
                    [JsonPropertyName("create_user_id")]
                    public string CreateUserId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>是否通知</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonPropertyName("is_notify")]
                    public bool? IsNotify { get; set; }

                    /// <summary>
                    /// <para>是日期还是整点小时</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonPropertyName("is_whole_day")]
                    public bool? IsWholeDay { get; set; }

                    /// <summary>
                    /// <para>事件发生的时间（毫秒级事件戳）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1641967200000</para>
                    /// </summary>
                    [JsonPropertyName("expire_time")]
                    public string ExpireTime { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>触发通知的时间（毫秒级时间戳）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1643166000000</para>
                    /// </summary>
                    [JsonPropertyName("notify_time")]
                    public string NotifyTime { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementReminderTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementReminderTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementReminderTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementReminderTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>内联附件</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("file")]
                public InlineFile? File { get; set; }

                /// <summary>
                /// <para>内联附件</para>
                /// </summary>
                public record InlineFile
                {
                    /// <summary>
                    /// <para>附件 token</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：boxcnOj88GDkmWGm2zsTyCBqoLb</para>
                    /// </summary>
                    [JsonPropertyName("file_token")]
                    public string? FileToken { get; set; }

                    /// <summary>
                    /// <para>当前文档中该附件所处的 block 的 id</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：doxcnM46kSWSkgUMW04ldKsJDsc</para>
                    /// </summary>
                    [JsonPropertyName("source_block_id")]
                    public string? SourceBlockId { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public InlineFileTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record InlineFileTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public InlineFileTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record InlineFileTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>未支持的 TextElement</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("undefined")]
                public object? Undefined { get; set; }

                /// <summary>
                /// <para>内联 block</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("inline_block")]
                public TextElementInlineBlock? InlineBlock { get; set; }

                /// <summary>
                /// <para>内联 block</para>
                /// </summary>
                public record TextElementInlineBlock
                {
                    /// <summary>
                    /// <para>关联的内联状态的 block 的 block_id</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：doxcnPFi0R56ctbvh2MjkkROFWf</para>
                    /// </summary>
                    [JsonPropertyName("block_id")]
                    public string BlockId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementInlineBlockTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementInlineBlockTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementInlineBlockTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementInlineBlockTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>公式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("equation")]
                public TextElementEquation? Equation { get; set; }

                /// <summary>
                /// <para>公式</para>
                /// </summary>
                public record TextElementEquation
                {
                    /// <summary>
                    /// <para>符合 KaTeX 语法的公式内容，语法规则请参考：https://katex.org/docs/supported.html</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：E=mc^2\n</para>
                    /// </summary>
                    [JsonPropertyName("content")]
                    public string Content { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementEquationTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementEquationTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementEquationTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementEquationTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>文本 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("text")]
        public BlockText? Text { get; set; }

        /// <summary>
        /// <para>文本 Block</para>
        /// </summary>
        public record BlockText
        {
            /// <summary>
            /// <para>文本样式</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("style")]
            public TextStyle? Style { get; set; }

            /// <summary>
            /// <para>文本样式</para>
            /// </summary>
            public record TextStyle
            {
                /// <summary>
                /// <para>对齐方式</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：居左排版</item>
                /// <item>2：居中排版</item>
                /// <item>3：居右排版</item>
                /// </list></para>
                /// <para>默认值：1</para>
                /// </summary>
                [JsonPropertyName("align")]
                public int? Align { get; set; }

                /// <summary>
                /// <para>todo 的完成状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("done")]
                public bool? Done { get; set; }

                /// <summary>
                /// <para>文本的折叠状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("folded")]
                public bool? Folded { get; set; }

                /// <summary>
                /// <para>代码块语言</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：PlainText</item>
                /// <item>2：ABAP</item>
                /// <item>3：Ada</item>
                /// <item>4：Apache</item>
                /// <item>5：Apex</item>
                /// <item>6：Assembly Language</item>
                /// <item>7：Bash</item>
                /// <item>8：CSharp</item>
                /// <item>9：C++</item>
                /// <item>10：C</item>
                /// <item>11：COBOL</item>
                /// <item>12：CSS</item>
                /// <item>13：CoffeeScript</item>
                /// <item>14：D</item>
                /// <item>15：Dart</item>
                /// <item>16：Delphi</item>
                /// <item>17：Django</item>
                /// <item>18：Dockerfile</item>
                /// <item>19：Erlang</item>
                /// <item>20：Fortran</item>
                /// <item>21：FoxPro（已废弃）</item>
                /// <item>22：Go</item>
                /// <item>23：Groovy</item>
                /// <item>24：HTML</item>
                /// <item>25：HTMLBars</item>
                /// <item>26：HTTP</item>
                /// <item>27：Haskell</item>
                /// <item>28：JSON</item>
                /// <item>29：Java</item>
                /// <item>30：JavaScript</item>
                /// <item>31：Julia</item>
                /// <item>32：Kotlin</item>
                /// <item>33：LateX</item>
                /// <item>34：Lisp</item>
                /// <item>35：Logo（已废弃）</item>
                /// <item>36：Lua</item>
                /// <item>37：MATLAB</item>
                /// <item>38：Makefile</item>
                /// <item>39：Markdown</item>
                /// <item>40：Nginx</item>
                /// <item>41：Objective-C</item>
                /// <item>42：OpenEdgeABL（已废弃）</item>
                /// <item>43：PHP</item>
                /// <item>44：Perl</item>
                /// <item>45：PostScript（已废弃）</item>
                /// <item>46：Power Shell</item>
                /// <item>47：Prolog</item>
                /// <item>48：ProtoBuf</item>
                /// <item>49：Python</item>
                /// <item>50：R</item>
                /// <item>51：RPG（已废弃）</item>
                /// <item>52：Ruby</item>
                /// <item>53：Rust</item>
                /// <item>54：SAS</item>
                /// <item>55：SCSS</item>
                /// <item>56：SQL</item>
                /// <item>57：Scala</item>
                /// <item>58：Scheme</item>
                /// <item>59：Scratch（已废弃）</item>
                /// <item>60：Shell</item>
                /// <item>61：Swift</item>
                /// <item>62：Thrift</item>
                /// <item>63：TypeScript</item>
                /// <item>64：VBScript</item>
                /// <item>65：Visual Basic</item>
                /// <item>66：XML</item>
                /// <item>67：YAML</item>
                /// <item>68：CMake</item>
                /// <item>69：Diff</item>
                /// <item>70：Gherkin</item>
                /// <item>71：GraphQL</item>
                /// <item>72：OpenGL Shading Language</item>
                /// <item>73：Properties</item>
                /// <item>74：Solidity</item>
                /// <item>75：TOML</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("language")]
                public int? Language { get; set; }

                /// <summary>
                /// <para>代码块是否自动换行</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("wrap")]
                public bool? Wrap { get; set; }

                /// <summary>
                /// <para>块背景色</para>
                /// <para>必填：否</para>
                /// <para>示例值：LightGrayBackground</para>
                /// <para>可选值：<list type="bullet">
                /// <item>LightGrayBackground：浅灰色</item>
                /// <item>LightRedBackground：浅红色</item>
                /// <item>LightOrangeBackground：浅橙色</item>
                /// <item>LightYellowBackground：浅黄色</item>
                /// <item>LightGreenBackground：浅绿色</item>
                /// <item>LightBlueBackground：浅蓝色</item>
                /// <item>LightPurpleBackground：浅紫色</item>
                /// <item>PaleGrayBackground：淡灰色</item>
                /// <item>DarkGrayBackground：深灰色</item>
                /// <item>DarkRedBackground：深红色</item>
                /// <item>DarkOrangeBackground：深橙色</item>
                /// <item>DarkYellowBackground：深黄色</item>
                /// <item>DarkGreenBackground：深绿色</item>
                /// <item>DarkBlueBackground：深蓝色</item>
                /// <item>DarkPurpleBackground：深紫色</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("background_color")]
                public string? BackgroundColor { get; set; }

                /// <summary>
                /// <para>首行缩进级别</para>
                /// <para>必填：否</para>
                /// <para>示例值：NoIndent</para>
                /// <para>可选值：<list type="bullet">
                /// <item>NoIndent：无缩进</item>
                /// <item>OneLevelIndent：一级缩进</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("indentation_level")]
                public string? IndentationLevel { get; set; }

                /// <summary>
                /// <para>用于确定有序列表项编号，为具体数值或'auto'</para>
                /// <para>必填：否</para>
                /// <para>示例值："auto"</para>
                /// </summary>
                [JsonPropertyName("sequence")]
                public string? Sequence { get; set; }
            }

            /// <summary>
            /// <para>文本元素</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("elements")]
            public TextElement[] Elements { get; set; } = Array.Empty<TextElement>();

            /// <summary>
            /// <para>文本元素</para>
            /// </summary>
            public record TextElement
            {
                /// <summary>
                /// <para>文字</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("text_run")]
                public TextElementTextRun? TextRun { get; set; }

                /// <summary>
                /// <para>文字</para>
                /// </summary>
                public record TextElementTextRun
                {
                    /// <summary>
                    /// <para>文本内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：文本</para>
                    /// </summary>
                    [JsonPropertyName("content")]
                    public string Content { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementTextRunTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementTextRunTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementTextRunTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementTextRunTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>@用户</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mention_user")]
                public TextElementMentionUser? MentionUser { get; set; }

                /// <summary>
                /// <para>@用户</para>
                /// </summary>
                public record TextElementMentionUser
                {
                    /// <summary>
                    /// <para>用户 OpenID</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：ou_3bbe8a09c20e89cce9bff989ed840674</para>
                    /// </summary>
                    [JsonPropertyName("user_id")]
                    public string UserId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementMentionUserTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementMentionUserTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementMentionUserTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementMentionUserTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>@文档</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mention_doc")]
                public TextElementMentionDoc? MentionDoc { get; set; }

                /// <summary>
                /// <para>@文档</para>
                /// </summary>
                public record TextElementMentionDoc
                {
                    /// <summary>
                    /// <para>云文档 token</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：doxbc873Y7cXD153gXqb76G1Y9b</para>
                    /// </summary>
                    [JsonPropertyName("token")]
                    public string Token { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>云文档类型</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：22</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：Doc</item>
                    /// <item>3：Sheet</item>
                    /// <item>8：Bitable</item>
                    /// <item>11：MindNote</item>
                    /// <item>12：File</item>
                    /// <item>15：Slide</item>
                    /// <item>16：Wiki</item>
                    /// <item>22：Docx</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("obj_type")]
                    public int ObjType { get; set; }

                    /// <summary>
                    /// <para>云文档链接（需要 url_encode)</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：https%3A%2F%2Fbytedance.feishu-boe.cn%2Fdocx%2Fdoxbc873Y7cXD153gXqb76G1Y9b</para>
                    /// </summary>
                    [JsonPropertyName("url")]
                    public string Url { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文档标题，只读属性</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：undefined</para>
                    /// <para>最大长度：800</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("title")]
                    public string? Title { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementMentionDocTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementMentionDocTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementMentionDocTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementMentionDocTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>日期提醒</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("reminder")]
                public TextElementReminder? Reminder { get; set; }

                /// <summary>
                /// <para>日期提醒</para>
                /// </summary>
                public record TextElementReminder
                {
                    /// <summary>
                    /// <para>创建者用户 ID</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：0e2633a3-aa1a-4171-af9e-0768ff863566</para>
                    /// </summary>
                    [JsonPropertyName("create_user_id")]
                    public string CreateUserId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>是否通知</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonPropertyName("is_notify")]
                    public bool? IsNotify { get; set; }

                    /// <summary>
                    /// <para>是日期还是整点小时</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonPropertyName("is_whole_day")]
                    public bool? IsWholeDay { get; set; }

                    /// <summary>
                    /// <para>事件发生的时间（毫秒级事件戳）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1641967200000</para>
                    /// </summary>
                    [JsonPropertyName("expire_time")]
                    public string ExpireTime { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>触发通知的时间（毫秒级时间戳）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1643166000000</para>
                    /// </summary>
                    [JsonPropertyName("notify_time")]
                    public string NotifyTime { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementReminderTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementReminderTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementReminderTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementReminderTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>内联附件</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("file")]
                public InlineFile? File { get; set; }

                /// <summary>
                /// <para>内联附件</para>
                /// </summary>
                public record InlineFile
                {
                    /// <summary>
                    /// <para>附件 token</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：boxcnOj88GDkmWGm2zsTyCBqoLb</para>
                    /// </summary>
                    [JsonPropertyName("file_token")]
                    public string? FileToken { get; set; }

                    /// <summary>
                    /// <para>当前文档中该附件所处的 block 的 id</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：doxcnM46kSWSkgUMW04ldKsJDsc</para>
                    /// </summary>
                    [JsonPropertyName("source_block_id")]
                    public string? SourceBlockId { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public InlineFileTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record InlineFileTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public InlineFileTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record InlineFileTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>未支持的 TextElement</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("undefined")]
                public object? Undefined { get; set; }

                /// <summary>
                /// <para>内联 block</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("inline_block")]
                public TextElementInlineBlock? InlineBlock { get; set; }

                /// <summary>
                /// <para>内联 block</para>
                /// </summary>
                public record TextElementInlineBlock
                {
                    /// <summary>
                    /// <para>关联的内联状态的 block 的 block_id</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：doxcnPFi0R56ctbvh2MjkkROFWf</para>
                    /// </summary>
                    [JsonPropertyName("block_id")]
                    public string BlockId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementInlineBlockTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementInlineBlockTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementInlineBlockTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementInlineBlockTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>公式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("equation")]
                public TextElementEquation? Equation { get; set; }

                /// <summary>
                /// <para>公式</para>
                /// </summary>
                public record TextElementEquation
                {
                    /// <summary>
                    /// <para>符合 KaTeX 语法的公式内容，语法规则请参考：https://katex.org/docs/supported.html</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：E=mc^2\n</para>
                    /// </summary>
                    [JsonPropertyName("content")]
                    public string Content { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementEquationTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementEquationTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementEquationTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementEquationTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>一级标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("heading1")]
        public TextSuffix? Heading1 { get; set; }

        /// <summary>
        /// <para>一级标题 Block</para>
        /// </summary>
        public record TextSuffix
        {
            /// <summary>
            /// <para>文本样式</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("style")]
            public TextStyle? Style { get; set; }

            /// <summary>
            /// <para>文本样式</para>
            /// </summary>
            public record TextStyle
            {
                /// <summary>
                /// <para>对齐方式</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：居左排版</item>
                /// <item>2：居中排版</item>
                /// <item>3：居右排版</item>
                /// </list></para>
                /// <para>默认值：1</para>
                /// </summary>
                [JsonPropertyName("align")]
                public int? Align { get; set; }

                /// <summary>
                /// <para>todo 的完成状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("done")]
                public bool? Done { get; set; }

                /// <summary>
                /// <para>文本的折叠状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("folded")]
                public bool? Folded { get; set; }

                /// <summary>
                /// <para>代码块语言</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：PlainText</item>
                /// <item>2：ABAP</item>
                /// <item>3：Ada</item>
                /// <item>4：Apache</item>
                /// <item>5：Apex</item>
                /// <item>6：Assembly Language</item>
                /// <item>7：Bash</item>
                /// <item>8：CSharp</item>
                /// <item>9：C++</item>
                /// <item>10：C</item>
                /// <item>11：COBOL</item>
                /// <item>12：CSS</item>
                /// <item>13：CoffeeScript</item>
                /// <item>14：D</item>
                /// <item>15：Dart</item>
                /// <item>16：Delphi</item>
                /// <item>17：Django</item>
                /// <item>18：Dockerfile</item>
                /// <item>19：Erlang</item>
                /// <item>20：Fortran</item>
                /// <item>21：FoxPro（已废弃）</item>
                /// <item>22：Go</item>
                /// <item>23：Groovy</item>
                /// <item>24：HTML</item>
                /// <item>25：HTMLBars</item>
                /// <item>26：HTTP</item>
                /// <item>27：Haskell</item>
                /// <item>28：JSON</item>
                /// <item>29：Java</item>
                /// <item>30：JavaScript</item>
                /// <item>31：Julia</item>
                /// <item>32：Kotlin</item>
                /// <item>33：LateX</item>
                /// <item>34：Lisp</item>
                /// <item>35：Logo（已废弃）</item>
                /// <item>36：Lua</item>
                /// <item>37：MATLAB</item>
                /// <item>38：Makefile</item>
                /// <item>39：Markdown</item>
                /// <item>40：Nginx</item>
                /// <item>41：Objective-C</item>
                /// <item>42：OpenEdgeABL（已废弃）</item>
                /// <item>43：PHP</item>
                /// <item>44：Perl</item>
                /// <item>45：PostScript（已废弃）</item>
                /// <item>46：Power Shell</item>
                /// <item>47：Prolog</item>
                /// <item>48：ProtoBuf</item>
                /// <item>49：Python</item>
                /// <item>50：R</item>
                /// <item>51：RPG（已废弃）</item>
                /// <item>52：Ruby</item>
                /// <item>53：Rust</item>
                /// <item>54：SAS</item>
                /// <item>55：SCSS</item>
                /// <item>56：SQL</item>
                /// <item>57：Scala</item>
                /// <item>58：Scheme</item>
                /// <item>59：Scratch（已废弃）</item>
                /// <item>60：Shell</item>
                /// <item>61：Swift</item>
                /// <item>62：Thrift</item>
                /// <item>63：TypeScript</item>
                /// <item>64：VBScript</item>
                /// <item>65：Visual Basic</item>
                /// <item>66：XML</item>
                /// <item>67：YAML</item>
                /// <item>68：CMake</item>
                /// <item>69：Diff</item>
                /// <item>70：Gherkin</item>
                /// <item>71：GraphQL</item>
                /// <item>72：OpenGL Shading Language</item>
                /// <item>73：Properties</item>
                /// <item>74：Solidity</item>
                /// <item>75：TOML</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("language")]
                public int? Language { get; set; }

                /// <summary>
                /// <para>代码块是否自动换行</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("wrap")]
                public bool? Wrap { get; set; }

                /// <summary>
                /// <para>块背景色</para>
                /// <para>必填：否</para>
                /// <para>示例值：LightGrayBackground</para>
                /// <para>可选值：<list type="bullet">
                /// <item>LightGrayBackground：浅灰色</item>
                /// <item>LightRedBackground：浅红色</item>
                /// <item>LightOrangeBackground：浅橙色</item>
                /// <item>LightYellowBackground：浅黄色</item>
                /// <item>LightGreenBackground：浅绿色</item>
                /// <item>LightBlueBackground：浅蓝色</item>
                /// <item>LightPurpleBackground：浅紫色</item>
                /// <item>PaleGrayBackground：淡灰色</item>
                /// <item>DarkGrayBackground：深灰色</item>
                /// <item>DarkRedBackground：深红色</item>
                /// <item>DarkOrangeBackground：深橙色</item>
                /// <item>DarkYellowBackground：深黄色</item>
                /// <item>DarkGreenBackground：深绿色</item>
                /// <item>DarkBlueBackground：深蓝色</item>
                /// <item>DarkPurpleBackground：深紫色</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("background_color")]
                public string? BackgroundColor { get; set; }

                /// <summary>
                /// <para>首行缩进级别</para>
                /// <para>必填：否</para>
                /// <para>示例值：NoIndent</para>
                /// <para>可选值：<list type="bullet">
                /// <item>NoIndent：无缩进</item>
                /// <item>OneLevelIndent：一级缩进</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("indentation_level")]
                public string? IndentationLevel { get; set; }

                /// <summary>
                /// <para>用于确定有序列表项编号，为具体数值或'auto'</para>
                /// <para>必填：否</para>
                /// <para>示例值："auto"</para>
                /// </summary>
                [JsonPropertyName("sequence")]
                public string? Sequence { get; set; }
            }

            /// <summary>
            /// <para>文本元素</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("elements")]
            public TextElement[] Elements { get; set; } = Array.Empty<TextElement>();

            /// <summary>
            /// <para>文本元素</para>
            /// </summary>
            public record TextElement
            {
                /// <summary>
                /// <para>文字</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("text_run")]
                public TextElementTextRun? TextRun { get; set; }

                /// <summary>
                /// <para>文字</para>
                /// </summary>
                public record TextElementTextRun
                {
                    /// <summary>
                    /// <para>文本内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：文本</para>
                    /// </summary>
                    [JsonPropertyName("content")]
                    public string Content { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementTextRunTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementTextRunTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementTextRunTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementTextRunTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>@用户</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mention_user")]
                public TextElementMentionUser? MentionUser { get; set; }

                /// <summary>
                /// <para>@用户</para>
                /// </summary>
                public record TextElementMentionUser
                {
                    /// <summary>
                    /// <para>用户 OpenID</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：ou_3bbe8a09c20e89cce9bff989ed840674</para>
                    /// </summary>
                    [JsonPropertyName("user_id")]
                    public string UserId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementMentionUserTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementMentionUserTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementMentionUserTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementMentionUserTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>@文档</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mention_doc")]
                public TextElementMentionDoc? MentionDoc { get; set; }

                /// <summary>
                /// <para>@文档</para>
                /// </summary>
                public record TextElementMentionDoc
                {
                    /// <summary>
                    /// <para>云文档 token</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：doxbc873Y7cXD153gXqb76G1Y9b</para>
                    /// </summary>
                    [JsonPropertyName("token")]
                    public string Token { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>云文档类型</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：22</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：Doc</item>
                    /// <item>3：Sheet</item>
                    /// <item>8：Bitable</item>
                    /// <item>11：MindNote</item>
                    /// <item>12：File</item>
                    /// <item>15：Slide</item>
                    /// <item>16：Wiki</item>
                    /// <item>22：Docx</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("obj_type")]
                    public int ObjType { get; set; }

                    /// <summary>
                    /// <para>云文档链接（需要 url_encode)</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：https%3A%2F%2Fbytedance.feishu-boe.cn%2Fdocx%2Fdoxbc873Y7cXD153gXqb76G1Y9b</para>
                    /// </summary>
                    [JsonPropertyName("url")]
                    public string Url { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文档标题，只读属性</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：undefined</para>
                    /// <para>最大长度：800</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("title")]
                    public string? Title { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementMentionDocTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementMentionDocTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementMentionDocTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementMentionDocTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>日期提醒</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("reminder")]
                public TextElementReminder? Reminder { get; set; }

                /// <summary>
                /// <para>日期提醒</para>
                /// </summary>
                public record TextElementReminder
                {
                    /// <summary>
                    /// <para>创建者用户 ID</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：0e2633a3-aa1a-4171-af9e-0768ff863566</para>
                    /// </summary>
                    [JsonPropertyName("create_user_id")]
                    public string CreateUserId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>是否通知</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonPropertyName("is_notify")]
                    public bool? IsNotify { get; set; }

                    /// <summary>
                    /// <para>是日期还是整点小时</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonPropertyName("is_whole_day")]
                    public bool? IsWholeDay { get; set; }

                    /// <summary>
                    /// <para>事件发生的时间（毫秒级事件戳）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1641967200000</para>
                    /// </summary>
                    [JsonPropertyName("expire_time")]
                    public string ExpireTime { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>触发通知的时间（毫秒级时间戳）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1643166000000</para>
                    /// </summary>
                    [JsonPropertyName("notify_time")]
                    public string NotifyTime { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementReminderTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementReminderTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementReminderTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementReminderTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>内联附件</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("file")]
                public InlineFile? File { get; set; }

                /// <summary>
                /// <para>内联附件</para>
                /// </summary>
                public record InlineFile
                {
                    /// <summary>
                    /// <para>附件 token</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：boxcnOj88GDkmWGm2zsTyCBqoLb</para>
                    /// </summary>
                    [JsonPropertyName("file_token")]
                    public string? FileToken { get; set; }

                    /// <summary>
                    /// <para>当前文档中该附件所处的 block 的 id</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：doxcnM46kSWSkgUMW04ldKsJDsc</para>
                    /// </summary>
                    [JsonPropertyName("source_block_id")]
                    public string? SourceBlockId { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public InlineFileTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record InlineFileTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public InlineFileTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record InlineFileTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>未支持的 TextElement</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("undefined")]
                public object? Undefined { get; set; }

                /// <summary>
                /// <para>内联 block</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("inline_block")]
                public TextElementInlineBlock? InlineBlock { get; set; }

                /// <summary>
                /// <para>内联 block</para>
                /// </summary>
                public record TextElementInlineBlock
                {
                    /// <summary>
                    /// <para>关联的内联状态的 block 的 block_id</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：doxcnPFi0R56ctbvh2MjkkROFWf</para>
                    /// </summary>
                    [JsonPropertyName("block_id")]
                    public string BlockId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementInlineBlockTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementInlineBlockTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementInlineBlockTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementInlineBlockTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>公式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("equation")]
                public TextElementEquation? Equation { get; set; }

                /// <summary>
                /// <para>公式</para>
                /// </summary>
                public record TextElementEquation
                {
                    /// <summary>
                    /// <para>符合 KaTeX 语法的公式内容，语法规则请参考：https://katex.org/docs/supported.html</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：E=mc^2\n</para>
                    /// </summary>
                    [JsonPropertyName("content")]
                    public string Content { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementEquationTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementEquationTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementEquationTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementEquationTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>二级标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("heading2")]
        public TextSuffix? Heading2 { get; set; }

        /// <summary>
        /// <para>三级标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("heading3")]
        public TextSuffix? Heading3 { get; set; }

        /// <summary>
        /// <para>四级标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("heading4")]
        public TextSuffix? Heading4 { get; set; }

        /// <summary>
        /// <para>五级标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("heading5")]
        public TextSuffix? Heading5 { get; set; }

        /// <summary>
        /// <para>六级标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("heading6")]
        public TextSuffix? Heading6 { get; set; }

        /// <summary>
        /// <para>七级标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("heading7")]
        public TextSuffix? Heading7 { get; set; }

        /// <summary>
        /// <para>八级标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("heading8")]
        public TextSuffix? Heading8 { get; set; }

        /// <summary>
        /// <para>九级标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("heading9")]
        public TextSuffix? Heading9 { get; set; }

        /// <summary>
        /// <para>无序列表 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("bullet")]
        public TextSuffix? Bullet { get; set; }

        /// <summary>
        /// <para>有序列表 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("ordered")]
        public TextSuffix? Ordered { get; set; }

        /// <summary>
        /// <para>代码块 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("code")]
        public TextSuffix? Code { get; set; }

        /// <summary>
        /// <para>引用 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("quote")]
        public TextSuffix? Quote { get; set; }

        /// <summary>
        /// <para>公式 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("equation")]
        public TextSuffix? Equation { get; set; }

        /// <summary>
        /// <para>任务 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("todo")]
        public TextSuffix? Todo { get; set; }

        /// <summary>
        /// <para>多维表格 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("bitable")]
        public BlockBitable? Bitable { get; set; }

        /// <summary>
        /// <para>多维表格 Block</para>
        /// </summary>
        public record BlockBitable
        {
            /// <summary>
            /// <para>多维表格文档 Token。格式为 {BitableToken}_{TableID}，其中 BitableToken 是一篇多维表格的唯一标识，TableID 是一张数据表的唯一标识，使用时请注意拆分。</para>
            /// <para>必填：否</para>
            /// <para>示例值：basbcqH9FfRn3sWCCBOtdNVpCsb_tblSAh8fEwhuMXQg</para>
            /// </summary>
            [JsonPropertyName("token")]
            public string? Token { get; set; }

            /// <summary>
            /// <para>类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：数据表</item>
            /// <item>2：看板</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("view_type")]
            public int? ViewType { get; set; }
        }

        /// <summary>
        /// <para>高亮块 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("callout")]
        public BlockCallout? Callout { get; set; }

        /// <summary>
        /// <para>高亮块 Block</para>
        /// </summary>
        public record BlockCallout
        {
            /// <summary>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：浅红色</item>
            /// <item>2：浅橙色</item>
            /// <item>3：浅黄色</item>
            /// <item>4：浅绿色</item>
            /// <item>5：浅蓝色</item>
            /// <item>6：浅紫色</item>
            /// <item>7：浅灰色</item>
            /// <item>8：暗红色</item>
            /// <item>9：暗橙色</item>
            /// <item>10：暗黄色</item>
            /// <item>11：暗绿色</item>
            /// <item>12：暗蓝色</item>
            /// <item>13：暗紫色</item>
            /// <item>14：暗灰色</item>
            /// <item>15：暗银灰色</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("background_color")]
            public int? BackgroundColor { get; set; }

            /// <summary>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：红色</item>
            /// <item>2：橙色</item>
            /// <item>3：黄色</item>
            /// <item>4：绿色</item>
            /// <item>5：蓝色</item>
            /// <item>6：紫色</item>
            /// <item>7：灰色</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("border_color")]
            public int? BorderColor { get; set; }

            /// <summary>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：粉红色</item>
            /// <item>2：橙色</item>
            /// <item>3：黄色</item>
            /// <item>4：绿色</item>
            /// <item>5：蓝色</item>
            /// <item>6：紫色</item>
            /// <item>7：灰色</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("text_color")]
            public int? TextColor { get; set; }

            /// <summary>
            /// <para>高亮块图标</para>
            /// <para>必填：否</para>
            /// <para>示例值：pushpin</para>
            /// </summary>
            [JsonPropertyName("emoji_id")]
            public string? EmojiId { get; set; }
        }

        /// <summary>
        /// <para>群聊卡片 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("chat_card")]
        public BlockChatCard? ChatCard { get; set; }

        /// <summary>
        /// <para>群聊卡片 Block</para>
        /// </summary>
        public record BlockChatCard
        {
            /// <summary>
            /// <para>群聊天会话 ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：oc_2e2ef17a54207c68efdf998554ef27e3</para>
            /// </summary>
            [JsonPropertyName("chat_id")]
            public string ChatId { get; set; } = string.Empty;

            /// <summary>
            /// <para>对齐方式</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：</item>
            /// <item>2：</item>
            /// <item>3：</item>
            /// </list></para>
            /// <para>默认值：1</para>
            /// </summary>
            [JsonPropertyName("align")]
            public int? Align { get; set; }
        }

        /// <summary>
        /// <para>流程图/UML Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("diagram")]
        public BlockDiagram? Diagram { get; set; }

        /// <summary>
        /// <para>流程图/UML Block</para>
        /// </summary>
        public record BlockDiagram
        {
            /// <summary>
            /// <para>绘图类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：流程图</item>
            /// <item>2：UML 图</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("diagram_type")]
            public int? DiagramType { get; set; }
        }

        /// <summary>
        /// <para>分割线 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("divider")]
        public object? Divider { get; set; }

        /// <summary>
        /// <para>文件 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("file")]
        public BlockFile? File { get; set; }

        /// <summary>
        /// <para>文件 Block</para>
        /// </summary>
        public record BlockFile
        {
            /// <summary>
            /// <para>附件 Token</para>
            /// <para>必填：否</para>
            /// <para>示例值：boxbcOj88GDkmWGm2zsTyCBqoLb</para>
            /// </summary>
            [JsonPropertyName("token")]
            public string? Token { get; set; }

            /// <summary>
            /// <para>文件名</para>
            /// <para>必填：否</para>
            /// <para>示例值：文件名</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>视图类型，卡片视图（默认）或预览视图</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：卡片视图</item>
            /// <item>2：预览视图</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("view_type")]
            public int? ViewType { get; set; }
        }

        /// <summary>
        /// <para>分栏 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("grid")]
        public BlockGrid? Grid { get; set; }

        /// <summary>
        /// <para>分栏 Block</para>
        /// </summary>
        public record BlockGrid
        {
            /// <summary>
            /// <para>分栏列数量</para>
            /// <para>必填：是</para>
            /// <para>示例值：2</para>
            /// <para>最大值：5</para>
            /// <para>最小值：2</para>
            /// </summary>
            [JsonPropertyName("column_size")]
            public int ColumnSize { get; set; }
        }

        /// <summary>
        /// <para>分栏列 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("grid_column")]
        public BlockGridColumn? GridColumn { get; set; }

        /// <summary>
        /// <para>分栏列 Block</para>
        /// </summary>
        public record BlockGridColumn
        {
            /// <summary>
            /// <para>当前分栏列占整个分栏的比例</para>
            /// <para>必填：否</para>
            /// <para>示例值：50</para>
            /// </summary>
            [JsonPropertyName("width_ratio")]
            public int? WidthRatio { get; set; }
        }

        /// <summary>
        /// <para>内嵌 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("iframe")]
        public BlockIframe? Iframe { get; set; }

        /// <summary>
        /// <para>内嵌 Block</para>
        /// </summary>
        public record BlockIframe
        {
            /// <summary>
            /// <para>iframe 的组成元素</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("component")]
            public IframeComponent Component { get; set; } = new();

            /// <summary>
            /// <para>iframe 的组成元素</para>
            /// </summary>
            public record IframeComponent
            {
                /// <summary>
                /// <para>iframe 类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：哔哩哔哩</item>
                /// <item>2：西瓜视频</item>
                /// <item>3：优酷</item>
                /// <item>4：Airtable</item>
                /// <item>5：百度地图</item>
                /// <item>6：高德地图</item>
                /// <item>7：Undefined</item>
                /// <item>8：Figma</item>
                /// <item>9：墨刀</item>
                /// <item>10：Canva</item>
                /// <item>11：CodePen</item>
                /// <item>12：飞书问卷</item>
                /// <item>13：金数据</item>
                /// <item>14：Undefined</item>
                /// <item>15：Undefined</item>
                /// <item>99：Other</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("iframe_type")]
                public int? IframeType { get; set; }

                /// <summary>
                /// <para>iframe 目标 url（需要进行 url_encode）</para>
                /// <para>必填：是</para>
                /// <para>示例值：https%3A%2F%2Fwww.bilibili.com%2Fvideo%2FBV1Hi4y1w7V7</para>
                /// </summary>
                [JsonPropertyName("url")]
                public string Url { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>图片 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("image")]
        public BlockImage? Image { get; set; }

        /// <summary>
        /// <para>图片 Block</para>
        /// </summary>
        public record BlockImage
        {
            /// <summary>
            /// <para>宽度，单位 px</para>
            /// <para>必填：否</para>
            /// <para>示例值：4069</para>
            /// </summary>
            [JsonPropertyName("width")]
            public int? Width { get; set; }

            /// <summary>
            /// <para>高度，单位 px</para>
            /// <para>必填：否</para>
            /// <para>示例值：2480</para>
            /// </summary>
            [JsonPropertyName("height")]
            public int? Height { get; set; }

            /// <summary>
            /// <para>图片 Token</para>
            /// <para>必填：否</para>
            /// <para>示例值：boxbcVA91JtFgNhaCgy6s6wK4he</para>
            /// </summary>
            [JsonPropertyName("token")]
            public string? Token { get; set; }

            /// <summary>
            /// <para>对齐方式</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：居左排版</item>
            /// <item>2：居中排版</item>
            /// <item>3：居右排版</item>
            /// </list></para>
            /// <para>默认值：2</para>
            /// </summary>
            [JsonPropertyName("align")]
            public int? Align { get; set; }
        }

        /// <summary>
        /// <para>三方 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("isv")]
        public BlockIsv? Isv { get; set; }

        /// <summary>
        /// <para>三方 Block</para>
        /// </summary>
        public record BlockIsv
        {
            /// <summary>
            /// <para>团队互动应用唯一ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7056882725002051603</para>
            /// </summary>
            [JsonPropertyName("component_id")]
            public string? ComponentId { get; set; }

            /// <summary>
            /// <para>团队互动应用类型，比如信息收集"blk_5f992038c64240015d280958"</para>
            /// <para>必填：否</para>
            /// <para>示例值：blk_5f992038c64240015d280958</para>
            /// </summary>
            [JsonPropertyName("component_type_id")]
            public string? ComponentTypeId { get; set; }
        }

        /// <summary>
        /// <para>Add-ons</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("add_ons")]
        public BlockAddOns? AddOns { get; set; }

        /// <summary>
        /// <para>Add-ons</para>
        /// </summary>
        public record BlockAddOns
        {
            /// <summary>
            /// <para>团队互动应用唯一ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7056882725002051603</para>
            /// </summary>
            [JsonPropertyName("component_id")]
            public string? ComponentId { get; set; }

            /// <summary>
            /// <para>团队互动应用类型，比如问答互动"blk_636a0a6657db8001c8df5488"</para>
            /// <para>必填：是</para>
            /// <para>示例值：blk_636a0a6657db8001c8df5488</para>
            /// </summary>
            [JsonPropertyName("component_type_id")]
            public string ComponentTypeId { get; set; } = string.Empty;

            /// <summary>
            /// <para>文档小组件内容数据，JSON 字符串</para>
            /// <para>必填：否</para>
            /// <para>示例值："{}"</para>
            /// </summary>
            [JsonPropertyName("record")]
            public string? Record { get; set; }
        }

        /// <summary>
        /// <para>思维笔记 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("mindnote")]
        public BlockMindnote? Mindnote { get; set; }

        /// <summary>
        /// <para>思维笔记 Block</para>
        /// </summary>
        public record BlockMindnote
        {
            /// <summary>
            /// <para>思维导图 token</para>
            /// <para>必填：否</para>
            /// <para>示例值：bmnbcXXGPWfJMwDfGCbCiU14c6f</para>
            /// </summary>
            [JsonPropertyName("token")]
            public string? Token { get; set; }
        }

        /// <summary>
        /// <para>电子表格 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sheet")]
        public BlockSheet? Sheet { get; set; }

        /// <summary>
        /// <para>电子表格 Block</para>
        /// </summary>
        public record BlockSheet
        {
            /// <summary>
            /// <para>电子表格文档 Token。格式为 {SpreadsheetToken}_{SheetID}，其中 SpreadsheetToken 是一篇电子表格的唯一标识，SheetID 是一张工作表的唯一标识，使用时请注意拆分。</para>
            /// <para>必填：否</para>
            /// <para>示例值：shtbcW6ufcUtRRet7Hz6Iv4ytzg</para>
            /// </summary>
            [JsonPropertyName("token")]
            public string? Token { get; set; }

            /// <summary>
            /// <para>电子表格行数量</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// <para>最大值：9</para>
            /// <para>最小值：1</para>
            /// </summary>
            [JsonPropertyName("row_size")]
            public int? RowSize { get; set; }

            /// <summary>
            /// <para>电子表格列数量</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// <para>最大值：9</para>
            /// <para>最小值：1</para>
            /// </summary>
            [JsonPropertyName("column_size")]
            public int? ColumnSize { get; set; }
        }

        /// <summary>
        /// <para>表格 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("table")]
        public BlockTable? Table { get; set; }

        /// <summary>
        /// <para>表格 Block</para>
        /// </summary>
        public record BlockTable
        {
            /// <summary>
            /// <para>单元格数组，数组元素为 Table Cell Block 的 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("cells")]
            public string[]? Cells { get; set; }

            /// <summary>
            /// <para>表格属性</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("property")]
            public TableProperty Property { get; set; } = new();

            /// <summary>
            /// <para>表格属性</para>
            /// </summary>
            public record TableProperty
            {
                /// <summary>
                /// <para>行数</para>
                /// <para>必填：是</para>
                /// <para>示例值：1</para>
                /// <para>最小值：1</para>
                /// </summary>
                [JsonPropertyName("row_size")]
                public int RowSize { get; set; }

                /// <summary>
                /// <para>列数</para>
                /// <para>必填：是</para>
                /// <para>示例值：1</para>
                /// <para>最小值：1</para>
                /// </summary>
                [JsonPropertyName("column_size")]
                public int ColumnSize { get; set; }

                /// <summary>
                /// <para>列宽，单位px</para>
                /// <para>必填：否</para>
                /// <para>示例值：100</para>
                /// <para>默认值：100</para>
                /// </summary>
                [JsonPropertyName("column_width")]
                public int[]? ColumnWidth { get; set; }

                /// <summary>
                /// <para>单元格合并信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("merge_info")]
                public TableMergeInfo[]? MergeInfos { get; set; }

                /// <summary>
                /// <para>单元格合并信息</para>
                /// </summary>
                public record TableMergeInfo
                {
                    /// <summary>
                    /// <para>从当前行索引起被合并的连续行数</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：2</para>
                    /// <para>最小值：1</para>
                    /// </summary>
                    [JsonPropertyName("row_span")]
                    public int? RowSpan { get; set; }

                    /// <summary>
                    /// <para>从当前列索引起被合并的连续列数</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：2</para>
                    /// <para>最小值：1</para>
                    /// </summary>
                    [JsonPropertyName("col_span")]
                    public int? ColSpan { get; set; }
                }

                /// <summary>
                /// <para>设置首行为标题行</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("header_row")]
                public bool? HeaderRow { get; set; }

                /// <summary>
                /// <para>设置首列为标题列</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("header_column")]
                public bool? HeaderColumn { get; set; }
            }
        }

        /// <summary>
        /// <para>单元格 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("table_cell")]
        public object? TableCell { get; set; }

        /// <summary>
        /// <para>视图 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("view")]
        public BlockView? View { get; set; }

        /// <summary>
        /// <para>视图 Block</para>
        /// </summary>
        public record BlockView
        {
            /// <summary>
            /// <para>视图类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：卡片视图</item>
            /// <item>2：预览视图</item>
            /// <item>3：内联视图</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("view_type")]
            public int? ViewType { get; set; }
        }

        /// <summary>
        /// <para>未支持 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("undefined")]
        public object? Undefined { get; set; }

        /// <summary>
        /// <para>引用容器 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("quote_container")]
        public object? QuoteContainer { get; set; }

        /// <summary>
        /// <para>任务 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("task")]
        public BlockTask? Task { get; set; }

        /// <summary>
        /// <para>任务 Block</para>
        /// </summary>
        public record BlockTask
        {
            /// <summary>
            /// <para>任务 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ba5040f4-8116-4042-ab3c-254e5cfe3ce7</para>
            /// </summary>
            [JsonPropertyName("task_id")]
            public string? TaskId { get; set; }

            /// <summary>
            /// <para>折叠状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// <para>默认值：false</para>
            /// </summary>
            [JsonPropertyName("folded")]
            public bool? Folded { get; set; }
        }

        /// <summary>
        /// <para>OKR Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("okr")]
        public BlockOkr? Okr { get; set; }

        /// <summary>
        /// <para>OKR Block</para>
        /// </summary>
        public record BlockOkr
        {
            /// <summary>
            /// <para>OKR ID</para>
            /// <para>必填：否</para>
            /// <para>示例值："7076349900476448796"</para>
            /// </summary>
            [JsonPropertyName("okr_id")]
            public string? OkrId { get; set; }

            /// <summary>
            /// <para>OKR Block 中的 objective ID 和 key result ID，此值为空时插入 okr 下所有的 objective 和 key result</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("objectives")]
            public ObjectiveIdWithKrId[]? Objectives { get; set; }

            /// <summary>
            /// <para>OKR Block 中的 objective ID 和 key result ID，此值为空时插入 okr 下所有的 objective 和 key result</para>
            /// </summary>
            public record ObjectiveIdWithKrId
            {
                /// <summary>
                /// <para>okr 中 objective 的 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：7109022409227026460</para>
                /// </summary>
                [JsonPropertyName("objective_id")]
                public string? ObjectiveId { get; set; }

                /// <summary>
                /// <para>key result 的 ID 列表，此值为空时插入当前 objective 下的所有 key result</para>
                /// <para>必填：否</para>
                /// <para>示例值：["7109022573011894300","7109022546444517404"]</para>
                /// </summary>
                [JsonPropertyName("kr_ids")]
                public string[]? KrIds { get; set; }
            }

            /// <summary>
            /// <para>周期的状态</para>
            /// <para>必填：否</para>
            /// <para>示例值："default"</para>
            /// <para>可选值：<list type="bullet">
            /// <item>default：默认</item>
            /// <item>normal：正常</item>
            /// <item>invalid：失效</item>
            /// <item>hidden：隐藏</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("period_display_status")]
            public string? PeriodDisplayStatus { get; set; }

            /// <summary>
            /// <para>周期名 - 中文</para>
            /// <para>必填：否</para>
            /// <para>示例值："2022 年 4 月 - 6 月"</para>
            /// </summary>
            [JsonPropertyName("period_name_zh")]
            public string? PeriodNameZh { get; set; }

            /// <summary>
            /// <para>周期名 - 英文</para>
            /// <para>必填：否</para>
            /// <para>示例值："Apr - Jun 2022"</para>
            /// </summary>
            [JsonPropertyName("period_name_en")]
            public string? PeriodNameEn { get; set; }

            /// <summary>
            /// <para>OKR 所属的用户 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值："ou_3bbe8a09c20e89cce9bff989ed840674"</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>可见性设置</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("visible_setting")]
            public OkrVisibleSetting? VisibleSetting { get; set; }

            /// <summary>
            /// <para>可见性设置</para>
            /// </summary>
            public record OkrVisibleSetting
            {
                /// <summary>
                /// <para>进展编辑区域是否可见</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：true</para>
                /// </summary>
                [JsonPropertyName("progress_fill_area_visible")]
                public bool? ProgressFillAreaVisible { get; set; }

                /// <summary>
                /// <para>状态是否可见</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：true</para>
                /// </summary>
                [JsonPropertyName("progress_status_visible")]
                public bool? ProgressStatusVisible { get; set; }

                /// <summary>
                /// <para>分数是否可见</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：true</para>
                /// </summary>
                [JsonPropertyName("score_visible")]
                public bool? ScoreVisible { get; set; }
            }
        }

        /// <summary>
        /// <para>OKR Objective</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("okr_objective")]
        public BlockOkrObjective? OkrObjective { get; set; }

        /// <summary>
        /// <para>OKR Objective</para>
        /// </summary>
        public record BlockOkrObjective
        {
            /// <summary>
            /// <para>objective ID</para>
            /// <para>必填：否</para>
            /// <para>示例值："7109022409227026460"</para>
            /// </summary>
            [JsonPropertyName("objective_id")]
            public string? ObjectiveId { get; set; }

            /// <summary>
            /// <para>是否设置过私密权限</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("confidential")]
            public bool? Confidential { get; set; }

            /// <summary>
            /// <para>objective 的位置编号，对应 Block 中 O1、O2 的 1、2</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("position")]
            public int? Position { get; set; }

            /// <summary>
            /// <para>打分信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("score")]
            public int? Score { get; set; }

            /// <summary>
            /// <para>OKR Block 中是否展示该 objective</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// <para>默认值：true</para>
            /// </summary>
            [JsonPropertyName("visible")]
            public bool? Visible { get; set; }

            /// <summary>
            /// <para>objective 的权重</para>
            /// <para>必填：否</para>
            /// <para>示例值：1.0</para>
            /// </summary>
            [JsonPropertyName("weight")]
            public float? Weight { get; set; }

            /// <summary>
            /// <para>进展信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("progress_rate")]
            public OkrProgressRate? ProgressRate { get; set; }

            /// <summary>
            /// <para>进展信息</para>
            /// </summary>
            public record OkrProgressRate
            {
                /// <summary>
                /// <para>状态模式</para>
                /// <para>必填：否</para>
                /// <para>示例值："simple"</para>
                /// <para>可选值：<list type="bullet">
                /// <item>simple：简单模式</item>
                /// <item>advanced：高级模式</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("mode")]
                public string? Mode { get; set; }

                /// <summary>
                /// <para>当前进度</para>
                /// <para>必填：否</para>
                /// <para>示例值：0</para>
                /// </summary>
                [JsonPropertyName("current")]
                public float? Current { get; set; }

                /// <summary>
                /// <para>当前进度百分比，simple mode 下使用</para>
                /// <para>必填：否</para>
                /// <para>示例值：100</para>
                /// </summary>
                [JsonPropertyName("percent")]
                public float? Percent { get; set; }

                /// <summary>
                /// <para>进展状态</para>
                /// <para>必填：否</para>
                /// <para>示例值："normal"</para>
                /// <para>可选值：<list type="bullet">
                /// <item>unset：未设置</item>
                /// <item>normal：正常</item>
                /// <item>risk：有风险</item>
                /// <item>extended：已延期</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("progress_status")]
                public string? ProgressStatus { get; set; }

                /// <summary>
                /// <para>进度起始值，advanced模式使用</para>
                /// <para>必填：否</para>
                /// <para>示例值：0</para>
                /// </summary>
                [JsonPropertyName("start")]
                public float? Start { get; set; }

                /// <summary>
                /// <para>状态类型</para>
                /// <para>必填：否</para>
                /// <para>示例值："default"</para>
                /// <para>可选值：<list type="bullet">
                /// <item>default：风险最高的Key Result状态</item>
                /// <item>custom：自定义</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("status_type")]
                public string? StatusType { get; set; }

                /// <summary>
                /// <para>进度目标值，advanced模式使用</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("target")]
                public float? Target { get; set; }
            }

            /// <summary>
            /// <para>objective 的文本内容</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("content")]
            public Text? Content { get; set; }

            /// <summary>
            /// <para>objective 的文本内容</para>
            /// </summary>
            public record Text
            {
                /// <summary>
                /// <para>文本样式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("style")]
                public TextStyle? Style { get; set; }

                /// <summary>
                /// <para>文本样式</para>
                /// </summary>
                public record TextStyle
                {
                    /// <summary>
                    /// <para>对齐方式</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：居左排版</item>
                    /// <item>2：居中排版</item>
                    /// <item>3：居右排版</item>
                    /// </list></para>
                    /// <para>默认值：1</para>
                    /// </summary>
                    [JsonPropertyName("align")]
                    public int? Align { get; set; }

                    /// <summary>
                    /// <para>todo 的完成状态</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonPropertyName("done")]
                    public bool? Done { get; set; }

                    /// <summary>
                    /// <para>文本的折叠状态</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonPropertyName("folded")]
                    public bool? Folded { get; set; }

                    /// <summary>
                    /// <para>代码块语言</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：PlainText</item>
                    /// <item>2：ABAP</item>
                    /// <item>3：Ada</item>
                    /// <item>4：Apache</item>
                    /// <item>5：Apex</item>
                    /// <item>6：Assembly Language</item>
                    /// <item>7：Bash</item>
                    /// <item>8：CSharp</item>
                    /// <item>9：C++</item>
                    /// <item>10：C</item>
                    /// <item>11：COBOL</item>
                    /// <item>12：CSS</item>
                    /// <item>13：CoffeeScript</item>
                    /// <item>14：D</item>
                    /// <item>15：Dart</item>
                    /// <item>16：Delphi</item>
                    /// <item>17：Django</item>
                    /// <item>18：Dockerfile</item>
                    /// <item>19：Erlang</item>
                    /// <item>20：Fortran</item>
                    /// <item>21：FoxPro（已废弃）</item>
                    /// <item>22：Go</item>
                    /// <item>23：Groovy</item>
                    /// <item>24：HTML</item>
                    /// <item>25：HTMLBars</item>
                    /// <item>26：HTTP</item>
                    /// <item>27：Haskell</item>
                    /// <item>28：JSON</item>
                    /// <item>29：Java</item>
                    /// <item>30：JavaScript</item>
                    /// <item>31：Julia</item>
                    /// <item>32：Kotlin</item>
                    /// <item>33：LateX</item>
                    /// <item>34：Lisp</item>
                    /// <item>35：Logo（已废弃）</item>
                    /// <item>36：Lua</item>
                    /// <item>37：MATLAB</item>
                    /// <item>38：Makefile</item>
                    /// <item>39：Markdown</item>
                    /// <item>40：Nginx</item>
                    /// <item>41：Objective-C</item>
                    /// <item>42：OpenEdgeABL（已废弃）</item>
                    /// <item>43：PHP</item>
                    /// <item>44：Perl</item>
                    /// <item>45：PostScript（已废弃）</item>
                    /// <item>46：Power Shell</item>
                    /// <item>47：Prolog</item>
                    /// <item>48：ProtoBuf</item>
                    /// <item>49：Python</item>
                    /// <item>50：R</item>
                    /// <item>51：RPG（已废弃）</item>
                    /// <item>52：Ruby</item>
                    /// <item>53：Rust</item>
                    /// <item>54：SAS</item>
                    /// <item>55：SCSS</item>
                    /// <item>56：SQL</item>
                    /// <item>57：Scala</item>
                    /// <item>58：Scheme</item>
                    /// <item>59：Scratch（已废弃）</item>
                    /// <item>60：Shell</item>
                    /// <item>61：Swift</item>
                    /// <item>62：Thrift</item>
                    /// <item>63：TypeScript</item>
                    /// <item>64：VBScript</item>
                    /// <item>65：Visual Basic</item>
                    /// <item>66：XML</item>
                    /// <item>67：YAML</item>
                    /// <item>68：CMake</item>
                    /// <item>69：Diff</item>
                    /// <item>70：Gherkin</item>
                    /// <item>71：GraphQL</item>
                    /// <item>72：OpenGL Shading Language</item>
                    /// <item>73：Properties</item>
                    /// <item>74：Solidity</item>
                    /// <item>75：TOML</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("language")]
                    public int? Language { get; set; }

                    /// <summary>
                    /// <para>代码块是否自动换行</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonPropertyName("wrap")]
                    public bool? Wrap { get; set; }

                    /// <summary>
                    /// <para>块背景色</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：LightGrayBackground</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>LightGrayBackground：浅灰色</item>
                    /// <item>LightRedBackground：浅红色</item>
                    /// <item>LightOrangeBackground：浅橙色</item>
                    /// <item>LightYellowBackground：浅黄色</item>
                    /// <item>LightGreenBackground：浅绿色</item>
                    /// <item>LightBlueBackground：浅蓝色</item>
                    /// <item>LightPurpleBackground：浅紫色</item>
                    /// <item>PaleGrayBackground：淡灰色</item>
                    /// <item>DarkGrayBackground：深灰色</item>
                    /// <item>DarkRedBackground：深红色</item>
                    /// <item>DarkOrangeBackground：深橙色</item>
                    /// <item>DarkYellowBackground：深黄色</item>
                    /// <item>DarkGreenBackground：深绿色</item>
                    /// <item>DarkBlueBackground：深蓝色</item>
                    /// <item>DarkPurpleBackground：深紫色</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("background_color")]
                    public string? BackgroundColor { get; set; }

                    /// <summary>
                    /// <para>首行缩进级别</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：NoIndent</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>NoIndent：无缩进</item>
                    /// <item>OneLevelIndent：一级缩进</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("indentation_level")]
                    public string? IndentationLevel { get; set; }

                    /// <summary>
                    /// <para>用于确定有序列表项编号，为具体数值或'auto'</para>
                    /// <para>必填：否</para>
                    /// <para>示例值："auto"</para>
                    /// </summary>
                    [JsonPropertyName("sequence")]
                    public string? Sequence { get; set; }
                }

                /// <summary>
                /// <para>文本元素</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("elements")]
                public TextElement[] Elements { get; set; } = Array.Empty<TextElement>();

                /// <summary>
                /// <para>文本元素</para>
                /// </summary>
                public record TextElement
                {
                    /// <summary>
                    /// <para>文字</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_run")]
                    public TextElementTextRun? TextRun { get; set; }

                    /// <summary>
                    /// <para>文字</para>
                    /// </summary>
                    public record TextElementTextRun
                    {
                        /// <summary>
                        /// <para>文本内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：文本</para>
                        /// </summary>
                        [JsonPropertyName("content")]
                        public string Content { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("text_element_style")]
                        public TextElementTextRunTextElementStyle? TextElementStyle { get; set; }

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// </summary>
                        public record TextElementTextRunTextElementStyle
                        {
                            /// <summary>
                            /// <para>加粗</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("bold")]
                            public bool? Bold { get; set; }

                            /// <summary>
                            /// <para>斜体</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("italic")]
                            public bool? Italic { get; set; }

                            /// <summary>
                            /// <para>删除线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("strikethrough")]
                            public bool? Strikethrough { get; set; }

                            /// <summary>
                            /// <para>下划线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("underline")]
                            public bool? Underline { get; set; }

                            /// <summary>
                            /// <para>inline 代码</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("inline_code")]
                            public bool? InlineCode { get; set; }

                            /// <summary>
                            /// <para>背景色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：浅粉红色</item>
                            /// <item>2：浅橙色</item>
                            /// <item>3：浅黄色</item>
                            /// <item>4：浅绿色</item>
                            /// <item>5：浅蓝色</item>
                            /// <item>6：浅紫色</item>
                            /// <item>7：浅灰色</item>
                            /// <item>8：暗粉红色</item>
                            /// <item>9：暗橙色</item>
                            /// <item>10：暗黄色</item>
                            /// <item>11：暗绿色</item>
                            /// <item>12：暗蓝色</item>
                            /// <item>13：暗紫色</item>
                            /// <item>14：暗灰色</item>
                            /// <item>15：暗银灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("background_color")]
                            public int? BackgroundColor { get; set; }

                            /// <summary>
                            /// <para>字体颜色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：粉红色</item>
                            /// <item>2：橙色</item>
                            /// <item>3：黄色</item>
                            /// <item>4：绿色</item>
                            /// <item>5：蓝色</item>
                            /// <item>6：紫色</item>
                            /// <item>7：灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("text_color")]
                            public int? TextColor { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("link")]
                            public TextElementTextRunTextElementStyleLink? Link { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// </summary>
                            public record TextElementTextRunTextElementStyleLink
                            {
                                /// <summary>
                                /// <para>超链接指向的 url (需要 url_encode)</para>
                                /// <para>必填：是</para>
                                /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                                /// </summary>
                                [JsonPropertyName("url")]
                                public string Url { get; set; } = string.Empty;
                            }

                            /// <summary>
                            /// <para>评论 id 列表</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：["1660030311959965796"]</para>
                            /// </summary>
                            [JsonPropertyName("comment_ids")]
                            public string[]? CommentIds { get; set; }
                        }
                    }

                    /// <summary>
                    /// <para>@用户</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("mention_user")]
                    public TextElementMentionUser? MentionUser { get; set; }

                    /// <summary>
                    /// <para>@用户</para>
                    /// </summary>
                    public record TextElementMentionUser
                    {
                        /// <summary>
                        /// <para>用户 OpenID</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：ou_3bbe8a09c20e89cce9bff989ed840674</para>
                        /// </summary>
                        [JsonPropertyName("user_id")]
                        public string UserId { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("text_element_style")]
                        public TextElementMentionUserTextElementStyle? TextElementStyle { get; set; }

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// </summary>
                        public record TextElementMentionUserTextElementStyle
                        {
                            /// <summary>
                            /// <para>加粗</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("bold")]
                            public bool? Bold { get; set; }

                            /// <summary>
                            /// <para>斜体</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("italic")]
                            public bool? Italic { get; set; }

                            /// <summary>
                            /// <para>删除线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("strikethrough")]
                            public bool? Strikethrough { get; set; }

                            /// <summary>
                            /// <para>下划线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("underline")]
                            public bool? Underline { get; set; }

                            /// <summary>
                            /// <para>inline 代码</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("inline_code")]
                            public bool? InlineCode { get; set; }

                            /// <summary>
                            /// <para>背景色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：浅粉红色</item>
                            /// <item>2：浅橙色</item>
                            /// <item>3：浅黄色</item>
                            /// <item>4：浅绿色</item>
                            /// <item>5：浅蓝色</item>
                            /// <item>6：浅紫色</item>
                            /// <item>7：浅灰色</item>
                            /// <item>8：暗粉红色</item>
                            /// <item>9：暗橙色</item>
                            /// <item>10：暗黄色</item>
                            /// <item>11：暗绿色</item>
                            /// <item>12：暗蓝色</item>
                            /// <item>13：暗紫色</item>
                            /// <item>14：暗灰色</item>
                            /// <item>15：暗银灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("background_color")]
                            public int? BackgroundColor { get; set; }

                            /// <summary>
                            /// <para>字体颜色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：粉红色</item>
                            /// <item>2：橙色</item>
                            /// <item>3：黄色</item>
                            /// <item>4：绿色</item>
                            /// <item>5：蓝色</item>
                            /// <item>6：紫色</item>
                            /// <item>7：灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("text_color")]
                            public int? TextColor { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("link")]
                            public TextElementMentionUserTextElementStyleLink? Link { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// </summary>
                            public record TextElementMentionUserTextElementStyleLink
                            {
                                /// <summary>
                                /// <para>超链接指向的 url (需要 url_encode)</para>
                                /// <para>必填：是</para>
                                /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                                /// </summary>
                                [JsonPropertyName("url")]
                                public string Url { get; set; } = string.Empty;
                            }

                            /// <summary>
                            /// <para>评论 id 列表</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：["1660030311959965796"]</para>
                            /// </summary>
                            [JsonPropertyName("comment_ids")]
                            public string[]? CommentIds { get; set; }
                        }
                    }

                    /// <summary>
                    /// <para>@文档</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("mention_doc")]
                    public TextElementMentionDoc? MentionDoc { get; set; }

                    /// <summary>
                    /// <para>@文档</para>
                    /// </summary>
                    public record TextElementMentionDoc
                    {
                        /// <summary>
                        /// <para>云文档 token</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：doxbc873Y7cXD153gXqb76G1Y9b</para>
                        /// </summary>
                        [JsonPropertyName("token")]
                        public string Token { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>云文档类型</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：22</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：Doc</item>
                        /// <item>3：Sheet</item>
                        /// <item>8：Bitable</item>
                        /// <item>11：MindNote</item>
                        /// <item>12：File</item>
                        /// <item>15：Slide</item>
                        /// <item>16：Wiki</item>
                        /// <item>22：Docx</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("obj_type")]
                        public int ObjType { get; set; }

                        /// <summary>
                        /// <para>云文档链接（需要 url_encode)</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：https%3A%2F%2Fbytedance.feishu-boe.cn%2Fdocx%2Fdoxbc873Y7cXD153gXqb76G1Y9b</para>
                        /// </summary>
                        [JsonPropertyName("url")]
                        public string Url { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文档标题，只读属性</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：undefined</para>
                        /// <para>最大长度：800</para>
                        /// <para>最小长度：0</para>
                        /// </summary>
                        [JsonPropertyName("title")]
                        public string? Title { get; set; }

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("text_element_style")]
                        public TextElementMentionDocTextElementStyle? TextElementStyle { get; set; }

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// </summary>
                        public record TextElementMentionDocTextElementStyle
                        {
                            /// <summary>
                            /// <para>加粗</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("bold")]
                            public bool? Bold { get; set; }

                            /// <summary>
                            /// <para>斜体</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("italic")]
                            public bool? Italic { get; set; }

                            /// <summary>
                            /// <para>删除线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("strikethrough")]
                            public bool? Strikethrough { get; set; }

                            /// <summary>
                            /// <para>下划线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("underline")]
                            public bool? Underline { get; set; }

                            /// <summary>
                            /// <para>inline 代码</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("inline_code")]
                            public bool? InlineCode { get; set; }

                            /// <summary>
                            /// <para>背景色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：浅粉红色</item>
                            /// <item>2：浅橙色</item>
                            /// <item>3：浅黄色</item>
                            /// <item>4：浅绿色</item>
                            /// <item>5：浅蓝色</item>
                            /// <item>6：浅紫色</item>
                            /// <item>7：浅灰色</item>
                            /// <item>8：暗粉红色</item>
                            /// <item>9：暗橙色</item>
                            /// <item>10：暗黄色</item>
                            /// <item>11：暗绿色</item>
                            /// <item>12：暗蓝色</item>
                            /// <item>13：暗紫色</item>
                            /// <item>14：暗灰色</item>
                            /// <item>15：暗银灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("background_color")]
                            public int? BackgroundColor { get; set; }

                            /// <summary>
                            /// <para>字体颜色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：粉红色</item>
                            /// <item>2：橙色</item>
                            /// <item>3：黄色</item>
                            /// <item>4：绿色</item>
                            /// <item>5：蓝色</item>
                            /// <item>6：紫色</item>
                            /// <item>7：灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("text_color")]
                            public int? TextColor { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("link")]
                            public TextElementMentionDocTextElementStyleLink? Link { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// </summary>
                            public record TextElementMentionDocTextElementStyleLink
                            {
                                /// <summary>
                                /// <para>超链接指向的 url (需要 url_encode)</para>
                                /// <para>必填：是</para>
                                /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                                /// </summary>
                                [JsonPropertyName("url")]
                                public string Url { get; set; } = string.Empty;
                            }

                            /// <summary>
                            /// <para>评论 id 列表</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：["1660030311959965796"]</para>
                            /// </summary>
                            [JsonPropertyName("comment_ids")]
                            public string[]? CommentIds { get; set; }
                        }
                    }

                    /// <summary>
                    /// <para>日期提醒</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("reminder")]
                    public TextElementReminder? Reminder { get; set; }

                    /// <summary>
                    /// <para>日期提醒</para>
                    /// </summary>
                    public record TextElementReminder
                    {
                        /// <summary>
                        /// <para>创建者用户 ID</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：0e2633a3-aa1a-4171-af9e-0768ff863566</para>
                        /// </summary>
                        [JsonPropertyName("create_user_id")]
                        public string CreateUserId { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>是否通知</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("is_notify")]
                        public bool? IsNotify { get; set; }

                        /// <summary>
                        /// <para>是日期还是整点小时</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("is_whole_day")]
                        public bool? IsWholeDay { get; set; }

                        /// <summary>
                        /// <para>事件发生的时间（毫秒级事件戳）</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：1641967200000</para>
                        /// </summary>
                        [JsonPropertyName("expire_time")]
                        public string ExpireTime { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>触发通知的时间（毫秒级时间戳）</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：1643166000000</para>
                        /// </summary>
                        [JsonPropertyName("notify_time")]
                        public string NotifyTime { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("text_element_style")]
                        public TextElementReminderTextElementStyle? TextElementStyle { get; set; }

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// </summary>
                        public record TextElementReminderTextElementStyle
                        {
                            /// <summary>
                            /// <para>加粗</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("bold")]
                            public bool? Bold { get; set; }

                            /// <summary>
                            /// <para>斜体</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("italic")]
                            public bool? Italic { get; set; }

                            /// <summary>
                            /// <para>删除线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("strikethrough")]
                            public bool? Strikethrough { get; set; }

                            /// <summary>
                            /// <para>下划线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("underline")]
                            public bool? Underline { get; set; }

                            /// <summary>
                            /// <para>inline 代码</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("inline_code")]
                            public bool? InlineCode { get; set; }

                            /// <summary>
                            /// <para>背景色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：浅粉红色</item>
                            /// <item>2：浅橙色</item>
                            /// <item>3：浅黄色</item>
                            /// <item>4：浅绿色</item>
                            /// <item>5：浅蓝色</item>
                            /// <item>6：浅紫色</item>
                            /// <item>7：浅灰色</item>
                            /// <item>8：暗粉红色</item>
                            /// <item>9：暗橙色</item>
                            /// <item>10：暗黄色</item>
                            /// <item>11：暗绿色</item>
                            /// <item>12：暗蓝色</item>
                            /// <item>13：暗紫色</item>
                            /// <item>14：暗灰色</item>
                            /// <item>15：暗银灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("background_color")]
                            public int? BackgroundColor { get; set; }

                            /// <summary>
                            /// <para>字体颜色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：粉红色</item>
                            /// <item>2：橙色</item>
                            /// <item>3：黄色</item>
                            /// <item>4：绿色</item>
                            /// <item>5：蓝色</item>
                            /// <item>6：紫色</item>
                            /// <item>7：灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("text_color")]
                            public int? TextColor { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("link")]
                            public TextElementReminderTextElementStyleLink? Link { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// </summary>
                            public record TextElementReminderTextElementStyleLink
                            {
                                /// <summary>
                                /// <para>超链接指向的 url (需要 url_encode)</para>
                                /// <para>必填：是</para>
                                /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                                /// </summary>
                                [JsonPropertyName("url")]
                                public string Url { get; set; } = string.Empty;
                            }

                            /// <summary>
                            /// <para>评论 id 列表</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：["1660030311959965796"]</para>
                            /// </summary>
                            [JsonPropertyName("comment_ids")]
                            public string[]? CommentIds { get; set; }
                        }
                    }

                    /// <summary>
                    /// <para>内联附件</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("file")]
                    public InlineFile? File { get; set; }

                    /// <summary>
                    /// <para>内联附件</para>
                    /// </summary>
                    public record InlineFile
                    {
                        /// <summary>
                        /// <para>附件 token</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：boxcnOj88GDkmWGm2zsTyCBqoLb</para>
                        /// </summary>
                        [JsonPropertyName("file_token")]
                        public string? FileToken { get; set; }

                        /// <summary>
                        /// <para>当前文档中该附件所处的 block 的 id</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：doxcnM46kSWSkgUMW04ldKsJDsc</para>
                        /// </summary>
                        [JsonPropertyName("source_block_id")]
                        public string? SourceBlockId { get; set; }

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("text_element_style")]
                        public InlineFileTextElementStyle? TextElementStyle { get; set; }

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// </summary>
                        public record InlineFileTextElementStyle
                        {
                            /// <summary>
                            /// <para>加粗</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("bold")]
                            public bool? Bold { get; set; }

                            /// <summary>
                            /// <para>斜体</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("italic")]
                            public bool? Italic { get; set; }

                            /// <summary>
                            /// <para>删除线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("strikethrough")]
                            public bool? Strikethrough { get; set; }

                            /// <summary>
                            /// <para>下划线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("underline")]
                            public bool? Underline { get; set; }

                            /// <summary>
                            /// <para>inline 代码</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("inline_code")]
                            public bool? InlineCode { get; set; }

                            /// <summary>
                            /// <para>背景色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：浅粉红色</item>
                            /// <item>2：浅橙色</item>
                            /// <item>3：浅黄色</item>
                            /// <item>4：浅绿色</item>
                            /// <item>5：浅蓝色</item>
                            /// <item>6：浅紫色</item>
                            /// <item>7：浅灰色</item>
                            /// <item>8：暗粉红色</item>
                            /// <item>9：暗橙色</item>
                            /// <item>10：暗黄色</item>
                            /// <item>11：暗绿色</item>
                            /// <item>12：暗蓝色</item>
                            /// <item>13：暗紫色</item>
                            /// <item>14：暗灰色</item>
                            /// <item>15：暗银灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("background_color")]
                            public int? BackgroundColor { get; set; }

                            /// <summary>
                            /// <para>字体颜色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：粉红色</item>
                            /// <item>2：橙色</item>
                            /// <item>3：黄色</item>
                            /// <item>4：绿色</item>
                            /// <item>5：蓝色</item>
                            /// <item>6：紫色</item>
                            /// <item>7：灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("text_color")]
                            public int? TextColor { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("link")]
                            public InlineFileTextElementStyleLink? Link { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// </summary>
                            public record InlineFileTextElementStyleLink
                            {
                                /// <summary>
                                /// <para>超链接指向的 url (需要 url_encode)</para>
                                /// <para>必填：是</para>
                                /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                                /// </summary>
                                [JsonPropertyName("url")]
                                public string Url { get; set; } = string.Empty;
                            }

                            /// <summary>
                            /// <para>评论 id 列表</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：["1660030311959965796"]</para>
                            /// </summary>
                            [JsonPropertyName("comment_ids")]
                            public string[]? CommentIds { get; set; }
                        }
                    }

                    /// <summary>
                    /// <para>未支持的 TextElement</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("undefined")]
                    public object? Undefined { get; set; }

                    /// <summary>
                    /// <para>内联 block</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("inline_block")]
                    public TextElementInlineBlock? InlineBlock { get; set; }

                    /// <summary>
                    /// <para>内联 block</para>
                    /// </summary>
                    public record TextElementInlineBlock
                    {
                        /// <summary>
                        /// <para>关联的内联状态的 block 的 block_id</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：doxcnPFi0R56ctbvh2MjkkROFWf</para>
                        /// </summary>
                        [JsonPropertyName("block_id")]
                        public string BlockId { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("text_element_style")]
                        public TextElementInlineBlockTextElementStyle? TextElementStyle { get; set; }

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// </summary>
                        public record TextElementInlineBlockTextElementStyle
                        {
                            /// <summary>
                            /// <para>加粗</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("bold")]
                            public bool? Bold { get; set; }

                            /// <summary>
                            /// <para>斜体</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("italic")]
                            public bool? Italic { get; set; }

                            /// <summary>
                            /// <para>删除线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("strikethrough")]
                            public bool? Strikethrough { get; set; }

                            /// <summary>
                            /// <para>下划线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("underline")]
                            public bool? Underline { get; set; }

                            /// <summary>
                            /// <para>inline 代码</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("inline_code")]
                            public bool? InlineCode { get; set; }

                            /// <summary>
                            /// <para>背景色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：浅粉红色</item>
                            /// <item>2：浅橙色</item>
                            /// <item>3：浅黄色</item>
                            /// <item>4：浅绿色</item>
                            /// <item>5：浅蓝色</item>
                            /// <item>6：浅紫色</item>
                            /// <item>7：浅灰色</item>
                            /// <item>8：暗粉红色</item>
                            /// <item>9：暗橙色</item>
                            /// <item>10：暗黄色</item>
                            /// <item>11：暗绿色</item>
                            /// <item>12：暗蓝色</item>
                            /// <item>13：暗紫色</item>
                            /// <item>14：暗灰色</item>
                            /// <item>15：暗银灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("background_color")]
                            public int? BackgroundColor { get; set; }

                            /// <summary>
                            /// <para>字体颜色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：粉红色</item>
                            /// <item>2：橙色</item>
                            /// <item>3：黄色</item>
                            /// <item>4：绿色</item>
                            /// <item>5：蓝色</item>
                            /// <item>6：紫色</item>
                            /// <item>7：灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("text_color")]
                            public int? TextColor { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("link")]
                            public TextElementInlineBlockTextElementStyleLink? Link { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// </summary>
                            public record TextElementInlineBlockTextElementStyleLink
                            {
                                /// <summary>
                                /// <para>超链接指向的 url (需要 url_encode)</para>
                                /// <para>必填：是</para>
                                /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                                /// </summary>
                                [JsonPropertyName("url")]
                                public string Url { get; set; } = string.Empty;
                            }

                            /// <summary>
                            /// <para>评论 id 列表</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：["1660030311959965796"]</para>
                            /// </summary>
                            [JsonPropertyName("comment_ids")]
                            public string[]? CommentIds { get; set; }
                        }
                    }

                    /// <summary>
                    /// <para>公式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("equation")]
                    public TextElementEquation? Equation { get; set; }

                    /// <summary>
                    /// <para>公式</para>
                    /// </summary>
                    public record TextElementEquation
                    {
                        /// <summary>
                        /// <para>符合 KaTeX 语法的公式内容，语法规则请参考：https://katex.org/docs/supported.html</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：E=mc^2\n</para>
                        /// </summary>
                        [JsonPropertyName("content")]
                        public string Content { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("text_element_style")]
                        public TextElementEquationTextElementStyle? TextElementStyle { get; set; }

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// </summary>
                        public record TextElementEquationTextElementStyle
                        {
                            /// <summary>
                            /// <para>加粗</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("bold")]
                            public bool? Bold { get; set; }

                            /// <summary>
                            /// <para>斜体</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("italic")]
                            public bool? Italic { get; set; }

                            /// <summary>
                            /// <para>删除线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("strikethrough")]
                            public bool? Strikethrough { get; set; }

                            /// <summary>
                            /// <para>下划线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("underline")]
                            public bool? Underline { get; set; }

                            /// <summary>
                            /// <para>inline 代码</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("inline_code")]
                            public bool? InlineCode { get; set; }

                            /// <summary>
                            /// <para>背景色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：浅粉红色</item>
                            /// <item>2：浅橙色</item>
                            /// <item>3：浅黄色</item>
                            /// <item>4：浅绿色</item>
                            /// <item>5：浅蓝色</item>
                            /// <item>6：浅紫色</item>
                            /// <item>7：浅灰色</item>
                            /// <item>8：暗粉红色</item>
                            /// <item>9：暗橙色</item>
                            /// <item>10：暗黄色</item>
                            /// <item>11：暗绿色</item>
                            /// <item>12：暗蓝色</item>
                            /// <item>13：暗紫色</item>
                            /// <item>14：暗灰色</item>
                            /// <item>15：暗银灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("background_color")]
                            public int? BackgroundColor { get; set; }

                            /// <summary>
                            /// <para>字体颜色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：粉红色</item>
                            /// <item>2：橙色</item>
                            /// <item>3：黄色</item>
                            /// <item>4：绿色</item>
                            /// <item>5：蓝色</item>
                            /// <item>6：紫色</item>
                            /// <item>7：灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("text_color")]
                            public int? TextColor { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("link")]
                            public TextElementEquationTextElementStyleLink? Link { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// </summary>
                            public record TextElementEquationTextElementStyleLink
                            {
                                /// <summary>
                                /// <para>超链接指向的 url (需要 url_encode)</para>
                                /// <para>必填：是</para>
                                /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                                /// </summary>
                                [JsonPropertyName("url")]
                                public string Url { get; set; } = string.Empty;
                            }

                            /// <summary>
                            /// <para>评论 id 列表</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：["1660030311959965796"]</para>
                            /// </summary>
                            [JsonPropertyName("comment_ids")]
                            public string[]? CommentIds { get; set; }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// <para>OKR Key Result</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("okr_key_result")]
        public BlockOkrKeyResult? OkrKeyResult { get; set; }

        /// <summary>
        /// <para>OKR Key Result</para>
        /// </summary>
        public record BlockOkrKeyResult
        {
            /// <summary>
            /// <para>key result 的 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值："7109022573011894300"</para>
            /// </summary>
            [JsonPropertyName("kr_id")]
            public string? KrId { get; set; }

            /// <summary>
            /// <para>是否设置过私密权限</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("confidential")]
            public bool? Confidential { get; set; }

            /// <summary>
            /// <para>key result 的位置编号，对应 Block 中 KR1、KR2 的 1、2。</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("position")]
            public int? Position { get; set; }

            /// <summary>
            /// <para>打分信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("score")]
            public int? Score { get; set; }

            /// <summary>
            /// <para>OKR Block 中此 key result 是否可见</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// <para>默认值：true</para>
            /// </summary>
            [JsonPropertyName("visible")]
            public bool? Visible { get; set; }

            /// <summary>
            /// <para>key result 的权重</para>
            /// <para>必填：否</para>
            /// <para>示例值：0.5</para>
            /// </summary>
            [JsonPropertyName("weight")]
            public float? Weight { get; set; }

            /// <summary>
            /// <para>进展信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("progress_rate")]
            public OkrProgressRate? ProgressRate { get; set; }

            /// <summary>
            /// <para>进展信息</para>
            /// </summary>
            public record OkrProgressRate
            {
                /// <summary>
                /// <para>状态模式</para>
                /// <para>必填：否</para>
                /// <para>示例值："simple"</para>
                /// <para>可选值：<list type="bullet">
                /// <item>simple：简单模式</item>
                /// <item>advanced：高级模式</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("mode")]
                public string? Mode { get; set; }

                /// <summary>
                /// <para>当前进度</para>
                /// <para>必填：否</para>
                /// <para>示例值：0</para>
                /// </summary>
                [JsonPropertyName("current")]
                public float? Current { get; set; }

                /// <summary>
                /// <para>当前进度百分比，simple mode 下使用</para>
                /// <para>必填：否</para>
                /// <para>示例值：100</para>
                /// </summary>
                [JsonPropertyName("percent")]
                public float? Percent { get; set; }

                /// <summary>
                /// <para>进展状态</para>
                /// <para>必填：否</para>
                /// <para>示例值："normal"</para>
                /// <para>可选值：<list type="bullet">
                /// <item>unset：未设置</item>
                /// <item>normal：正常</item>
                /// <item>risk：有风险</item>
                /// <item>extended：已延期</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("progress_status")]
                public string? ProgressStatus { get; set; }

                /// <summary>
                /// <para>进度起始值，advanced模式使用</para>
                /// <para>必填：否</para>
                /// <para>示例值：0</para>
                /// </summary>
                [JsonPropertyName("start")]
                public float? Start { get; set; }

                /// <summary>
                /// <para>状态类型</para>
                /// <para>必填：否</para>
                /// <para>示例值："default"</para>
                /// <para>可选值：<list type="bullet">
                /// <item>default：风险最高的Key Result状态</item>
                /// <item>custom：自定义</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("status_type")]
                public string? StatusType { get; set; }

                /// <summary>
                /// <para>进度目标值，advanced模式使用</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("target")]
                public float? Target { get; set; }
            }

            /// <summary>
            /// <para>key result 的文本内容</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("content")]
            public Text? Content { get; set; }

            /// <summary>
            /// <para>key result 的文本内容</para>
            /// </summary>
            public record Text
            {
                /// <summary>
                /// <para>文本样式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("style")]
                public TextStyle? Style { get; set; }

                /// <summary>
                /// <para>文本样式</para>
                /// </summary>
                public record TextStyle
                {
                    /// <summary>
                    /// <para>对齐方式</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：居左排版</item>
                    /// <item>2：居中排版</item>
                    /// <item>3：居右排版</item>
                    /// </list></para>
                    /// <para>默认值：1</para>
                    /// </summary>
                    [JsonPropertyName("align")]
                    public int? Align { get; set; }

                    /// <summary>
                    /// <para>todo 的完成状态</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonPropertyName("done")]
                    public bool? Done { get; set; }

                    /// <summary>
                    /// <para>文本的折叠状态</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonPropertyName("folded")]
                    public bool? Folded { get; set; }

                    /// <summary>
                    /// <para>代码块语言</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：PlainText</item>
                    /// <item>2：ABAP</item>
                    /// <item>3：Ada</item>
                    /// <item>4：Apache</item>
                    /// <item>5：Apex</item>
                    /// <item>6：Assembly Language</item>
                    /// <item>7：Bash</item>
                    /// <item>8：CSharp</item>
                    /// <item>9：C++</item>
                    /// <item>10：C</item>
                    /// <item>11：COBOL</item>
                    /// <item>12：CSS</item>
                    /// <item>13：CoffeeScript</item>
                    /// <item>14：D</item>
                    /// <item>15：Dart</item>
                    /// <item>16：Delphi</item>
                    /// <item>17：Django</item>
                    /// <item>18：Dockerfile</item>
                    /// <item>19：Erlang</item>
                    /// <item>20：Fortran</item>
                    /// <item>21：FoxPro（已废弃）</item>
                    /// <item>22：Go</item>
                    /// <item>23：Groovy</item>
                    /// <item>24：HTML</item>
                    /// <item>25：HTMLBars</item>
                    /// <item>26：HTTP</item>
                    /// <item>27：Haskell</item>
                    /// <item>28：JSON</item>
                    /// <item>29：Java</item>
                    /// <item>30：JavaScript</item>
                    /// <item>31：Julia</item>
                    /// <item>32：Kotlin</item>
                    /// <item>33：LateX</item>
                    /// <item>34：Lisp</item>
                    /// <item>35：Logo（已废弃）</item>
                    /// <item>36：Lua</item>
                    /// <item>37：MATLAB</item>
                    /// <item>38：Makefile</item>
                    /// <item>39：Markdown</item>
                    /// <item>40：Nginx</item>
                    /// <item>41：Objective-C</item>
                    /// <item>42：OpenEdgeABL（已废弃）</item>
                    /// <item>43：PHP</item>
                    /// <item>44：Perl</item>
                    /// <item>45：PostScript（已废弃）</item>
                    /// <item>46：Power Shell</item>
                    /// <item>47：Prolog</item>
                    /// <item>48：ProtoBuf</item>
                    /// <item>49：Python</item>
                    /// <item>50：R</item>
                    /// <item>51：RPG（已废弃）</item>
                    /// <item>52：Ruby</item>
                    /// <item>53：Rust</item>
                    /// <item>54：SAS</item>
                    /// <item>55：SCSS</item>
                    /// <item>56：SQL</item>
                    /// <item>57：Scala</item>
                    /// <item>58：Scheme</item>
                    /// <item>59：Scratch（已废弃）</item>
                    /// <item>60：Shell</item>
                    /// <item>61：Swift</item>
                    /// <item>62：Thrift</item>
                    /// <item>63：TypeScript</item>
                    /// <item>64：VBScript</item>
                    /// <item>65：Visual Basic</item>
                    /// <item>66：XML</item>
                    /// <item>67：YAML</item>
                    /// <item>68：CMake</item>
                    /// <item>69：Diff</item>
                    /// <item>70：Gherkin</item>
                    /// <item>71：GraphQL</item>
                    /// <item>72：OpenGL Shading Language</item>
                    /// <item>73：Properties</item>
                    /// <item>74：Solidity</item>
                    /// <item>75：TOML</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("language")]
                    public int? Language { get; set; }

                    /// <summary>
                    /// <para>代码块是否自动换行</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonPropertyName("wrap")]
                    public bool? Wrap { get; set; }

                    /// <summary>
                    /// <para>块背景色</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：LightGrayBackground</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>LightGrayBackground：浅灰色</item>
                    /// <item>LightRedBackground：浅红色</item>
                    /// <item>LightOrangeBackground：浅橙色</item>
                    /// <item>LightYellowBackground：浅黄色</item>
                    /// <item>LightGreenBackground：浅绿色</item>
                    /// <item>LightBlueBackground：浅蓝色</item>
                    /// <item>LightPurpleBackground：浅紫色</item>
                    /// <item>PaleGrayBackground：淡灰色</item>
                    /// <item>DarkGrayBackground：深灰色</item>
                    /// <item>DarkRedBackground：深红色</item>
                    /// <item>DarkOrangeBackground：深橙色</item>
                    /// <item>DarkYellowBackground：深黄色</item>
                    /// <item>DarkGreenBackground：深绿色</item>
                    /// <item>DarkBlueBackground：深蓝色</item>
                    /// <item>DarkPurpleBackground：深紫色</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("background_color")]
                    public string? BackgroundColor { get; set; }

                    /// <summary>
                    /// <para>首行缩进级别</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：NoIndent</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>NoIndent：无缩进</item>
                    /// <item>OneLevelIndent：一级缩进</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("indentation_level")]
                    public string? IndentationLevel { get; set; }

                    /// <summary>
                    /// <para>用于确定有序列表项编号，为具体数值或'auto'</para>
                    /// <para>必填：否</para>
                    /// <para>示例值："auto"</para>
                    /// </summary>
                    [JsonPropertyName("sequence")]
                    public string? Sequence { get; set; }
                }

                /// <summary>
                /// <para>文本元素</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("elements")]
                public TextElement[] Elements { get; set; } = Array.Empty<TextElement>();

                /// <summary>
                /// <para>文本元素</para>
                /// </summary>
                public record TextElement
                {
                    /// <summary>
                    /// <para>文字</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_run")]
                    public TextElementTextRun? TextRun { get; set; }

                    /// <summary>
                    /// <para>文字</para>
                    /// </summary>
                    public record TextElementTextRun
                    {
                        /// <summary>
                        /// <para>文本内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：文本</para>
                        /// </summary>
                        [JsonPropertyName("content")]
                        public string Content { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("text_element_style")]
                        public TextElementTextRunTextElementStyle? TextElementStyle { get; set; }

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// </summary>
                        public record TextElementTextRunTextElementStyle
                        {
                            /// <summary>
                            /// <para>加粗</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("bold")]
                            public bool? Bold { get; set; }

                            /// <summary>
                            /// <para>斜体</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("italic")]
                            public bool? Italic { get; set; }

                            /// <summary>
                            /// <para>删除线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("strikethrough")]
                            public bool? Strikethrough { get; set; }

                            /// <summary>
                            /// <para>下划线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("underline")]
                            public bool? Underline { get; set; }

                            /// <summary>
                            /// <para>inline 代码</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("inline_code")]
                            public bool? InlineCode { get; set; }

                            /// <summary>
                            /// <para>背景色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：浅粉红色</item>
                            /// <item>2：浅橙色</item>
                            /// <item>3：浅黄色</item>
                            /// <item>4：浅绿色</item>
                            /// <item>5：浅蓝色</item>
                            /// <item>6：浅紫色</item>
                            /// <item>7：浅灰色</item>
                            /// <item>8：暗粉红色</item>
                            /// <item>9：暗橙色</item>
                            /// <item>10：暗黄色</item>
                            /// <item>11：暗绿色</item>
                            /// <item>12：暗蓝色</item>
                            /// <item>13：暗紫色</item>
                            /// <item>14：暗灰色</item>
                            /// <item>15：暗银灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("background_color")]
                            public int? BackgroundColor { get; set; }

                            /// <summary>
                            /// <para>字体颜色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：粉红色</item>
                            /// <item>2：橙色</item>
                            /// <item>3：黄色</item>
                            /// <item>4：绿色</item>
                            /// <item>5：蓝色</item>
                            /// <item>6：紫色</item>
                            /// <item>7：灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("text_color")]
                            public int? TextColor { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("link")]
                            public TextElementTextRunTextElementStyleLink? Link { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// </summary>
                            public record TextElementTextRunTextElementStyleLink
                            {
                                /// <summary>
                                /// <para>超链接指向的 url (需要 url_encode)</para>
                                /// <para>必填：是</para>
                                /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                                /// </summary>
                                [JsonPropertyName("url")]
                                public string Url { get; set; } = string.Empty;
                            }

                            /// <summary>
                            /// <para>评论 id 列表</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：["1660030311959965796"]</para>
                            /// </summary>
                            [JsonPropertyName("comment_ids")]
                            public string[]? CommentIds { get; set; }
                        }
                    }

                    /// <summary>
                    /// <para>@用户</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("mention_user")]
                    public TextElementMentionUser? MentionUser { get; set; }

                    /// <summary>
                    /// <para>@用户</para>
                    /// </summary>
                    public record TextElementMentionUser
                    {
                        /// <summary>
                        /// <para>用户 OpenID</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：ou_3bbe8a09c20e89cce9bff989ed840674</para>
                        /// </summary>
                        [JsonPropertyName("user_id")]
                        public string UserId { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("text_element_style")]
                        public TextElementMentionUserTextElementStyle? TextElementStyle { get; set; }

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// </summary>
                        public record TextElementMentionUserTextElementStyle
                        {
                            /// <summary>
                            /// <para>加粗</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("bold")]
                            public bool? Bold { get; set; }

                            /// <summary>
                            /// <para>斜体</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("italic")]
                            public bool? Italic { get; set; }

                            /// <summary>
                            /// <para>删除线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("strikethrough")]
                            public bool? Strikethrough { get; set; }

                            /// <summary>
                            /// <para>下划线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("underline")]
                            public bool? Underline { get; set; }

                            /// <summary>
                            /// <para>inline 代码</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("inline_code")]
                            public bool? InlineCode { get; set; }

                            /// <summary>
                            /// <para>背景色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：浅粉红色</item>
                            /// <item>2：浅橙色</item>
                            /// <item>3：浅黄色</item>
                            /// <item>4：浅绿色</item>
                            /// <item>5：浅蓝色</item>
                            /// <item>6：浅紫色</item>
                            /// <item>7：浅灰色</item>
                            /// <item>8：暗粉红色</item>
                            /// <item>9：暗橙色</item>
                            /// <item>10：暗黄色</item>
                            /// <item>11：暗绿色</item>
                            /// <item>12：暗蓝色</item>
                            /// <item>13：暗紫色</item>
                            /// <item>14：暗灰色</item>
                            /// <item>15：暗银灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("background_color")]
                            public int? BackgroundColor { get; set; }

                            /// <summary>
                            /// <para>字体颜色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：粉红色</item>
                            /// <item>2：橙色</item>
                            /// <item>3：黄色</item>
                            /// <item>4：绿色</item>
                            /// <item>5：蓝色</item>
                            /// <item>6：紫色</item>
                            /// <item>7：灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("text_color")]
                            public int? TextColor { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("link")]
                            public TextElementMentionUserTextElementStyleLink? Link { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// </summary>
                            public record TextElementMentionUserTextElementStyleLink
                            {
                                /// <summary>
                                /// <para>超链接指向的 url (需要 url_encode)</para>
                                /// <para>必填：是</para>
                                /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                                /// </summary>
                                [JsonPropertyName("url")]
                                public string Url { get; set; } = string.Empty;
                            }

                            /// <summary>
                            /// <para>评论 id 列表</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：["1660030311959965796"]</para>
                            /// </summary>
                            [JsonPropertyName("comment_ids")]
                            public string[]? CommentIds { get; set; }
                        }
                    }

                    /// <summary>
                    /// <para>@文档</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("mention_doc")]
                    public TextElementMentionDoc? MentionDoc { get; set; }

                    /// <summary>
                    /// <para>@文档</para>
                    /// </summary>
                    public record TextElementMentionDoc
                    {
                        /// <summary>
                        /// <para>云文档 token</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：doxbc873Y7cXD153gXqb76G1Y9b</para>
                        /// </summary>
                        [JsonPropertyName("token")]
                        public string Token { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>云文档类型</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：22</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：Doc</item>
                        /// <item>3：Sheet</item>
                        /// <item>8：Bitable</item>
                        /// <item>11：MindNote</item>
                        /// <item>12：File</item>
                        /// <item>15：Slide</item>
                        /// <item>16：Wiki</item>
                        /// <item>22：Docx</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("obj_type")]
                        public int ObjType { get; set; }

                        /// <summary>
                        /// <para>云文档链接（需要 url_encode)</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：https%3A%2F%2Fbytedance.feishu-boe.cn%2Fdocx%2Fdoxbc873Y7cXD153gXqb76G1Y9b</para>
                        /// </summary>
                        [JsonPropertyName("url")]
                        public string Url { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文档标题，只读属性</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：undefined</para>
                        /// <para>最大长度：800</para>
                        /// <para>最小长度：0</para>
                        /// </summary>
                        [JsonPropertyName("title")]
                        public string? Title { get; set; }

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("text_element_style")]
                        public TextElementMentionDocTextElementStyle? TextElementStyle { get; set; }

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// </summary>
                        public record TextElementMentionDocTextElementStyle
                        {
                            /// <summary>
                            /// <para>加粗</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("bold")]
                            public bool? Bold { get; set; }

                            /// <summary>
                            /// <para>斜体</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("italic")]
                            public bool? Italic { get; set; }

                            /// <summary>
                            /// <para>删除线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("strikethrough")]
                            public bool? Strikethrough { get; set; }

                            /// <summary>
                            /// <para>下划线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("underline")]
                            public bool? Underline { get; set; }

                            /// <summary>
                            /// <para>inline 代码</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("inline_code")]
                            public bool? InlineCode { get; set; }

                            /// <summary>
                            /// <para>背景色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：浅粉红色</item>
                            /// <item>2：浅橙色</item>
                            /// <item>3：浅黄色</item>
                            /// <item>4：浅绿色</item>
                            /// <item>5：浅蓝色</item>
                            /// <item>6：浅紫色</item>
                            /// <item>7：浅灰色</item>
                            /// <item>8：暗粉红色</item>
                            /// <item>9：暗橙色</item>
                            /// <item>10：暗黄色</item>
                            /// <item>11：暗绿色</item>
                            /// <item>12：暗蓝色</item>
                            /// <item>13：暗紫色</item>
                            /// <item>14：暗灰色</item>
                            /// <item>15：暗银灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("background_color")]
                            public int? BackgroundColor { get; set; }

                            /// <summary>
                            /// <para>字体颜色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：粉红色</item>
                            /// <item>2：橙色</item>
                            /// <item>3：黄色</item>
                            /// <item>4：绿色</item>
                            /// <item>5：蓝色</item>
                            /// <item>6：紫色</item>
                            /// <item>7：灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("text_color")]
                            public int? TextColor { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("link")]
                            public TextElementMentionDocTextElementStyleLink? Link { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// </summary>
                            public record TextElementMentionDocTextElementStyleLink
                            {
                                /// <summary>
                                /// <para>超链接指向的 url (需要 url_encode)</para>
                                /// <para>必填：是</para>
                                /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                                /// </summary>
                                [JsonPropertyName("url")]
                                public string Url { get; set; } = string.Empty;
                            }

                            /// <summary>
                            /// <para>评论 id 列表</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：["1660030311959965796"]</para>
                            /// </summary>
                            [JsonPropertyName("comment_ids")]
                            public string[]? CommentIds { get; set; }
                        }
                    }

                    /// <summary>
                    /// <para>日期提醒</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("reminder")]
                    public TextElementReminder? Reminder { get; set; }

                    /// <summary>
                    /// <para>日期提醒</para>
                    /// </summary>
                    public record TextElementReminder
                    {
                        /// <summary>
                        /// <para>创建者用户 ID</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：0e2633a3-aa1a-4171-af9e-0768ff863566</para>
                        /// </summary>
                        [JsonPropertyName("create_user_id")]
                        public string CreateUserId { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>是否通知</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("is_notify")]
                        public bool? IsNotify { get; set; }

                        /// <summary>
                        /// <para>是日期还是整点小时</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("is_whole_day")]
                        public bool? IsWholeDay { get; set; }

                        /// <summary>
                        /// <para>事件发生的时间（毫秒级事件戳）</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：1641967200000</para>
                        /// </summary>
                        [JsonPropertyName("expire_time")]
                        public string ExpireTime { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>触发通知的时间（毫秒级时间戳）</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：1643166000000</para>
                        /// </summary>
                        [JsonPropertyName("notify_time")]
                        public string NotifyTime { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("text_element_style")]
                        public TextElementReminderTextElementStyle? TextElementStyle { get; set; }

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// </summary>
                        public record TextElementReminderTextElementStyle
                        {
                            /// <summary>
                            /// <para>加粗</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("bold")]
                            public bool? Bold { get; set; }

                            /// <summary>
                            /// <para>斜体</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("italic")]
                            public bool? Italic { get; set; }

                            /// <summary>
                            /// <para>删除线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("strikethrough")]
                            public bool? Strikethrough { get; set; }

                            /// <summary>
                            /// <para>下划线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("underline")]
                            public bool? Underline { get; set; }

                            /// <summary>
                            /// <para>inline 代码</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("inline_code")]
                            public bool? InlineCode { get; set; }

                            /// <summary>
                            /// <para>背景色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：浅粉红色</item>
                            /// <item>2：浅橙色</item>
                            /// <item>3：浅黄色</item>
                            /// <item>4：浅绿色</item>
                            /// <item>5：浅蓝色</item>
                            /// <item>6：浅紫色</item>
                            /// <item>7：浅灰色</item>
                            /// <item>8：暗粉红色</item>
                            /// <item>9：暗橙色</item>
                            /// <item>10：暗黄色</item>
                            /// <item>11：暗绿色</item>
                            /// <item>12：暗蓝色</item>
                            /// <item>13：暗紫色</item>
                            /// <item>14：暗灰色</item>
                            /// <item>15：暗银灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("background_color")]
                            public int? BackgroundColor { get; set; }

                            /// <summary>
                            /// <para>字体颜色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：粉红色</item>
                            /// <item>2：橙色</item>
                            /// <item>3：黄色</item>
                            /// <item>4：绿色</item>
                            /// <item>5：蓝色</item>
                            /// <item>6：紫色</item>
                            /// <item>7：灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("text_color")]
                            public int? TextColor { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("link")]
                            public TextElementReminderTextElementStyleLink? Link { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// </summary>
                            public record TextElementReminderTextElementStyleLink
                            {
                                /// <summary>
                                /// <para>超链接指向的 url (需要 url_encode)</para>
                                /// <para>必填：是</para>
                                /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                                /// </summary>
                                [JsonPropertyName("url")]
                                public string Url { get; set; } = string.Empty;
                            }

                            /// <summary>
                            /// <para>评论 id 列表</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：["1660030311959965796"]</para>
                            /// </summary>
                            [JsonPropertyName("comment_ids")]
                            public string[]? CommentIds { get; set; }
                        }
                    }

                    /// <summary>
                    /// <para>内联附件</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("file")]
                    public InlineFile? File { get; set; }

                    /// <summary>
                    /// <para>内联附件</para>
                    /// </summary>
                    public record InlineFile
                    {
                        /// <summary>
                        /// <para>附件 token</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：boxcnOj88GDkmWGm2zsTyCBqoLb</para>
                        /// </summary>
                        [JsonPropertyName("file_token")]
                        public string? FileToken { get; set; }

                        /// <summary>
                        /// <para>当前文档中该附件所处的 block 的 id</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：doxcnM46kSWSkgUMW04ldKsJDsc</para>
                        /// </summary>
                        [JsonPropertyName("source_block_id")]
                        public string? SourceBlockId { get; set; }

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("text_element_style")]
                        public InlineFileTextElementStyle? TextElementStyle { get; set; }

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// </summary>
                        public record InlineFileTextElementStyle
                        {
                            /// <summary>
                            /// <para>加粗</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("bold")]
                            public bool? Bold { get; set; }

                            /// <summary>
                            /// <para>斜体</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("italic")]
                            public bool? Italic { get; set; }

                            /// <summary>
                            /// <para>删除线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("strikethrough")]
                            public bool? Strikethrough { get; set; }

                            /// <summary>
                            /// <para>下划线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("underline")]
                            public bool? Underline { get; set; }

                            /// <summary>
                            /// <para>inline 代码</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("inline_code")]
                            public bool? InlineCode { get; set; }

                            /// <summary>
                            /// <para>背景色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：浅粉红色</item>
                            /// <item>2：浅橙色</item>
                            /// <item>3：浅黄色</item>
                            /// <item>4：浅绿色</item>
                            /// <item>5：浅蓝色</item>
                            /// <item>6：浅紫色</item>
                            /// <item>7：浅灰色</item>
                            /// <item>8：暗粉红色</item>
                            /// <item>9：暗橙色</item>
                            /// <item>10：暗黄色</item>
                            /// <item>11：暗绿色</item>
                            /// <item>12：暗蓝色</item>
                            /// <item>13：暗紫色</item>
                            /// <item>14：暗灰色</item>
                            /// <item>15：暗银灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("background_color")]
                            public int? BackgroundColor { get; set; }

                            /// <summary>
                            /// <para>字体颜色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：粉红色</item>
                            /// <item>2：橙色</item>
                            /// <item>3：黄色</item>
                            /// <item>4：绿色</item>
                            /// <item>5：蓝色</item>
                            /// <item>6：紫色</item>
                            /// <item>7：灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("text_color")]
                            public int? TextColor { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("link")]
                            public InlineFileTextElementStyleLink? Link { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// </summary>
                            public record InlineFileTextElementStyleLink
                            {
                                /// <summary>
                                /// <para>超链接指向的 url (需要 url_encode)</para>
                                /// <para>必填：是</para>
                                /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                                /// </summary>
                                [JsonPropertyName("url")]
                                public string Url { get; set; } = string.Empty;
                            }

                            /// <summary>
                            /// <para>评论 id 列表</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：["1660030311959965796"]</para>
                            /// </summary>
                            [JsonPropertyName("comment_ids")]
                            public string[]? CommentIds { get; set; }
                        }
                    }

                    /// <summary>
                    /// <para>未支持的 TextElement</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("undefined")]
                    public object? Undefined { get; set; }

                    /// <summary>
                    /// <para>内联 block</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("inline_block")]
                    public TextElementInlineBlock? InlineBlock { get; set; }

                    /// <summary>
                    /// <para>内联 block</para>
                    /// </summary>
                    public record TextElementInlineBlock
                    {
                        /// <summary>
                        /// <para>关联的内联状态的 block 的 block_id</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：doxcnPFi0R56ctbvh2MjkkROFWf</para>
                        /// </summary>
                        [JsonPropertyName("block_id")]
                        public string BlockId { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("text_element_style")]
                        public TextElementInlineBlockTextElementStyle? TextElementStyle { get; set; }

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// </summary>
                        public record TextElementInlineBlockTextElementStyle
                        {
                            /// <summary>
                            /// <para>加粗</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("bold")]
                            public bool? Bold { get; set; }

                            /// <summary>
                            /// <para>斜体</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("italic")]
                            public bool? Italic { get; set; }

                            /// <summary>
                            /// <para>删除线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("strikethrough")]
                            public bool? Strikethrough { get; set; }

                            /// <summary>
                            /// <para>下划线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("underline")]
                            public bool? Underline { get; set; }

                            /// <summary>
                            /// <para>inline 代码</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("inline_code")]
                            public bool? InlineCode { get; set; }

                            /// <summary>
                            /// <para>背景色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：浅粉红色</item>
                            /// <item>2：浅橙色</item>
                            /// <item>3：浅黄色</item>
                            /// <item>4：浅绿色</item>
                            /// <item>5：浅蓝色</item>
                            /// <item>6：浅紫色</item>
                            /// <item>7：浅灰色</item>
                            /// <item>8：暗粉红色</item>
                            /// <item>9：暗橙色</item>
                            /// <item>10：暗黄色</item>
                            /// <item>11：暗绿色</item>
                            /// <item>12：暗蓝色</item>
                            /// <item>13：暗紫色</item>
                            /// <item>14：暗灰色</item>
                            /// <item>15：暗银灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("background_color")]
                            public int? BackgroundColor { get; set; }

                            /// <summary>
                            /// <para>字体颜色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：粉红色</item>
                            /// <item>2：橙色</item>
                            /// <item>3：黄色</item>
                            /// <item>4：绿色</item>
                            /// <item>5：蓝色</item>
                            /// <item>6：紫色</item>
                            /// <item>7：灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("text_color")]
                            public int? TextColor { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("link")]
                            public TextElementInlineBlockTextElementStyleLink? Link { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// </summary>
                            public record TextElementInlineBlockTextElementStyleLink
                            {
                                /// <summary>
                                /// <para>超链接指向的 url (需要 url_encode)</para>
                                /// <para>必填：是</para>
                                /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                                /// </summary>
                                [JsonPropertyName("url")]
                                public string Url { get; set; } = string.Empty;
                            }

                            /// <summary>
                            /// <para>评论 id 列表</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：["1660030311959965796"]</para>
                            /// </summary>
                            [JsonPropertyName("comment_ids")]
                            public string[]? CommentIds { get; set; }
                        }
                    }

                    /// <summary>
                    /// <para>公式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("equation")]
                    public TextElementEquation? Equation { get; set; }

                    /// <summary>
                    /// <para>公式</para>
                    /// </summary>
                    public record TextElementEquation
                    {
                        /// <summary>
                        /// <para>符合 KaTeX 语法的公式内容，语法规则请参考：https://katex.org/docs/supported.html</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：E=mc^2\n</para>
                        /// </summary>
                        [JsonPropertyName("content")]
                        public string Content { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("text_element_style")]
                        public TextElementEquationTextElementStyle? TextElementStyle { get; set; }

                        /// <summary>
                        /// <para>文本局部样式</para>
                        /// </summary>
                        public record TextElementEquationTextElementStyle
                        {
                            /// <summary>
                            /// <para>加粗</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("bold")]
                            public bool? Bold { get; set; }

                            /// <summary>
                            /// <para>斜体</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("italic")]
                            public bool? Italic { get; set; }

                            /// <summary>
                            /// <para>删除线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("strikethrough")]
                            public bool? Strikethrough { get; set; }

                            /// <summary>
                            /// <para>下划线</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("underline")]
                            public bool? Underline { get; set; }

                            /// <summary>
                            /// <para>inline 代码</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：true</para>
                            /// <para>默认值：false</para>
                            /// </summary>
                            [JsonPropertyName("inline_code")]
                            public bool? InlineCode { get; set; }

                            /// <summary>
                            /// <para>背景色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：浅粉红色</item>
                            /// <item>2：浅橙色</item>
                            /// <item>3：浅黄色</item>
                            /// <item>4：浅绿色</item>
                            /// <item>5：浅蓝色</item>
                            /// <item>6：浅紫色</item>
                            /// <item>7：浅灰色</item>
                            /// <item>8：暗粉红色</item>
                            /// <item>9：暗橙色</item>
                            /// <item>10：暗黄色</item>
                            /// <item>11：暗绿色</item>
                            /// <item>12：暗蓝色</item>
                            /// <item>13：暗紫色</item>
                            /// <item>14：暗灰色</item>
                            /// <item>15：暗银灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("background_color")]
                            public int? BackgroundColor { get; set; }

                            /// <summary>
                            /// <para>字体颜色</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：粉红色</item>
                            /// <item>2：橙色</item>
                            /// <item>3：黄色</item>
                            /// <item>4：绿色</item>
                            /// <item>5：蓝色</item>
                            /// <item>6：紫色</item>
                            /// <item>7：灰色</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("text_color")]
                            public int? TextColor { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("link")]
                            public TextElementEquationTextElementStyleLink? Link { get; set; }

                            /// <summary>
                            /// <para>链接</para>
                            /// </summary>
                            public record TextElementEquationTextElementStyleLink
                            {
                                /// <summary>
                                /// <para>超链接指向的 url (需要 url_encode)</para>
                                /// <para>必填：是</para>
                                /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                                /// </summary>
                                [JsonPropertyName("url")]
                                public string Url { get; set; } = string.Empty;
                            }

                            /// <summary>
                            /// <para>评论 id 列表</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：["1660030311959965796"]</para>
                            /// </summary>
                            [JsonPropertyName("comment_ids")]
                            public string[]? CommentIds { get; set; }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// <para>OKR 进展信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("okr_progress")]
        public object? OkrProgress { get; set; }

        /// <summary>
        /// <para>评论 id 列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：[1660030311959965796]</para>
        /// </summary>
        [JsonPropertyName("comment_ids")]
        public string[]? CommentIds { get; set; }

        /// <summary>
        /// <para>Jira Issue</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("jira_issue")]
        public BlockJiraIssue? JiraIssue { get; set; }

        /// <summary>
        /// <para>Jira Issue</para>
        /// </summary>
        public record BlockJiraIssue
        {
            /// <summary>
            /// <para>Jira issue ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：12345</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>Jira issue key</para>
            /// <para>必填：否</para>
            /// <para>示例值：Project-123</para>
            /// </summary>
            [JsonPropertyName("key")]
            public string? Key { get; set; }
        }

        /// <summary>
        /// <para>Wiki 子目录 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("wiki_catalog")]
        public BlockWikiCatalog? WikiCatalog { get; set; }

        /// <summary>
        /// <para>Wiki 子目录 Block</para>
        /// </summary>
        public record BlockWikiCatalog
        {
            /// <summary>
            /// <para>知识库 token</para>
            /// <para>必填：否</para>
            /// <para>示例值：Ub47wVl7AikG9wkgnpSbFy4EcAc</para>
            /// </summary>
            [JsonPropertyName("wiki_token")]
            public string? WikiToken { get; set; }
        }

        /// <summary>
        /// <para>画板 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("board")]
        public BlockBoard? Board { get; set; }

        /// <summary>
        /// <para>画板 Block</para>
        /// </summary>
        public record BlockBoard
        {
            /// <summary>
            /// <para>画板 token</para>
            /// <para>必填：否</para>
            /// <para>示例值：EfSPwsv03hVDKJbh1FWczJbWn90</para>
            /// </summary>
            [JsonPropertyName("token")]
            public string? Token { get; set; }

            /// <summary>
            /// <para>对齐方式</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：居左排版</item>
            /// <item>2：居中排版</item>
            /// <item>3：居右排版</item>
            /// </list></para>
            /// <para>默认值：1</para>
            /// </summary>
            [JsonPropertyName("align")]
            public int? Align { get; set; }

            /// <summary>
            /// <para>宽度，单位 px；不填时自动适应文档宽度；值超出文档最大宽度时，页面渲染为文档最大宽度</para>
            /// <para>必填：否</para>
            /// <para>示例值：300</para>
            /// <para>最小值：90</para>
            /// </summary>
            [JsonPropertyName("width")]
            public int? Width { get; set; }

            /// <summary>
            /// <para>高度，单位 px；不填时自动根据画板内容计算；值超出屏幕两倍高度时，页面渲染为屏幕两倍高度</para>
            /// <para>必填：否</para>
            /// <para>示例值：300</para>
            /// <para>最小值：90</para>
            /// </summary>
            [JsonPropertyName("height")]
            public int? Height { get; set; }
        }

        /// <summary>
        /// <para>议程 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agenda")]
        public object? Agenda { get; set; }

        /// <summary>
        /// <para>议程项 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agenda_item")]
        public object? AgendaItem { get; set; }

        /// <summary>
        /// <para>议程项标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agenda_item_title")]
        public BlockAgendaItemTitle? AgendaItemTitle { get; set; }

        /// <summary>
        /// <para>议程项标题 Block</para>
        /// </summary>
        public record BlockAgendaItemTitle
        {
            /// <summary>
            /// <para>文本元素</para>
            /// <para>必填：是</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("elements")]
            public AgendaTitleElement[] Elements { get; set; } = Array.Empty<AgendaTitleElement>();

            /// <summary>
            /// <para>文本元素</para>
            /// </summary>
            public record AgendaTitleElement
            {
                /// <summary>
                /// <para>文字</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("text_run")]
                public AgendaTitleElementTextRun? TextRun { get; set; }

                /// <summary>
                /// <para>文字</para>
                /// </summary>
                public record AgendaTitleElementTextRun
                {
                    /// <summary>
                    /// <para>文本内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：文本</para>
                    /// </summary>
                    [JsonPropertyName("content")]
                    public string Content { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public AgendaTitleElementTextRunTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record AgendaTitleElementTextRunTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public AgendaTitleElementTextRunTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record AgendaTitleElementTextRunTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>@用户</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mention_user")]
                public AgendaTitleElementMentionUser? MentionUser { get; set; }

                /// <summary>
                /// <para>@用户</para>
                /// </summary>
                public record AgendaTitleElementMentionUser
                {
                    /// <summary>
                    /// <para>用户 OpenID</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：ou_3bbe8a09c20e89cce9bff989ed840674</para>
                    /// </summary>
                    [JsonPropertyName("user_id")]
                    public string UserId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public AgendaTitleElementMentionUserTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record AgendaTitleElementMentionUserTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public AgendaTitleElementMentionUserTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record AgendaTitleElementMentionUserTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>@文档</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mention_doc")]
                public AgendaTitleElementMentionDoc? MentionDoc { get; set; }

                /// <summary>
                /// <para>@文档</para>
                /// </summary>
                public record AgendaTitleElementMentionDoc
                {
                    /// <summary>
                    /// <para>云文档 token</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：doxbc873Y7cXD153gXqb76G1Y9b</para>
                    /// </summary>
                    [JsonPropertyName("token")]
                    public string Token { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>云文档类型</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：22</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：Doc</item>
                    /// <item>3：Sheet</item>
                    /// <item>8：Bitable</item>
                    /// <item>11：MindNote</item>
                    /// <item>12：File</item>
                    /// <item>15：Slide</item>
                    /// <item>16：Wiki</item>
                    /// <item>22：Docx</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("obj_type")]
                    public int ObjType { get; set; }

                    /// <summary>
                    /// <para>云文档链接（需要 url_encode)</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：https%3A%2F%2Fbytedance.feishu-boe.cn%2Fdocx%2Fdoxbc873Y7cXD153gXqb76G1Y9b</para>
                    /// </summary>
                    [JsonPropertyName("url")]
                    public string Url { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文档标题，只读属性</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：undefined</para>
                    /// <para>最大长度：800</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("title")]
                    public string? Title { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public AgendaTitleElementMentionDocTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record AgendaTitleElementMentionDocTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public AgendaTitleElementMentionDocTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record AgendaTitleElementMentionDocTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>日期提醒</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("reminder")]
                public AgendaTitleElementReminder? Reminder { get; set; }

                /// <summary>
                /// <para>日期提醒</para>
                /// </summary>
                public record AgendaTitleElementReminder
                {
                    /// <summary>
                    /// <para>创建者用户 ID</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：0e2633a3-aa1a-4171-af9e-0768ff863566</para>
                    /// </summary>
                    [JsonPropertyName("create_user_id")]
                    public string CreateUserId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>是否通知</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonPropertyName("is_notify")]
                    public bool? IsNotify { get; set; }

                    /// <summary>
                    /// <para>是日期还是整点小时</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonPropertyName("is_whole_day")]
                    public bool? IsWholeDay { get; set; }

                    /// <summary>
                    /// <para>事件发生的时间（毫秒级事件戳）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1641967200000</para>
                    /// </summary>
                    [JsonPropertyName("expire_time")]
                    public string ExpireTime { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>触发通知的时间（毫秒级时间戳）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1643166000000</para>
                    /// </summary>
                    [JsonPropertyName("notify_time")]
                    public string NotifyTime { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public AgendaTitleElementReminderTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record AgendaTitleElementReminderTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public AgendaTitleElementReminderTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record AgendaTitleElementReminderTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>内联附件</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("file")]
                public InlineFile? File { get; set; }

                /// <summary>
                /// <para>内联附件</para>
                /// </summary>
                public record InlineFile
                {
                    /// <summary>
                    /// <para>附件 token</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：boxcnOj88GDkmWGm2zsTyCBqoLb</para>
                    /// </summary>
                    [JsonPropertyName("file_token")]
                    public string? FileToken { get; set; }

                    /// <summary>
                    /// <para>当前文档中该附件所处的 block 的 id</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：doxcnM46kSWSkgUMW04ldKsJDsc</para>
                    /// </summary>
                    [JsonPropertyName("source_block_id")]
                    public string? SourceBlockId { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public InlineFileTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record InlineFileTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public InlineFileTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record InlineFileTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>未支持的 TextElement</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("undefined")]
                public object? Undefined { get; set; }

                /// <summary>
                /// <para>内联 block</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("inline_block")]
                public AgendaTitleElementInlineBlock? InlineBlock { get; set; }

                /// <summary>
                /// <para>内联 block</para>
                /// </summary>
                public record AgendaTitleElementInlineBlock
                {
                    /// <summary>
                    /// <para>关联的内联状态的 block 的 block_id</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：doxcnPFi0R56ctbvh2MjkkROFWf</para>
                    /// </summary>
                    [JsonPropertyName("block_id")]
                    public string BlockId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public AgendaTitleElementInlineBlockTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record AgendaTitleElementInlineBlockTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public AgendaTitleElementInlineBlockTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record AgendaTitleElementInlineBlockTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>公式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("equation")]
                public AgendaTitleElementEquation? Equation { get; set; }

                /// <summary>
                /// <para>公式</para>
                /// </summary>
                public record AgendaTitleElementEquation
                {
                    /// <summary>
                    /// <para>符合 KaTeX 语法的公式内容，语法规则请参考：https://katex.org/docs/supported.html</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：E=mc^2\n</para>
                    /// </summary>
                    [JsonPropertyName("content")]
                    public string Content { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public AgendaTitleElementEquationTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record AgendaTitleElementEquationTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public AgendaTitleElementEquationTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record AgendaTitleElementEquationTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }
            }

            /// <summary>
            /// <para>对齐方式</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：居左排版</item>
            /// <item>2：居中排版</item>
            /// <item>3：居右排版</item>
            /// </list></para>
            /// <para>默认值：1</para>
            /// </summary>
            [JsonPropertyName("align")]
            public int? Align { get; set; }
        }

        /// <summary>
        /// <para>议程项内容 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agenda_item_content")]
        public object? AgendaItemContent { get; set; }

        /// <summary>
        /// <para>链接预览 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("link_preview")]
        public BlockLinkPreview? LinkPreview { get; set; }

        /// <summary>
        /// <para>链接预览 Block</para>
        /// </summary>
        public record BlockLinkPreview
        {
            /// <summary>
            /// <para>链接</para>
            /// <para>必填：是</para>
            /// <para>示例值：https://applink.feishu.cn/client/message/link/open?token=Al7F******Q%3D</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("url")]
            public string Url { get; set; } = string.Empty;

            /// <summary>
            /// <para>链接类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：MessageLink</para>
            /// <para>可选值：<list type="bullet">
            /// <item>MessageLink：消息链接</item>
            /// <item>Undefined：未定义的链接类型</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("url_type")]
            public string UrlType { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>当前更新成功后群公告的版本号</para>
    /// <para>必填：否</para>
    /// <para>示例值：2</para>
    /// </summary>
    [JsonPropertyName("revision_id")]
    public int? RevisionId { get; set; }

    /// <summary>
    /// <para>操作的唯一标识，更新请求中使用此值表示幂等的进行此次更新</para>
    /// <para>必填：否</para>
    /// <para>示例值：8aac2291-bc9e-4b12-a162-b3cf15bb06bd</para>
    /// </summary>
    [JsonPropertyName("client_token")]
    public string? ClientToken { get; set; }
}
