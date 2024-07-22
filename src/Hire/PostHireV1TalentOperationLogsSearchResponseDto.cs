// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1TalentOperationLogsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询操作人对人才的操作记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 查询操作人对人才的操作记录 响应体
/// <para>查询操作人对人才的操作记录。</para>
/// <para>接口ID：7098526921012936706</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2ftalent_operation_log%2fsearch</para>
/// </summary>
public record PostHireV1TalentOperationLogsSearchResponseDto
{
    /// <summary>
    /// <para>列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public TalentOperationLog[]? Items { get; set; }

    /// <summary>
    /// <para>列表</para>
    /// </summary>
    public record TalentOperationLog
    {
        /// <summary>
        /// <para>投递 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6949805467799537964</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>候选人 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6843547872837273223</para>
        /// </summary>
        [JsonPropertyName("talent_id")]
        public string? TalentId { get; set; }

        /// <summary>
        /// <para>操作人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("operator")]
        public IdNameObject? Operator { get; set; }

        /// <summary>
        /// <para>操作人</para>
        /// </summary>
        public record IdNameObject
        {
            /// <summary>
            /// <para>ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：1213213123123</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>名称</para>
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
        }

        /// <summary>
        /// <para>操作类型</para>
        /// <para>必填：否</para>
        /// <para>示例值："3001"</para>
        /// <para>可选值：<list type="bullet">
        /// <item>3001：加入职位</item>
        /// <item>1001：安排评估</item>
        /// <item>3004：转移阶段</item>
        /// <item>2001：安排面试</item>
        /// <item>3008：转移职位</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("operation_type")]
        public int? OperationType { get; set; }

        /// <summary>
        /// <para>操作时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618500278663</para>
        /// </summary>
        [JsonPropertyName("operation_time")]
        public string? OperationTime { get; set; }

        /// <summary>
        /// <para>操作人类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：员工</item>
        /// <item>2：招聘官网</item>
        /// <item>3：猎头</item>
        /// <item>4：候选人</item>
        /// <item>100：系统</item>
        /// <item>101：EHR</item>
        /// <item>102：薪酬系统</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("operator_type")]
        public int? OperatorType { get; set; }
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
