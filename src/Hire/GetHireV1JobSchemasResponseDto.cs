// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="GetHireV1JobSchemasResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取职位模板 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取职位模板 响应体
/// <para>获取社招、校招职位模板中的职位字段，返回结果包括系统默认字段和自定义字段。招聘管理员可在「飞书招聘」-「设置」-「职位管理」-「职位字段管理」中修改职位模板。</para>
/// <para>接口ID：6989078472837251075</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_schema%2flist</para>
/// </summary>
public record GetHireV1JobSchemasResponseDto
{
    /// <summary>
    /// <para>职位模板列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public JobSchema[]? Items { get; set; }

    /// <summary>
    /// <para>职位模板列表</para>
    /// </summary>
    public record JobSchema
    {
        /// <summary>
        /// <para>职位模板 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6949805467799537964</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>职位模板名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>职位模板名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：社招模板</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Social Job Template</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>职位模板类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：社招</item>
        /// <item>2：校招</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("scenario_type")]
        public int? ScenarioType { get; set; }

        /// <summary>
        /// <para>模块列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("object_list")]
        public CommonSchema[]? ObjectLists { get; set; }

        /// <summary>
        /// <para>模块列表</para>
        /// </summary>
        public record CommonSchema
        {
            /// <summary>
            /// <para>模块 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6949805467799537964</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>模块名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>模块名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：基础信息</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Basic info</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>模块描述</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("description")]
            public I18n? Description { get; set; }

            /// <summary>
            /// <para>模块信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("setting")]
            public CommonSchemaSetting? Setting { get; set; }

            /// <summary>
            /// <para>模块信息</para>
            /// </summary>
            public record CommonSchemaSetting
            {
                /// <summary>
                /// <para>类型，目前仅支持`11`</para>
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
                [JsonPropertyName("object_type")]
                public int? ObjectType { get; set; }

                /// <summary>
                /// <para>模块配置信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("config")]
                public CommonSchemaConfig? Config { get; set; }

                /// <summary>
                /// <para>模块配置信息</para>
                /// </summary>
                public record CommonSchemaConfig
                {
                    /// <summary>
                    /// <para>选项信息</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("options")]
                    public CommonSchemaOption[]? Options { get; set; }

                    /// <summary>
                    /// <para>选项信息</para>
                    /// </summary>
                    public record CommonSchemaOption
                    {
                        /// <summary>
                        /// <para>选项 ID</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// </summary>
                        [JsonPropertyName("key")]
                        public string? Key { get; set; }

                        /// <summary>
                        /// <para>选项名称</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("name")]
                        public I18n? Name { get; set; }

                        /// <summary>
                        /// <para>选项名称</para>
                        /// </summary>
                        public record I18n
                        {
                            /// <summary>
                            /// <para>中文名称</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：选项A</para>
                            /// </summary>
                            [JsonPropertyName("zh_cn")]
                            public string? ZhCn { get; set; }

                            /// <summary>
                            /// <para>英文名称</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：Option A</para>
                            /// </summary>
                            [JsonPropertyName("en_us")]
                            public string? EnUs { get; set; }
                        }

                        /// <summary>
                        /// <para>选项描述</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("description")]
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
                        [JsonPropertyName("active_status")]
                        public int? ActiveStatus { get; set; }
                    }
                }
            }

            /// <summary>
            /// <para>是否是自定义模块</para>
            /// <para>**可选值有**：</para>
            /// <para>* `true`：自定义模块</para>
            /// <para>* `false`：系统默认模块</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_customized")]
            public bool? IsCustomized { get; set; }

            /// <summary>
            /// <para>是否必填</para>
            /// <para>**可选值有**：</para>
            /// <para>* `true`：必填</para>
            /// <para>* `false`：非必填</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_required")]
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
            [JsonPropertyName("active_status")]
            public int? ActiveStatus { get; set; }

            /// <summary>
            /// <para>字段列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("children_list")]
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
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>字段名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>字段名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：职位类型</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Job type</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>字段描述</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("description")]
                public I18n? Description { get; set; }

                /// <summary>
                /// <para>字段信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("setting")]
                public CommonSchemaSetting? Setting { get; set; }

                /// <summary>
                /// <para>字段信息</para>
                /// </summary>
                public record CommonSchemaSetting
                {
                    /// <summary>
                    /// <para>字段类型，目前仅支持`1`/`2`/`3`/`4`/`5`/`9`/`10`</para>
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
                    [JsonPropertyName("object_type")]
                    public int? ObjectType { get; set; }

                    /// <summary>
                    /// <para>字段配置信息</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("config")]
                    public CommonSchemaConfig? Config { get; set; }

                    /// <summary>
                    /// <para>字段配置信息</para>
                    /// </summary>
                    public record CommonSchemaConfig
                    {
                        /// <summary>
                        /// <para>选项信息，当`object_type `为`3`（单选）或`4`（多选）时有值</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("options")]
                        public CommonSchemaOption[]? Options { get; set; }

                        /// <summary>
                        /// <para>选项信息，当`object_type `为`3`（单选）或`4`（多选）时有值</para>
                        /// </summary>
                        public record CommonSchemaOption
                        {
                            /// <summary>
                            /// <para>选项 ID</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：111</para>
                            /// </summary>
                            [JsonPropertyName("key")]
                            public string? Key { get; set; }

                            /// <summary>
                            /// <para>选项名称</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("name")]
                            public I18n? Name { get; set; }

                            /// <summary>
                            /// <para>选项名称</para>
                            /// </summary>
                            public record I18n
                            {
                                /// <summary>
                                /// <para>中文名称</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：类型A</para>
                                /// </summary>
                                [JsonPropertyName("zh_cn")]
                                public string? ZhCn { get; set; }

                                /// <summary>
                                /// <para>英文名称</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：Type A</para>
                                /// </summary>
                                [JsonPropertyName("en_us")]
                                public string? EnUs { get; set; }
                            }

                            /// <summary>
                            /// <para>选项描述</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("description")]
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
                            [JsonPropertyName("active_status")]
                            public int? ActiveStatus { get; set; }
                        }
                    }
                }

                /// <summary>
                /// <para>所属模块 ID，对应外层`object_list.id`字段</para>
                /// <para>必填：否</para>
                /// <para>示例值：6949805467799537964</para>
                /// </summary>
                [JsonPropertyName("parent_id")]
                public string? ParentId { get; set; }

                /// <summary>
                /// <para>是否是自定义字段</para>
                /// <para>**可选值有**：</para>
                /// <para>* `true`：自定义字段</para>
                /// <para>* `false`：系统默认字段</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_customized")]
                public bool? IsCustomized { get; set; }

                /// <summary>
                /// <para>是否必填</para>
                /// <para>**可选值有**：</para>
                /// <para>* `true`：必填</para>
                /// <para>* `false`：非必填</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("is_required")]
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
                [JsonPropertyName("active_status")]
                public int? ActiveStatus { get; set; }
            }
        }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1234452132</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
