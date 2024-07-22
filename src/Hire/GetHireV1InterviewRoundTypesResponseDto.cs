// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="GetHireV1InterviewRoundTypesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取面试轮次类型列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取面试轮次类型列表 响应体
/// <para>根据职位流程查询面试轮次类型列表，可以查询到的信息包括：面试轮次类型名称、启用状态、关联的面试评价表信息。可应用于更新职位设置场景：[更新职位设置](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job/update_config)</para>
/// <para>接口ID：7098333210140082177</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/interview-settings/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterview_round_type%2flist</para>
/// </summary>
public record GetHireV1InterviewRoundTypesResponseDto
{
    /// <summary>
    /// <para>面试轮次类型启用状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：已启用</item>
    /// <item>2：未启用</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("active_status")]
    public int? ActiveStatus { get; set; }

    /// <summary>
    /// <para>列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public InterviewRoundType[]? Items { get; set; }

    /// <summary>
    /// <para>列表</para>
    /// </summary>
    public record InterviewRoundType
    {
        /// <summary>
        /// <para>面试轮次类型 ID。在面试轮次类型更新时，类型 ID 也会更新</para>
        /// <para>必填：否</para>
        /// <para>示例值：7012129842917869868</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>面试轮次类型对应的业务 ID。在面试轮次类型更新时，业务 ID 保持不变</para>
        /// <para>必填：否</para>
        /// <para>示例值：7012129842917869868</para>
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string? BizId { get; set; }

        /// <summary>
        /// <para>面试轮次类型名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>面试轮次类型名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>面试轮次类型中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：默认面试轮次类型</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>面试轮次类型英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：default interview round type</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>职位流程类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：社招流程</item>
        /// <item>2：校招流程</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("process_type")]
        public int? ProcessType { get; set; }

        /// <summary>
        /// <para>启用状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：启用</item>
        /// <item>2：未启用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("active_status")]
        public int? ActiveStatus { get; set; }

        /// <summary>
        /// <para>面试评价表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("interview_assessment_template_info")]
        public InterviewRoundTypeAssessmentTemplate? InterviewAssessmentTemplateInfo { get; set; }

        /// <summary>
        /// <para>面试评价表</para>
        /// </summary>
        public record InterviewRoundTypeAssessmentTemplate
        {
            /// <summary>
            /// <para>面试评价表 ID。在面试评价表更新时，评价表 ID 也会更新</para>
            /// <para>必填：否</para>
            /// <para>示例值：7012129842917869868</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>面试评价表对应的业务 ID。在面试评价表更新时，业务 ID 保持不变</para>
            /// <para>必填：否</para>
            /// <para>示例值：7012129842917869868</para>
            /// </summary>
            [JsonPropertyName("biz_id")]
            public string? BizId { get; set; }

            /// <summary>
            /// <para>面试评价表名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>面试评价表名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>面试评价表中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：默认面试评价表</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>面试评价表英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：default interview assessment template</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }
    }
}
