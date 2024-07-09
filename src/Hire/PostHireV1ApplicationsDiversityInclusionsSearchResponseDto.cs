// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-09
//
// Last Modified By : yxr
// Last Modified On : 2024-07-09
// ************************************************************************
// <copyright file="PostHireV1ApplicationsDiversityInclusionsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取申请表附加信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取申请表附加信息 响应体
/// <para>获取候选人的申请表附加信息。支持通过投递 ID 或者人才 ID 进行查询。</para>
/// <para>接口ID：7232192298414292993</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fdiversity_inclusion%2fsearch</para>
/// </summary>
public record PostHireV1ApplicationsDiversityInclusionsSearchResponseDto
{
    /// <summary>
    /// <para>申请表附加信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public DiInfo[]? Items { get; set; }

    /// <summary>
    /// <para>申请表附加信息列表</para>
    /// </summary>
    public record DiInfo
    {
        /// <summary>
        /// <para>附加信息 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6784008015948283904</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>投递ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6784008015948283905</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>人才ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6784008015948283906</para>
        /// </summary>
        [JsonPropertyName("talent_id")]
        public string? TalentId { get; set; }

        /// <summary>
        /// <para>数据来源</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：官网</item>
        /// <item>2：详情页</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("source_type")]
        public int? SourceType { get; set; }

        /// <summary>
        /// <para>创建时间毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1681301987</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>更新时间毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1681301987</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>附加信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("di_data")]
        public DiData[]? DiDatas { get; set; }

        /// <summary>
        /// <para>附加信息</para>
        /// </summary>
        public record DiData
        {
            /// <summary>
            /// <para>字段值</para>
            /// <para>**不同类型数据格式如下**：</para>
            /// <para>- 单选："1"</para>
            /// <para>- 多选："["1", "2"]"</para>
            /// <para>- 月份选择："{"date":"2022-01"}"</para>
            /// <para>- 年份选择："{"date":"2022"}"</para>
            /// <para>- 数字："123"</para>
            /// <para>- 单行文本："今天天气不错"</para>
            /// <para>- 多行文本："该候选人优势如下： 思维敏捷，逻辑清晰，对业务有自己见解"</para>
            /// <para>- 日期范围："[1688140800000,1688140800000]"</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }

            /// <summary>
            /// <para>字段属性</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("object_attribute")]
            public DiDataObjectAttribute? ObjectAttribute { get; set; }

            /// <summary>
            /// <para>字段属性</para>
            /// </summary>
            public record DiDataObjectAttribute
            {
                /// <summary>
                /// <para>字段名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("title")]
                public I18n? Title { get; set; }

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
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>英文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：test</para>
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
                /// <para>字段类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：单选</item>
                /// <item>2：多选</item>
                /// <item>3：月份选择</item>
                /// <item>4：年份选择</item>
                /// <item>5：数字</item>
                /// <item>6：文本</item>
                /// <item>7：多行文本</item>
                /// <item>8：日期范围</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("data_type")]
                public int? DataType { get; set; }

                /// <summary>
                /// <para>字段标签</para>
                /// <para>**可选值有**：</para>
                /// <para>- 1: 性别</para>
                /// <para>- 2: 种族</para>
                /// <para>- 3: 身体情况</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("tags")]
                public int[]? Tags { get; set; }

                /// <summary>
                /// <para>是否为 FCF 数据</para>
                /// <para>**FCF**：公平考虑框架( [Fair Consideration Framework](https://www.mom.gov.sg/employment-practices/fair-consideration-framework)，简称 FCF)，该框架规定了所有新加坡的雇主必须平等的考虑新加坡劳动力的就业机会。</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_fcf_data")]
                public bool? IsFcfData { get; set; }

                /// <summary>
                /// <para>是否为 D&amp;I 数据</para>
                /// <para>**D&amp;I**：多元化与包容性（Diversity and Inclusion，简称D&amp;I），指的是在组织或社会中，尊重和重视不同种类的个体，包括种族、性别、年龄、性取向、宗教、文化背景等。多元化强调个体差异，而包容性则是在此基础上创建一个尊重、重视并充分利用这些差异的环境。</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_di_data")]
                public bool? IsDiData { get; set; }
            }
        }
    }
}
