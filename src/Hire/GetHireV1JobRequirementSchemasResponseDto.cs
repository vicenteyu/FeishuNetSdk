using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取招聘需求模板 响应体
/// <para>获取招聘需求模板。</para>
/// <para>接口ID：6989078472837234691</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job_requirement/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_requirement_schema%2flist</para>
/// </summary>
public record GetHireV1JobRequirementSchemasResponseDto
{
    /// <summary>
    /// <para>列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public JobRequirementSchema[]? Items { get; set; }

    /// <summary>
    /// <para>列表</para>
    /// </summary>
    public record JobRequirementSchema
    {
        /// <summary>
        /// <para>模板 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6949805467799537964</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>国际化模板名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>国际化模板名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试</para>
            /// </summary>
            [JsonProperty("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：test</para>
            /// </summary>
            [JsonProperty("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>模板字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("object_list")]
        public CommonSchema[]? ObjectLists { get; set; }

        /// <summary>
        /// <para>模板字段</para>
        /// </summary>
        public record CommonSchema
        {
            /// <summary>
            /// <para>模块 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6949805467799537964</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>模块名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>模块名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonProperty("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
                /// </summary>
                [JsonProperty("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>模块描述</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("description")]
            public I18n? Description { get; set; }

            /// <summary>
            /// <para>模块信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("setting")]
            public CommonSchemaSetting? Setting { get; set; }

            /// <summary>
            /// <para>模块信息</para>
            /// </summary>
            public record CommonSchemaSetting
            {
                /// <summary>
                /// <para>字段类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：单行文本</item>
                /// <item>2：多行文本</item>
                /// <item>3：单选</item>
                /// <item>4：多选</item>
                /// <item>5：日期</item>
                /// <item>6：月份选择</item>
                /// <item>7：年份选择</item>
                /// <item>8：时间段</item>
                /// <item>9：数字</item>
                /// <item>10：默认字段</item>
                /// <item>11：模块</item>
                /// <item>13：附件</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("object_type")]
                public int? ObjectType { get; set; }

                /// <summary>
                /// <para>配置信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("config")]
                public CommonSchemaConfig? Config { get; set; }

                /// <summary>
                /// <para>配置信息</para>
                /// </summary>
                public record CommonSchemaConfig
                {
                    /// <summary>
                    /// <para>选项信息</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("options")]
                    public CommonSchemaOption[]? Options { get; set; }

                    /// <summary>
                    /// <para>选项信息</para>
                    /// </summary>
                    public record CommonSchemaOption
                    {
                        /// <summary>
                        /// <para>选项 ID</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：test</para>
                        /// </summary>
                        [JsonProperty("key")]
                        public string? Key { get; set; }

                        /// <summary>
                        /// <para>选项名称</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("name")]
                        public I18n? Name { get; set; }

                        /// <summary>
                        /// <para>选项名称</para>
                        /// </summary>
                        public record I18n
                        {
                            /// <summary>
                            /// <para>中文</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：测试</para>
                            /// </summary>
                            [JsonProperty("zh_cn")]
                            public string? ZhCn { get; set; }

                            /// <summary>
                            /// <para>英文</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：test</para>
                            /// </summary>
                            [JsonProperty("en_us")]
                            public string? EnUs { get; set; }
                        }

                        /// <summary>
                        /// <para>选项描述</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("description")]
                        public I18n? Description { get; set; }

                        /// <summary>
                        /// <para>是否启用</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：已启用</item>
                        /// <item>2：已停用</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("active_status")]
                        public int? ActiveStatus { get; set; }
                    }
                }
            }

            /// <summary>
            /// <para>是否是自定义模块</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("is_customized")]
            public bool? IsCustomized { get; set; }

            /// <summary>
            /// <para>是否必填</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonProperty("is_required")]
            public bool? IsRequired { get; set; }

            /// <summary>
            /// <para>是否启用</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：已启用</item>
            /// <item>2：已停用</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("active_status")]
            public int? ActiveStatus { get; set; }

            /// <summary>
            /// <para>字段列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("children_list")]
            public CommonSchemaChild[]? ChildrenLists { get; set; }

            /// <summary>
            /// <para>字段列表</para>
            /// </summary>
            public record CommonSchemaChild
            {
                /// <summary>
                /// <para>字段 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6949805467799537964</para>
                /// </summary>
                [JsonProperty("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>字段名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>字段名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>中文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：测试</para>
                    /// </summary>
                    [JsonProperty("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>英文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：test</para>
                    /// </summary>
                    [JsonProperty("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>字段描述</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("description")]
                public I18n? Description { get; set; }

                /// <summary>
                /// <para>字段信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("setting")]
                public CommonSchemaSetting? Setting { get; set; }

                /// <summary>
                /// <para>字段信息</para>
                /// </summary>
                public record CommonSchemaSetting
                {
                    /// <summary>
                    /// <para>字段类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：单行文本</item>
                    /// <item>2：多行文本</item>
                    /// <item>3：单选</item>
                    /// <item>4：多选</item>
                    /// <item>5：日期</item>
                    /// <item>6：月份选择</item>
                    /// <item>7：年份选择</item>
                    /// <item>8：时间段</item>
                    /// <item>9：数字</item>
                    /// <item>10：默认字段</item>
                    /// <item>11：模块</item>
                    /// <item>13：附件</item>
                    /// </list></para>
                    /// </summary>
                    [JsonProperty("object_type")]
                    public int? ObjectType { get; set; }

                    /// <summary>
                    /// <para>配置信息</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("config")]
                    public CommonSchemaConfig? Config { get; set; }

                    /// <summary>
                    /// <para>配置信息</para>
                    /// </summary>
                    public record CommonSchemaConfig
                    {
                        /// <summary>
                        /// <para>选项信息</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("options")]
                        public CommonSchemaOption[]? Options { get; set; }

                        /// <summary>
                        /// <para>选项信息</para>
                        /// </summary>
                        public record CommonSchemaOption
                        {
                            /// <summary>
                            /// <para>选项 ID</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：test</para>
                            /// </summary>
                            [JsonProperty("key")]
                            public string? Key { get; set; }

                            /// <summary>
                            /// <para>选项名称</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonProperty("name")]
                            public I18n? Name { get; set; }

                            /// <summary>
                            /// <para>选项名称</para>
                            /// </summary>
                            public record I18n
                            {
                                /// <summary>
                                /// <para>中文</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：测试</para>
                                /// </summary>
                                [JsonProperty("zh_cn")]
                                public string? ZhCn { get; set; }

                                /// <summary>
                                /// <para>英文</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：test</para>
                                /// </summary>
                                [JsonProperty("en_us")]
                                public string? EnUs { get; set; }
                            }

                            /// <summary>
                            /// <para>选项描述</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonProperty("description")]
                            public I18n? Description { get; set; }

                            /// <summary>
                            /// <para>是否启用</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：已启用</item>
                            /// <item>2：已停用</item>
                            /// </list></para>
                            /// </summary>
                            [JsonProperty("active_status")]
                            public int? ActiveStatus { get; set; }
                        }
                    }
                }

                /// <summary>
                /// <para>所属模块 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6949805467799537964</para>
                /// </summary>
                [JsonProperty("parent_id")]
                public string? ParentId { get; set; }

                /// <summary>
                /// <para>是否是自定义字段</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonProperty("is_customized")]
                public bool? IsCustomized { get; set; }

                /// <summary>
                /// <para>是否必填</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonProperty("is_required")]
                public bool? IsRequired { get; set; }

                /// <summary>
                /// <para>是否启用</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：已启用</item>
                /// <item>2：已停用</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("active_status")]
                public int? ActiveStatus { get; set; }
            }
        }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1234452132</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }
}
