using Newtonsoft.Json;
namespace FeishuNetSdk.Baike;
/// <summary>
/// 模糊搜索词条 响应体
/// <para>传入关键词，与词条名、别名、释义等信息进行模糊匹配，返回搜到的词条信息。</para>
/// <para>接口ID：7016992864837353500</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/baike-v1/entity/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbaike-v1%2fentity%2fsearch</para>
/// </summary>
public record PostBaikeV1EntitiesSearchResponseDto
{
    /// <summary>
    /// <para>搜索结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("entities")]
    public Entity[]? Entities { get; set; }

    /// <summary>
    /// <para>搜索结果</para>
    /// </summary>
    public record Entity
    {
        /// <summary>
        /// <para>词条 ID （需要更新某个词条时填写，若是创建新词条可不填写）</para>
        /// <para>必填：否</para>
        /// <para>示例值：enterprise_40217521</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>词条名</para>
        /// <para>必填：是</para>
        /// <para>最大长度：1</para>
        /// </summary>
        [JsonProperty("main_keys")]
        public Term[] MainKeys { get; set; } = Array.Empty<Term>();

        /// <summary>
        /// <para>词条名</para>
        /// </summary>
        public record Term
        {
            /// <summary>
            /// <para>名称的值</para>
            /// <para>必填：是</para>
            /// <para>示例值：企业百科</para>
            /// </summary>
            [JsonProperty("key")]
            public string Key { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称展示范围</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonProperty("display_status")]
            public TermDisplayStatus DisplayStatus { get; set; } = new();

            /// <summary>
            /// <para>名称展示范围</para>
            /// </summary>
            public record TermDisplayStatus
            {
                /// <summary>
                /// <para>对应名称是否在消息/云文档高亮</para>
                /// <para>必填：是</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonProperty("allow_highlight")]
                public bool AllowHighlight { get; set; }

                /// <summary>
                /// <para>对应名称是否在搜索结果中展示</para>
                /// <para>必填：是</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonProperty("allow_search")]
                public bool AllowSearch { get; set; }
            }
        }

        /// <summary>
        /// <para>别名</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// </summary>
        [JsonProperty("aliases")]
        public Term[]? Aliases { get; set; }

