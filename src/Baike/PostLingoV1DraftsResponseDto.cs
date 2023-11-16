namespace FeishuNetSdk.Baike;
/// <summary>
/// 创建草稿 响应体
/// <para>草稿并非词条，而是指通过 API 发起创建新词条或更新现有词条的申请。</para>
/// <para>词典管理员审核通过后，草稿将变为新的词条或覆盖已有词条。</para>
/// <para>接口ID：7249689905697046556</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/draft/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2fdraft%2fcreate</para>
/// </summary>
public record PostLingoV1DraftsResponseDto
{
    /// <summary>
    /// <para>草稿信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("draft")]
    public PostLingoV1DraftsResponseDtoDraft? Draft { get; set; }

    /// <summary>
    /// <para>草稿信息</para>
    /// </summary>
    public record PostLingoV1DraftsResponseDtoDraft
    {
        /// <summary>
        /// <para>草稿 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：42322</para>
        /// </summary>
        [JsonPropertyName("draft_id")]
        public string? DraftId { get; set; }

        /// <summary>
        /// <para>词条信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("entity")]
        public PostLingoV1DraftsResponseDtoDraftEntity? Entity { get; set; }

        /// <summary>
        /// <para>词条信息</para>
        /// </summary>
        public record PostLingoV1DraftsResponseDtoDraftEntity
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
                /// <para>名称展示范围</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("display_status")]
                public TermDisplayStatus DisplayStatus { get; set; } = new();

                /// <summary>
                /// <para>名称展示范围</para>
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
            /// <para>纯文本格式词条释义。注：description 和 rich_text 至少有一个，否则会报错：1540001</para>
            /// <para>必填：否</para>
            /// <para>示例值：词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通</para>
            /// <para>最大长度：5000</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }

            /// <summary>
            /// <para>词条创建时间</para>
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
            /// <para>相关数据</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("related_meta")]
            public PostLingoV1DraftsResponseDtoDraftEntityRelatedMeta? RelatedMeta { get; set; }

            /// <summary>
            /// <para>相关数据</para>
            /// </summary>
            public record PostLingoV1DraftsResponseDtoDraftEntityRelatedMeta
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
                    /// <para>示例值：7dab8a3d3cdcc9da365777c7ad535d62</para>
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
                /// <para>关联公开群组信息</para>
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
                /// <para>所属分类信息（不支持传入一级分类。词条不可同时属于同一个一级分类下的多个二级分类，一级分类下的二级分类互斥）</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("classifications")]
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
                    [JsonPropertyName("id")]
                    public string Id { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>父级分类的 ID</para>
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
                    /// <para>示例值：boxbcEcmKiD***vgqWTpvdc7jc</para>
                    /// </summary>
                    [JsonPropertyName("token")]
                    public string Token { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>统计数据</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("statistics")]
            public PostLingoV1DraftsResponseDtoDraftEntityStatistics? Statistics { get; set; }

            /// <summary>
            /// <para>统计数据</para>
            /// </summary>
            public record PostLingoV1DraftsResponseDtoDraftEntityStatistics
            {
                /// <summary>
                /// <para>点赞数量</para>
                /// <para>必填：是</para>
                /// <para>示例值：55</para>
                /// </summary>
                [JsonPropertyName("like_count")]
                public int LikeCount { get; set; }

                /// <summary>
                /// <para>点踩数量</para>
                /// <para>必填：是</para>
                /// <para>示例值：3</para>
                /// </summary>
                [JsonPropertyName("dislike_count")]
                public int DislikeCount { get; set; }
            }

            /// <summary>
            /// <para>外部 id 关联数据</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("outer_info")]
            public PostLingoV1DraftsResponseDtoDraftEntityOuterInfo? OuterInfo { get; set; }

            /// <summary>
            /// <para>外部 id 关联数据</para>
            /// </summary>
            public record PostLingoV1DraftsResponseDtoDraftEntityOuterInfo
            {
                /// <summary>
                /// <para>数据提供方（不能包含中横线 "-"）</para>
                /// <para>必填：是</para>
                /// <para>示例值：星云</para>
                /// <para>最大长度：32</para>
                /// </summary>
                [JsonPropertyName("provider")]
                public string Provider { get; set; } = string.Empty;

                /// <summary>
                /// <para>唯一标识，可用来和其他平台的内容进行绑定。需保证和百科词条唯一对应（不能包含中横线 "-"）</para>
                /// <para>必填：是</para>
                /// <para>示例值：12345abc</para>
                /// <para>最大长度：64</para>
                /// </summary>
                [JsonPropertyName("outer_id")]
                public string OuterId { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>富文本格式（当填写富文本内容时，description字段将会失效可不填写），支持的格式参考[企业百科指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/baike-v1/overview)中的释义部分</para>
            /// <para>必填：否</para>
            /// <para>示例值：加粗&lt;i&gt;斜体&lt;/i&gt;&lt;p&gt;&lt;ahref="https://feishu.cn"&gt;l链接&lt;/a&gt;&lt;/p&gt;&lt;p&gt;&lt;span&gt;企业百科是飞书提供的一款知识管理工具，通过企业百科可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通&lt;/span&gt;&lt;/p&gt;</para>
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
                /// </summary>
                [JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// <para>富文本描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：&lt;p&gt;&lt;span&gt;词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通&lt;/span&gt;&lt;/p&gt;</para>
                /// <para>最大长度：5000</para>
                /// </summary>
                [JsonPropertyName("rich_text")]
                public string? RichText { get; set; }
            }
        }
    }
}
