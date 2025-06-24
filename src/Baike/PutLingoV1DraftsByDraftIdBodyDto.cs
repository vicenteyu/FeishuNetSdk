// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutLingoV1DraftsByDraftIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新草稿 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Baike;
/// <summary>
/// 更新草稿 请求体
/// <para>根据 draft_id 更新草稿内容，已审批的草稿无法编辑。</para>
/// <para>接口ID：7249689905697062940</para>
/// <para>文档地址：https://open.feishu.cn/document/lingo-v1/draft/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2fdraft%2fupdate</para>
/// </summary>
public record PutLingoV1DraftsByDraftIdBodyDto
{
    /// <summary>
    /// <para>词条 ID （需要更新某个词条时填写，若是创建新词条可不填写）</para>
    /// <para>必填：否</para>
    /// <para>示例值：enterprise_40217521</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// <para>词条名</para>
    /// <para>必填：是</para>
    /// <para>最大长度：1</para>
    /// </summary>
    [JsonPropertyName("main_keys")]
    public Term[] MainKeys { get; set; } = Array.Empty<Term>();

    /// <summary>
    /// <para>词条名</para>
    /// </summary>
    public record Term
    {
        /// <summary>
        /// <para>名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：飞书词典</para>
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// <para>展示状态</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("display_status")]
        public TermDisplayStatus DisplayStatus { get; set; } = new();

        /// <summary>
        /// <para>展示状态</para>
        /// </summary>
        public record TermDisplayStatus
        {
            /// <summary>
            /// <para>是否允许在 IM 和 Doc 等场景进行高亮提示</para>
            /// <para>必填：是</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("allow_highlight")]
            public bool AllowHighlight { get; set; }

            /// <summary>
            /// <para>是否允许在飞书中被搜索到</para>
            /// <para>必填：是</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("allow_search")]
            public bool AllowSearch { get; set; }
        }
    }

    /// <summary>
    /// <para>别名</para>
    /// <para>必填：否</para>
    /// <para>最大长度：10</para>
    /// </summary>
    [JsonPropertyName("aliases")]
    public Term[]? Aliases { get; set; }

    /// <summary>
    /// <para>详情描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通</para>
    /// <para>最大长度：5000</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>相关数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("related_meta")]
    public PutLingoV1DraftsByDraftIdBodyDtoRelatedMeta? RelatedMeta { get; set; }

    /// <summary>
    /// <para>相关数据</para>
    /// </summary>
    public record PutLingoV1DraftsByDraftIdBodyDtoRelatedMeta
    {
        /// <summary>
        /// <para>关联用户信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("users")]
        public Referer[]? Users { get; set; }

        /// <summary>
        /// <para>关联用户信息</para>
        /// </summary>
        public record Referer
        {
            /// <summary>
            /// <para>数据 id</para>
            /// <para>必填：是</para>
            /// <para>示例值：格式请看请求体示例</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>标题</para>
            /// <para>必填：否</para>
            /// <para>示例值：飞书官网</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>链接地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://www.feishu.cn/hc/zh-CN</para>
            /// </summary>
            [JsonPropertyName("url")]
            public string? Url { get; set; }
        }

        /// <summary>
        /// <para>关联群组信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("chats")]
        public Referer[]? Chats { get; set; }

        /// <summary>
        /// <para>关联文档信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("docs")]
        public Referer[]? Docs { get; set; }

        /// <summary>
        /// <para>关联值班者信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("oncalls")]
        public Referer[]? Oncalls { get; set; }

        /// <summary>
        /// <para>关联链接信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("links")]
        public Referer[]? Links { get; set; }

        /// <summary>
        /// <para>相关词条信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("abbreviations")]
        public Abbreviation[]? Abbreviations { get; set; }

        /// <summary>
        /// <para>相关词条信息</para>
        /// </summary>
        public record Abbreviation
        {
            /// <summary>
            /// <para>相关其他词条 id</para>
            /// <para>必填：否</para>
            /// <para>示例值：enterprise_51587960</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }
        }

        /// <summary>
        /// <para>当前词条所属分类</para>
        /// <para>词条只能属于二级分类，且每个一级分类下只能选择一个二级分类。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("classifications")]
        public Classification[]? Classifications { get; set; }

        /// <summary>
        /// <para>当前词条所属分类</para>
        /// <para>词条只能属于二级分类，且每个一级分类下只能选择一个二级分类。</para>
        /// </summary>
        public record Classification
        {
            /// <summary>
            /// <para>二级分类 ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：70496069267***37761</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>对应一级分类 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7049606926702837777</para>
            /// </summary>
            [JsonPropertyName("father_id")]
            public string? FatherId { get; set; }
        }

        /// <summary>
        /// <para>上传的相关图片</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// </summary>
        [JsonPropertyName("images")]
        public BaikeImage[]? Images { get; set; }

        /// <summary>
        /// <para>上传的相关图片</para>
        /// </summary>
        public record BaikeImage
        {
            /// <summary>
            /// <para>通过文件接口上传后的图片 token</para>
            /// <para>必填：是</para>
            /// <para>示例值：boxbcEcmKiDia3evgqWTpvdc7jc</para>
            /// </summary>
            [JsonPropertyName("token")]
            public string Token { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>富文本格式（当填写富文本内容时，description字段将会失效可不填写），支持的格式参考[飞书词典指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/baike-v1/overview)中的释义部分</para>
    /// <para>必填：否</para>
    /// <para>示例值：加粗&lt;i&gt;斜体&lt;/i&gt;&lt;p&gt;&lt;a href=\"https://feishu.cn\"&gt;链接&lt;/a&gt;&lt;/p&gt;&lt;p&gt;&lt;span&gt;词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通&lt;/span&gt;&lt;/p&gt;</para>
    /// <para>最大长度：5000</para>
    /// </summary>
    [JsonPropertyName("rich_text")]
    public string? RichText { get; set; }

    /// <summary>
    /// <para>国际化的词条释义</para>
    /// <para>必填：否</para>
    /// <para>最大长度：3</para>
    /// </summary>
    [JsonPropertyName("i18n_descs")]
    public I18nEntryDesc[]? I18nDescs { get; set; }

    /// <summary>
    /// <para>国际化的词条释义</para>
    /// </summary>
    public record I18nEntryDesc
    {
        /// <summary>
        /// <para>语言类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：中文</item>
        /// <item>2：英文</item>
        /// <item>3：日文</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("language")]
        public int Language { get; set; }

        /// <summary>
        /// <para>纯文本释义</para>
        /// <para>必填：否</para>
        /// <para>示例值：词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通</para>
        /// <para>最大长度：5000</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>富文本描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：&lt;p&gt;&lt;span&gt;词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通&lt;/span&gt;&lt;/p&gt;</para>
        /// <para>最大长度：5000</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("rich_text")]
        public string? RichText { get; set; }
    }
}