        /// <summary>
        /// <para>纯文本格式词条释义。注：description 和 rich_text 至少有一个，否则会报错：1540001</para>
        /// <para>必填：否</para>
        /// <para>示例值：企业百科是飞书提供的一款知识管理工具，通过企业百科可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通</para>
        /// <para>最大长度：5000</para>
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>词条创建者</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_30b07b63089ea46518789914dac63d36</para>
        /// </summary>
        [JsonProperty("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// <para>词条创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1649318125</para>
        /// </summary>
        [JsonProperty("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>词条最近一次更新者</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_30b07b63089ea46518789914dac63d36</para>
        /// </summary>
        [JsonProperty("updater")]
        public string? Updater { get; set; }

        /// <summary>
        /// <para>词条最近一次更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1649318125</para>
        /// </summary>
        [JsonProperty("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>词条的相关资源</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("related_meta")]
        public EntityRelatedMeta? RelatedMeta { get; set; }

        /// <summary>
        /// <para>词条的相关资源</para>
        /// </summary>
        public record EntityRelatedMeta
        {
            /// <summary>
            /// <para>相关人信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("users")]
            public Referer[]? Users { get; set; }

            /// <summary>
            /// <para>相关人信息</para>
            /// </summary>
            public record Referer
            {
                /// <summary>
                /// <para>数据 id</para>
                /// <para>必填：是</para>
                /// <para>示例值：7dab8a3d3cdcc9da365777c7ad535d62</para>
                /// </summary>
                [JsonProperty("id")]
                public string Id { get; set; } = string.Empty;

                /// <summary>
                /// <para>标题</para>
                /// <para>必填：否</para>
                /// <para>示例值：飞书官网</para>
                /// </summary>
                [JsonProperty("title")]
                public string? Title { get; set; }

                /// <summary>
                /// <para>链接地址</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.feishu.cn/hc/zh-CN</para>
                /// </summary>
                [JsonProperty("url")]
                public string? Url { get; set; }
            }

            /// <summary>
            /// <para>相关公开群信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("chats")]
            public Referer[]? Chats { get; set; }

            /// <summary>
            /// <para>关联文档信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("docs")]
            public Referer[]? Docs { get; set; }

            /// <summary>
            /// <para>关联服务台信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("oncalls")]
            public Referer[]? Oncalls { get; set; }

            /// <summary>
            /// <para>关联链接信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("links")]
            public Referer[]? Links { get; set; }

            /// <summary>
            /// <para>相关词条信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("abbreviations")]
            public Abbreviation[]? Abbreviations { get; set; }

            /// <summary>
            /// <para>相关词条信息</para>
            /// </summary>
            public record Abbreviation
            {
                /// <summary>
                /// <para>相关词条 id</para>
                /// <para>必填：否</para>
                /// <para>示例值：enterprise_51587960</para>
                /// </summary>
                [JsonProperty("id")]
                public string? Id { get; set; }
            }

            /// <summary>
            /// <para>所属分类信息（不支持传入一级分类。词条不可同时属于同一个一级分类下的多个二级分类，一级分类下的二级分类互斥）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("classifications")]
            public Classification[]? Classifications { get; set; }

            /// <summary>
            /// <para>所属分类信息（不支持传入一级分类。词条不可同时属于同一个一级分类下的多个二级分类，一级分类下的二级分类互斥）</para>
            /// </summary>
            public record Classification
            {
                /// <summary>
                /// <para>唯一分类 ID</para>
                /// <para>必填：是</para>
                /// <para>示例值：7049606926702837761</para>
                /// </summary>
                [JsonProperty("id")]
                public string Id { get; set; } = string.Empty;

                /// <summary>
                /// <para>分类名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：行业术语</para>
                /// </summary>
                [JsonProperty("name")]
                public string? Name { get; set; }

                /// <summary>
                /// <para>父级分类的 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：7049606926702837777</para>
                /// </summary>
                [JsonProperty("father_id")]
                public string? FatherId { get; set; }
            }

            /// <summary>
            /// <para>上传的相关图片</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10</para>
            /// </summary>
            [JsonProperty("images")]
            public BaikeImage[]? Images { get; set; }

            /// <summary>
            /// <para>上传的相关图片</para>
            /// </summary>
            public record BaikeImage
            {
                /// <summary>
                /// <para>通过文件接口上传后的图片 token</para>
                /// <para>必填：是</para>
                /// <para>示例值：boxbcEcmKiD****vgqWTpvdc7jc</para>
                /// </summary>
                [JsonProperty("token")]
                public string Token { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>当前词条收到的反馈数据</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("statistics")]
        public EntityStatistics? Statistics { get; set; }

        /// <summary>
        /// <para>当前词条收到的反馈数据</para>
        /// </summary>
        public record EntityStatistics
        {
            /// <summary>
            /// <para>点赞数量</para>
            /// <para>必填：是</para>
            /// <para>示例值：55</para>
            /// </summary>
            [JsonProperty("like_count")]
            public int LikeCount { get; set; }

            /// <summary>
            /// <para>点踩数量</para>
            /// <para>必填：是</para>
            /// <para>示例值：3</para>
            /// </summary>
            [JsonProperty("dislike_count")]
            public int DislikeCount { get; set; }
        }

        /// <summary>
        /// <para>词条在外部系统中的信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("outer_info")]
        public EntityOuterInfo? OuterInfo { get; set; }

        /// <summary>
        /// <para>词条在外部系统中的信息</para>
        /// </summary>
        public record EntityOuterInfo
        {
            /// <summary>
            /// <para>数据提供方（不能包含中横线 "-"）</para>
            /// <para>必填：是</para>
            /// <para>示例值：星云</para>
            /// <para>最大长度：32</para>
            /// </summary>
            [JsonProperty("provider")]
            public string Provider { get; set; } = string.Empty;

            /// <summary>
            /// <para>词条在外部系统的唯一标识，可用来和其他平台的内容进行绑定。需保证和百科词条唯一对应（不能包含中横线 "-"）</para>
            /// <para>必填：是</para>
            /// <para>示例值：12345abc</para>
            /// <para>最大长度：64</para>
            /// </summary>
            [JsonProperty("outer_id")]
            public string OuterId { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>富文本格式（当填写富文本内容时，description字段将会失效可不填写），支持的格式参考[企业百科指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/baike-v1/overview)中的释义部分</para>
        /// <para>必填：否</para>
        /// <para>示例值：&lt;b&gt;加粗&lt;/b&gt;&lt;i&gt;斜体&lt;/i&gt;&lt;p&gt;&lt;ahref="https://feishu.cn"&gt;l链接&lt;/a&gt;&lt;/p&gt;&lt;p&gt;&lt;span&gt;词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通&lt;/span&gt;&lt;/p&gt;</para>
        /// <para>最大长度：5000</para>
        /// </summary>
        [JsonProperty("rich_text")]
        public string? RichText { get; set; }

        /// <summary>
        /// <para>词条的创建来源，1：用户主动创建，2：批量导入，3：官方词，4：OpenAPI 创建</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonProperty("source")]
        public int? Source { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：b152fa6e6f62a291019a04c3a93f365f8ac641910506ff15ff4cad6534e087cb4ed8fa2c</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }
}
