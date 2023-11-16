namespace FeishuNetSdk.Search.Spec;
/// <summary>
/// 修改数据范式 响应体
/// <para>修改数据范式。</para>
/// <para>接口ID：7100866111462211612</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/open-search/schema/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fschema%2fpatch</para>
/// </summary>
public record PatchSearchV2SchemasBySchemaIdResponseDto
{
    /// <summary>
    /// <para>数据范式实例</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("schema")]
    public SchemaSuffix? Schema { get; set; }

    /// <summary></summary>
    public record SchemaSuffix
    {
        /// <summary>
        /// <para>数据范式的属性定义</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("properties")]
        public SchemaProperty[]? Properties { get; set; }

        /// <summary></summary>
        public record SchemaProperty
        {
            /// <summary>
            /// <para>属性名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>属性类型</para>
            /// <para>**可选值有**：</para>
            /// <para>text:长文本类型,int:64位整数类型,tag:标签类型,timestamp:Unix 时间戳类型（单位为秒）,double:浮点数类型（小数）,tinytext:短文本类型，（utf8 编码）长度小于 140 的文本。在设置 search_options 时，与 text 类型有区别，支持更多召回策略</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>text：长文本类型</item>
            /// <item>int：64位整数类型</item>
            /// <item>tag：标签类型</item>
            /// <item>timestamp：Unix时间戳类型（单位为秒）</item>
            /// <item>double：浮点数类型（小数）</item>
            /// <item>tinytext：短文本类型，（utf8编码）长度小于140的文本。在设置search_options时，与text类型有区别，支持更多召回策略</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>该属性是否可用作搜索，默认为 false</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("is_searchable")]
            public bool? IsSearchable { get; set; }

            /// <summary>
            /// <para>该属性是否可用作搜索结果排序，默认为 false。如果为 true，需要再配置 sortOptions</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("is_sortable")]
            public bool? IsSortable { get; set; }

            /// <summary>
            /// <para>该属性是否可用作返回字段，为 false 时，该字段不会被召回和展示。默认为 false</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("is_returnable")]
            public bool? IsReturnable { get; set; }

            /// <summary>
            /// <para>属性排序的可选配置，当 is_sortable 为 true 时，该字段为必填字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("sort_options")]
            public SchemaSortOptions? SortOptions { get; set; }

            /// <summary></summary>
            public record SchemaSortOptions
            {
                /// <summary>
                /// <para>排序的优先级，可选范围为 0~4，0为最高优先级。如果优先级相同，则随机进行排序。默认为0</para>
                /// <para>**可选值有**：</para>
                /// <para>0:最高优先级,1:次高优先级,2:次次高优先级,3:次低优先级,4:最低优先级</para>
                /// <para>必填：否</para>
                /// <para>可选值：<list type="bullet">
                /// <item>0：最高优先级</item>
                /// <item>1：次高优先级</item>
                /// <item>2：次次高优先级</item>
                /// <item>3：次低优先级</item>
                /// <item>4：最低优先级</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("priority")]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>排序的顺序。默认为 desc</para>
                /// <para>**可选值有**：</para>
                /// <para>asc:升序,desc:降序</para>
                /// <para>必填：否</para>
                /// <para>可选值：<list type="bullet">
                /// <item>asc：升序</item>
                /// <item>desc：降序</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("order")]
                public string? Order { get; set; }
            }

            /// <summary>
            /// <para>相关类型数据的定义和约束</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("type_definitions")]
            public SchemaTypeDefinitions? TypeDefinitions { get; set; }

            /// <summary></summary>
            public record SchemaTypeDefinitions
            {
                /// <summary>
                /// <para>标签类型的定义</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("tag")]
                public SchemaTagOptions[]? Tag { get; set; }

                /// <summary></summary>
                public record SchemaTagOptions
                {
                    /// <summary>
                    /// <para>tag 对应的枚举值名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }

