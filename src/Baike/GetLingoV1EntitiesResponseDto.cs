// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetLingoV1EntitiesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取词条列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Baike;
/// <summary>
/// 获取词条列表 响应体
/// <para>分页拉取词条列表数据，支持拉取租户内(或指定词库内)的全部词条。</para>
/// <para>接口ID：7249689905696997404</para>
/// <para>文档地址：https://open.feishu.cn/document/lingo-v1/entity/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2fentity%2flist</para>
/// </summary>
public record GetLingoV1EntitiesResponseDto : IPageableResponse<GetLingoV1EntitiesResponseDto.Entity>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public Entity[]? Items => Entities;

    /// <summary>
    /// <para>词条列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("entities")]
    public Entity[]? Entities { get; set; }

    /// <summary>
    /// <para>词条列表</para>
    /// </summary>
    public record Entity
    {
        /// <summary>
        /// <para>词条 ID</para>
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
                /// <para>对应名称是否在搜索结果中展示</para>
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
        /// <para>纯文本格式词条释义。注：description 和 rich_text 至少有一个，否则会报错：1540001</para>
        /// <para>必填：否</para>
        /// <para>示例值：词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通</para>
        /// <para>最大长度：5000</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>创建者</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_30b07b63089ea46518789914dac63d36</para>
        /// </summary>
        [JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// <para>词条创建时间（秒级时间戳）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1649318125</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>最近一次更新者</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_30b07b63089ea46518789914dac63d36</para>
        /// </summary>
        [JsonPropertyName("updater")]
        public string? Updater { get; set; }

        /// <summary>
        /// <para>最近一次更新词条时间（秒级时间戳）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1649318125</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>更多相关信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("related_meta")]
        public EntityRelatedMeta? RelatedMeta { get; set; }

        /// <summary>
        /// <para>更多相关信息</para>
        /// </summary>
        public record EntityRelatedMeta
        {
            /// <summary>
            /// <para>相关联系人</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("users")]
            public Referer[]? Users { get; set; }

            /// <summary>
            /// <para>相关联系人</para>
            /// </summary>
            public record Referer
            {
                /// <summary>
                /// <para>对应相关信息 ID</para>
                /// <para>必填：是</para>
                /// <para>示例值：7dab8a3d3cdcc9da365777c7ad535d62</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string Id { get; set; } = string.Empty;

                /// <summary>
                /// <para>对应相关信息的描述，如相关联系人的描述、相关链接的标题</para>
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
            /// <para>相关服务中的相关公开群</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("chats")]
            public Referer[]? Chats { get; set; }

            /// <summary>
            /// <para>相关云文档</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("docs")]
            public Referer[]? Docs { get; set; }

            /// <summary>
            /// <para>相关服务中的相关值班号</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("oncalls")]
            public Referer[]? Oncalls { get; set; }

            /// <summary>
            /// <para>相关链接</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("links")]
            public Referer[]? Links { get; set; }

            /// <summary>
            /// <para>相关词条</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("abbreviations")]
            public Abbreviation[]? Abbreviations { get; set; }

            /// <summary>
            /// <para>相关词条</para>
            /// </summary>
            public record Abbreviation
            {
                /// <summary>
                /// <para>相关词条 ID</para>
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
                /// <para>示例值：7049606926702837761</para>
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
                /// <para>通过文件接口上传图片后，获得的图片 token</para>
                /// <para>必填：是</para>
                /// <para>示例值：boxbcEcmKiD3***vgqWTpvdc7jc</para>
                /// </summary>
                [JsonPropertyName("token")]
                public string Token { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>当前词条收到的反馈数据</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("statistics")]
        public EntityStatistics? Statistics { get; set; }

        /// <summary>
        /// <para>当前词条收到的反馈数据</para>
        /// </summary>
        public record EntityStatistics
        {
            /// <summary>
            /// <para>累计点赞</para>
            /// <para>必填：是</para>
            /// <para>示例值：55</para>
            /// </summary>
            [JsonPropertyName("like_count")]
            public int LikeCount { get; set; }

            /// <summary>
            /// <para>当前词条版本收到的负反馈数量</para>
            /// <para>必填：是</para>
            /// <para>示例值：3</para>
            /// </summary>
            [JsonPropertyName("dislike_count")]
            public int DislikeCount { get; set; }
        }

        /// <summary>
        /// <para>外部系统关联数据</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("outer_info")]
        public EntityOuterInfo? OuterInfo { get; set; }

        /// <summary>
        /// <para>外部系统关联数据</para>
        /// </summary>
        public record EntityOuterInfo
        {
            /// <summary>
            /// <para>外部系统（不能包含中横线 "-"）</para>
            /// <para>必填：是</para>
            /// <para>示例值：星云</para>
            /// <para>最大长度：32</para>
            /// <para>最小长度：2</para>
            /// </summary>
            [JsonPropertyName("provider")]
            public string Provider { get; set; } = string.Empty;

            /// <summary>
            /// <para>词条在外部系统中对应的唯一 ID（不能包含中横线 "-"）</para>
            /// <para>必填：是</para>
            /// <para>示例值：12345abc</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("outer_id")]
            public string OuterId { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>富文本格式（当填写富文本内容时，description字段将会失效可不填写），支持的格式参考[飞书词典指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/baike-v1/overview)中的释义部分</para>
        /// <para>必填：否</para>
        /// <para>示例值：加粗&lt;i&gt;斜体&lt;/i&gt;&lt;p&gt;&lt;a href="https://feishu.cn"&gt;l链接&lt;/a&gt;&lt;/p&gt;&lt;p&gt;&lt;span&gt;飞书词典是飞书提供的一款知识管理工具，通过词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通&lt;/span&gt;&lt;/p&gt;</para>
        /// <para>最大长度：5000</para>
        /// </summary>
        [JsonPropertyName("rich_text")]
        public string? RichText { get; set; }

        /// <summary>
        /// <para>词条的创建来源，1：用户主动创建，2：批量导入，3：官方词，4：OpenAPI 创建</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("source")]
        public int? Source { get; set; }

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

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：408ecac018b2e3518db37275e812aad7bb8ad3e755fc886f322ac6c430ba</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
