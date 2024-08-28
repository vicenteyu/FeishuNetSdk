// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="GetHireV1InterviewRegistrationSchemasResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取面试登记表列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取面试登记表列表 响应体
/// <para>获取面试登记表列表，可获取到的信息包括登记表名称、登记表模块、登记表字段</para>
/// <para>接口ID：7063273947417247745</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/interview-settings/list-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterview_registration_schema%2flist</para>
/// </summary>
public record GetHireV1InterviewRegistrationSchemasResponseDto
{
    /// <summary>
    /// <para>面试登记表列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public InterviewRegistrationSchema[]? Items { get; set; }

    /// <summary>
    /// <para>面试登记表列表</para>
    /// </summary>
    public record InterviewRegistrationSchema
    {
        /// <summary>
        /// <para>面试登记表 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7044739584859326764</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>面试登记表名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：默认面试登记表</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>是否用作全局面试登记表：</para>
        /// <para>- `true`：全局面试登记表，全部职位都应用该登记表</para>
        /// <para>- `false`：非全局面试登记表，可按职位选择该登记表</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_used_as_interview")]
        public bool? IsUsedAsInterview { get; set; }

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
                /// <para>示例值：登记表模块</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：interview module</para>
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
                /// <para>字段类型，在模块信息中该字段将固定返回`11`</para>
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
                /// <para>配置信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("config")]
                public CommonSchemaConfig? Config { get; set; }

                /// <summary>
                /// <para>配置信息</para>
                /// </summary>
                public record CommonSchemaConfig
                {
                    /// <summary>
                    /// <para>选项信息，仅在类型object_type为单选、多选时有值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("options")]
                    public CommonSchemaOption[]? Options { get; set; }

                    /// <summary>
                    /// <para>选项信息，仅在类型object_type为单选、多选时有值</para>
                    /// </summary>
                    public record CommonSchemaOption
                    {
                        /// <summary>
                        /// <para>选项 ID</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：test</para>
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
                            /// <para>示例值：模块选项</para>
                            /// </summary>
                            [JsonPropertyName("zh_cn")]
                            public string? ZhCn { get; set; }

                            /// <summary>
                            /// <para>英文名称</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：module option</para>
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
            /// <para>是否是自定义模块：</para>
            /// <para>- `true`：自定义模块</para>
            /// <para>- `false`：系统预置模块</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_customized")]
            public bool? IsCustomized { get; set; }

            /// <summary>
            /// <para>是否必填：</para>
            /// <para>- `true`：必填</para>
            /// <para>- `false`：非必填</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_required")]
            public bool? IsRequired { get; set; }

            /// <summary>
            /// <para>是否可见：</para>
            /// <para>- `true`：可见</para>
            /// <para>- `false`：不可见</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_visible")]
            public bool? IsVisible { get; set; }

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
                    /// <para>示例值：登记表字段</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：interview registration field</para>
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
                    [JsonPropertyName("object_type")]
                    public int? ObjectType { get; set; }

                    /// <summary>
                    /// <para>配置信息</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("config")]
                    public CommonSchemaConfig? Config { get; set; }

                    /// <summary>
                    /// <para>配置信息</para>
                    /// </summary>
                    public record CommonSchemaConfig
                    {
                        /// <summary>
                        /// <para>选项信息，仅在字段类型object_type为单选、多选时有值</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("options")]
                        public CommonSchemaOption[]? Options { get; set; }

                        /// <summary>
                        /// <para>选项信息，仅在字段类型object_type为单选、多选时有值</para>
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
                                /// <para>示例值：option A</para>
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
                /// <para>所属模块 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6949805467799537964</para>
                /// </summary>
                [JsonPropertyName("parent_id")]
                public string? ParentId { get; set; }

                /// <summary>
                /// <para>是否是自定义字段：</para>
                /// <para>- `true`：自定义字段</para>
                /// <para>- `false`：系统预置字段</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_customized")]
                public bool? IsCustomized { get; set; }

                /// <summary>
                /// <para>是否必填：</para>
                /// <para>- `true`：必填</para>
                /// <para>- `false`：非必填</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("is_required")]
                public bool? IsRequired { get; set; }

                /// <summary>
                /// <para>是否可见：</para>
                /// <para>- `true`：可见</para>
                /// <para>- `false`：不可见</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_visible")]
                public bool? IsVisible { get; set; }

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
    /// <para>示例值：eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ==</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