                    /// <summary>
                    /// <para>标签对应的颜色</para>
                    /// <para>**可选值有**：</para>
                    /// <para>red:含警示性、敏感性的提示信息,green:表示成功、完成、完毕的提示信息,blue:组件架构、职能等中性信息,grey:中立系统提示信息（慎重使用）,yellow:焦点信息、推广性信息</para>
                    /// <para>必填：否</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>red：含警示性、敏感性的提示信息</item>
                    /// <item>green：表示成功、完成、完毕的提示信息</item>
                    /// <item>blue：组件架构、职能等中性信息</item>
                    /// <item>grey：中立系统提示信息（慎重使用）</item>
                    /// <item>yellow：焦点信息、推广性信息</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("color")]
                    public string? Color { get; set; }

                    /// <summary>
                    /// <para>标签中展示的文本</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text")]
                    public string? Text { get; set; }
                }
            }

            /// <summary>
            /// <para>属性搜索的可选配置，当 is_searchable 为 true 时，该字段为必填参数</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("search_options")]
            public SchemaSearchOptions? SearchOptions { get; set; }

            /// <summary></summary>
            public record SchemaSearchOptions
            {
                /// <summary>
                /// <para>是否支持语义切词召回。默认不支持（推荐使用在长文本的场景）</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("enable_semantic_match")]
                public bool? EnableSemanticMatch { get; set; }

                /// <summary>
                /// <para>是否支持精确匹配。默认不支持（推荐使用在短文本、需要精确查找的场景）</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("enable_exact_match")]
                public bool? EnableExactMatch { get; set; }

                /// <summary>
                /// <para>是否支持前缀匹配（短文本的默认的分词/召回策略。前缀长度为 1-12）</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("enable_prefix_match")]
                public bool? EnablePrefixMatch { get; set; }

                /// <summary>
                /// <para>是否支持数据后缀匹配。默认不支持（推荐使用在短文本、有数字后缀查找的场景。后缀长度为3-12）</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("enable_number_suffix_match")]
                public bool? EnableNumberSuffixMatch { get; set; }

                /// <summary>
                /// <para>是否支持驼峰英文匹配。默认不支持（推荐使用在短文本，且包含驼峰形式英文的查找场景）</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("enable_camel_match")]
                public bool? EnableCamelMatch { get; set; }
            }
        }

        /// <summary>
        /// <para>数据展示相关配置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("display")]
        public SchemaDisplay? Display { get; set; }

        /// <summary></summary>
        public record SchemaDisplay
        {
            /// <summary>
            /// <para>搜索数据的展示卡片</para>
            /// <para>卡片详细信息请参考 [通用模块接入指南](/document/uAjLw4CM/ukTMukTMukTM/search-v2/common-template-intergration-handbook) "请求创建数据范式"部分</para>
            /// <para>**可选值有**：</para>
            /// <para>search_common_card:普通 common 卡片</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>search_common_card：普通common卡片</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("card_key")]
            public string? CardKey { get; set; }

            /// <summary>
            /// <para>数据字段名称和展示字段名称的映射关系。如果没有设置，则只会展示 与展示字段名称同名的 数据字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("fields_mapping")]
            public SchemaDisplayFieldMapping[]? FieldsMapping { get; set; }

            /// <summary></summary>
            public record SchemaDisplayFieldMapping
            {
                /// <summary>
                /// <para>展示字段名称，与 card_key 有关，每个模版能展示的字段不同。该字段不能重复</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("display_field")]
                public string? DisplayField { get; set; }

                /// <summary>
                /// <para>数据字段的名称。需要确保该字段对应在 schema 属性定义中的 is_returnable 为 true，否则无法展示。需要使用 ${xxx} 的规则来描述</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("data_field")]
                public string? DataField { get; set; }
            }
        }

        /// <summary>
        /// <para>用户自定义数据范式的唯一标识</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("schema_id")]
        public string? SchemaId { get; set; }
    }
}
