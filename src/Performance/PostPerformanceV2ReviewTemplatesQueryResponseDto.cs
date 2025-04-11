// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2ReviewTemplatesQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取评估模板配置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取评估模板配置 响应体
/// <para>获取评估模板配置信息，包括模版名称、执行角色、填写项类型等</para>
/// <para>接口ID：7351374599659782148</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/review_template/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2freview_template%2fquery</para>
/// </summary>
public record PostPerformanceV2ReviewTemplatesQueryResponseDto
{
    /// <summary>
    /// <para>评估模板信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("review_templates")]
    public ReviewTemplate[]? ReviewTemplates { get; set; }

    /// <summary>
    /// <para>评估模板信息</para>
    /// </summary>
    public record ReviewTemplate
    {
        /// <summary>
        /// <para>环节模板列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：999999999</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("templates")]
        public Template[]? Templates { get; set; }

        /// <summary>
        /// <para>环节模板列表</para>
        /// </summary>
        public record Template
        {
            /// <summary>
            /// <para>环节模板 ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：7343513161666707459</para>
            /// <para>最大长度：999999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("template_id")]
            public string TemplateId { get; set; } = string.Empty;

            /// <summary>
            /// <para>环节模板对应的环节名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>环节模板对应的环节名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：体验</para>
                /// <para>最大长度：999999999</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：Interactive experience</para>
                /// <para>最大长度：999999999</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>环节类型</para>
            /// <para>枚举值：</para>
            /// <para>- `summarize_key_outputs`: 工作总结环节</para>
            /// <para>- `review`: 评估型环节</para>
            /// <para>- `communication_and_open_result`: 结果沟通环节</para>
            /// <para>- `view_result`: 绩效结果查看环节</para>
            /// <para>- `calibration`: 校准环节</para>
            /// <para>- `reconsideration`: 结果复议环节</para>
            /// <para>必填：否</para>
            /// <para>示例值：leader_review</para>
            /// <para>最大长度：999999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("stage_type")]
            public string? StageType { get; set; }

            /// <summary>
            /// <para>评估型环节的执行人角色</para>
            /// <para>枚举值：</para>
            /// <para>- `reviewee`: 被评估人</para>
            /// <para>- `invited_reviewer`: 360°评估人</para>
            /// <para>- `solid_line_leader`: 实线上级</para>
            /// <para>- `dotted_line_leader`: 虚线上级</para>
            /// <para>- `secondary_solid_line_leader`: 第二实线上级</para>
            /// <para>- `direct_project_leader`: 项目直属上级</para>
            /// <para>- `custom_review_role`:自定义评估角色</para>
            /// <para>必填：否</para>
            /// <para>示例值：reviewee</para>
            /// <para>最大长度：999999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("review_stage_role")]
            public string? ReviewStageRole { get; set; }
        }

        /// <summary>
        /// <para>评估内容列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：999999999</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("units")]
        public Unit[]? Units { get; set; }

        /// <summary>
        /// <para>评估内容列表</para>
        /// </summary>
        public record Unit
        {
            /// <summary>
            /// <para>评估内容 ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：7343513161666723843</para>
            /// <para>最大长度：999999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("unit_id")]
            public string UnitId { get; set; } = string.Empty;

            /// <summary>
            /// <para>评估内容名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>评估内容名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：体验</para>
                /// <para>最大长度：999999999</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：Interactive experience</para>
                /// <para>最大长度：999999999</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>评估题列表，指评估内容中的每个题，可能是评估项或者填写项</para>
            /// <para>必填：否</para>
            /// <para>最大长度：999999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("fields")]
            public Field[]? Fields { get; set; }

            /// <summary>
            /// <para>评估题列表，指评估内容中的每个题，可能是评估项或者填写项</para>
            /// </summary>
            public record Field
            {
                /// <summary>
                /// <para>评估题 ID</para>
                /// <para>必填：是</para>
                /// <para>示例值：7343513161666707459</para>
                /// <para>最大长度：999999999</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("field_id")]
                public string FieldId { get; set; } = string.Empty;

                /// <summary>
                /// <para>如果是填写项，为填写项名称，字段可能为空值；如果是评估项，为评估项名称，字段不为空值；如果是标签填写题，为标签填写题名称，字段不为空值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>如果是填写项，为填写项名称，字段可能为空值；如果是评估项，为评估项名称，字段不为空值；如果是标签填写题，为标签填写题名称，字段不为空值</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>中文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：体验</para>
                    /// <para>最大长度：999999999</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>英文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Interactive experience</para>
                    /// <para>最大长度：999999999</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>评估项 ID，详细信息请参考[获取评估项配置](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/indicator/query)</para>
                /// <para>必填：否</para>
                /// <para>示例值：7343513161666707459</para>
                /// <para>最大长度：999999999</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("indicator_id")]
                public string? IndicatorId { get; set; }

                /// <summary>
                /// <para>标签填写题 ID，详细信息请参考[获取标签填写题配置](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/question/query)</para>
                /// <para>必填：否</para>
                /// <para>示例值：7343513161666707459</para>
                /// <para>最大长度：20</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("tag_based_question_id")]
                public string? TagBasedQuestionId { get; set; }

                /// <summary>
                /// <para>O 的填写项标题</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("objective_text_qustion_title")]
                public I18n? ObjectiveTextQustionTitle { get; set; }

                /// <summary>
                /// <para>KR 的填写项标题</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("keyresult_text_qustion_title")]
                public I18n? KeyresultTextQustionTitle { get; set; }

                /// <summary>
                /// <para>关联的父级评估项 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：7343513161666707459</para>
                /// <para>最大长度：999999999</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("parent_field_id")]
                public string? ParentFieldId { get; set; }
            }
        }

        /// <summary>
        /// <para>评估模板 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7343513161666723843</para>
        /// <para>最大长度：999999999</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("review_template_id")]
        public string? ReviewTemplateId { get; set; }

        /// <summary>
        /// <para>评估模板名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>评估模板名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：体验</para>
            /// <para>最大长度：999999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：Interactive experience</para>
            /// <para>最大长度：999999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>评估模板描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public I18n? Description { get; set; }

        /// <summary>
        /// <para>状态</para>
        /// <para>枚举值：</para>
        /// <para>- `to_be_configured`: 待完成配置</para>
        /// <para>- `to_be_enabled`: 待启用</para>
        /// <para>- `enabled`: 已启用</para>
        /// <para>- `disabled`: 已停用</para>
        /// <para>- `deleted`: 已删除但曾经被项目引用过</para>
        /// <para>必填：否</para>
        /// <para>示例值：enabled</para>
        /// <para>最大长度：999999999</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }
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
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
