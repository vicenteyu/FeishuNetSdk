using Newtonsoft.Json;
namespace FeishuNetSdk.Baike;
/// <summary>
/// 创建免审词条 响应体
/// <para>通过此接口创建的词条，无需经过词典管理员审核，直接写入词库。因此，调用此接口时，应当慎重操作。</para>
/// <para>接口ID：7249689905697194012</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/entity/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2fentity%2fcreate</para>
/// </summary>
public record PostLingoV1EntitiesResponseDto
{
    /// <summary>
    /// <para>词条信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("entity")]
    public PostLingoV1EntitiesResponseDtoEntity? Entity { get; set; }

    /// <summary>
    /// <para>词条信息</para>
    /// </summary>
    public record PostLingoV1EntitiesResponseDtoEntity
    {
        /// <summary>
        /// <para>词条 ID （需要更新某个词条时填写，若是创建新词条可不填写）</para>
        /// <para>必填：否</para>
        /// <para>示例值：enterprise_4021***7521</para>
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
            /// <para>名称</para>
            /// <para>必填：是</para>
            /// <para>示例值：飞书词典</para>
            /// </summary>
            [JsonProperty("key")]
            public string Key { get; set; } = string.Empty;

            /// <summary>
            /// <para>展示状态</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonProperty("display_status")]
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
                [JsonProperty("allow_highlight")]
                public bool AllowHighlight { get; set; }

                /// <summary>
                /// <para>是否允许在飞书中被搜索到</para>
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
        /// <para>示例值：词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通</para>
        /// <para>最大长度：5000</para>
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>创建者</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_30b07b***518789914dac63d36</para>
        /// </summary>
        [JsonProperty("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// <para>词条创建时间（秒级时间戳）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1649318125</para>
        /// </summary>
        [JsonProperty("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>最近一次更新者</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_30b07b***518789914dac63d36</para>
        /// </summary>
        [JsonProperty("updater")]
        public string? Updater { get; set; }

        /// <summary>
        /// <para>最近一次更新词条时间（秒级时间戳）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1649318125</para>
        /// </summary>
        [JsonProperty("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>相关数据</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("related_meta")]
        public PostLingoV1EntitiesResponseDtoEntityRelatedMeta? RelatedMeta { get; set; }

        /// <summary>
        /// <para>相关数据</para>
        /// </summary>
        public record PostLingoV1EntitiesResponseDtoEntityRelatedMeta
        {
            /// <summary>
            /// <para>关联用户信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("users")]
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
            /// <para>关联群组信息</para>
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
            /// <para>相关服务中的相关值班号</para>
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
                /// <para>相关其他词条 id</para>
                /// <para>必填：否</para>
                /// <para>示例值：enterprise_51587960</para>
                /// </summary>
                [JsonProperty("id")]
                public string? Id { get; set; }
            }

            /// <summary>
            /// <para>当前词条所属分类</para>
            /// <para>词条只能属于二级分类，且每个一级分类下只能选择一个二级分类。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("classifications")]
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
                /// <para>示例值：7049606926****37761</para>
                /// </summary>
                [JsonProperty("id")]
                public string Id { get; set; } = string.Empty;

                /// <summary>
                /// <para>对应一级分类 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：7049606926****37777</para>
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
                /// <para>通过文件接口上传图片后，获得的图片 token</para>
                /// <para>必填：是</para>
                /// <para>示例值：boxbcEcmKiDia***gqWTpvdc7jc</para>
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
        public PostLingoV1EntitiesResponseDtoEntityStatistics? Statistics { get; set; }

        /// <summary>
        /// <para>当前词条收到的反馈数据</para>
        /// </summary>
        public record PostLingoV1EntitiesResponseDtoEntityStatistics
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
        /// <para>外部 id 关联数据</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("outer_info")]
        public PostLingoV1EntitiesResponseDtoEntityOuterInfo? OuterInfo { get; set; }

        /// <summary>
        /// <para>外部 id 关联数据</para>
        /// </summary>
        public record PostLingoV1EntitiesResponseDtoEntityOuterInfo
        {
            /// <summary>
            /// <para>外部系统（不能包含中横线 "-"）</para>
            /// <para>必填：是</para>
            /// <para>示例值：星云</para>
            /// <para>最大长度：32</para>
            /// </summary>
            [JsonProperty("provider")]
            public string Provider { get; set; } = string.Empty;

            /// <summary>
            /// <para>词条在外部系统中对应的唯一 ID（不能包含中横线 "-"）</para>
            /// <para>必填：是</para>
            /// <para>示例值：client_65326***7498d</para>
            /// <para>最大长度：64</para>
            /// </summary>
            [JsonProperty("outer_id")]
            public string OuterId { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>富文本格式（当填写富文本内容时，description字段将会失效可不填写），支持的格式参考[飞书词典指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/baike-v1/overview)中的释义部分</para>
        /// <para>必填：否</para>
        /// <para>示例值：加粗&lt;i&gt;斜体&lt;/i&gt;&lt;p&gt;&lt;ahref=\"https://feishu.cn\"&gt;链接&lt;/a&gt;&lt;/p&gt;&lt;p&gt;&lt;span&gt;词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通&lt;/span&gt;&lt;/p&gt;</para>
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

        /// <summary>
        /// <para>国际化的词条释义</para>
        /// <para>必填：否</para>
        /// <para>最大长度：3</para>
        /// </summary>
        [JsonProperty("i18n_descs")]
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
            [JsonProperty("language")]
            public int Language { get; set; }

            /// <summary>
            /// <para>纯文本释义</para>
            /// <para>必填：否</para>
            /// <para>示例值：词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通</para>
            /// <para>最大长度：5000</para>
            /// </summary>
            [JsonProperty("description")]
            public string? Description { get; set; }

            /// <summary>
            /// <para>富文本描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：加粗&lt;i&gt;斜体&lt;/i&gt;&lt;p&gt;&lt;ahref=\"https://feishu.cn\"&gt;链接&lt;/a&gt;&lt;/p&gt;&lt;p&gt;&lt;span&gt;词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通&lt;/span&gt;&lt;/p&gt;</para>
            /// <para>最大长度：5000</para>
            /// </summary>
            [JsonProperty("rich_text")]
            public string? RichText { get; set; }
        }
    }
}
