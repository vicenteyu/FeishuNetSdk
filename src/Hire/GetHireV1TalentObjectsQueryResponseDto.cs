// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHireV1TalentObjectsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取人才字段 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取人才字段 响应体
/// <para>获取全部人才字段详细信息，包含字段名称、字段描述、字段类型、启用状态等信息。</para>
/// <para>## 概念说明</para>
/// <para>在「飞书招聘」-「设置」-「候选人字段管理」中，人才中的字段按照模块进行组织，一个模块下可以包含多个字段，对应人才字段类型中`模块`类型，如下图所示。</para>
/// <para>接口ID：6989078472837185539</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent_object%2fquery</para>
/// </summary>
public record GetHireV1TalentObjectsQueryResponseDto
{
    /// <summary>
    /// <para>模块列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CommonSchema[]? Items { get; set; }

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
            /// <para>模块中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：教育经历</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>模块英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Education</para>
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
            /// <para>字段类型</para>
            /// <para>**注意**：模块级别的字段类型只能取值 `11` 模块</para>
            /// <para>必填：否</para>
            /// <para>示例值：11</para>
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
                /// <para>选项信息，模块下该字段不会有值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("options")]
                public CommonSchemaOption[]? Options { get; set; }

                /// <summary>
                /// <para>选项信息，模块下该字段不会有值</para>
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
                        /// <para>选项中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：选项一</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>选项英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Option 1</para>
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
                    /// <para>选项是否启用</para>
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
        /// <para>- `true` 为自定义模块</para>
        /// <para>- `false` 为系统预置模块</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_customized")]
        public bool? IsCustomized { get; set; }

        /// <summary>
        /// <para>是否必填</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_required")]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// <para>模块是否启用</para>
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
                /// <para>字段中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：学历</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>字段英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Degree</para>
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
            /// <para>字段配置信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("setting")]
            public CommonSchemaSetting? Setting { get; set; }

            /// <summary>
            /// <para>字段配置信息</para>
            /// </summary>
            public record CommonSchemaSetting
            {
                /// <summary>
                /// <para>字段类型</para>
                /// <para>**注意**：字段级别的字段类型不能取值 `11` 模块</para>
                /// <para>必填：否</para>
                /// <para>示例值：3</para>
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
                    /// <para>选项信息，当字段类型为 `单选` 或 `多选` 时该字段有值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("options")]
                    public CommonSchemaOption[]? Options { get; set; }

                    /// <summary>
                    /// <para>选项信息，当字段类型为 `单选` 或 `多选` 时该字段有值</para>
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
                            /// <para>选项中文名称</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：选项一</para>
                            /// </summary>
                            [JsonPropertyName("zh_cn")]
                            public string? ZhCn { get; set; }

                            /// <summary>
                            /// <para>选项英文名称</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：Option 1</para>
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
                        /// <para>选项是否启用</para>
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
            /// <para>是否是自定义字段</para>
            /// <para>- `true` 为自定义字段</para>
            /// <para>- `false` 为系统预置字段</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_customized")]
            public bool? IsCustomized { get; set; }

            /// <summary>
            /// <para>是否必填</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_required")]
            public bool? IsRequired { get; set; }

            /// <summary>
            /// <para>字段是否启用</para>
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
