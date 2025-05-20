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
// <summary>查询人才操作记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 查询人才操作记录 响应体
/// <para>根据操作人和操作类型查询人才的操作记录。</para>
/// <para>接口ID：7098526921012936706</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2ftalent_operation_log%2fsearch</para>
/// </summary>
public record PostHireV1TalentOperationLogsSearchResponseDto : IPageableResponse<PostHireV1TalentOperationLogsSearchResponseDto.TalentOperationLog>
{
    /// <summary>
    /// <para>操作记录列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public TalentOperationLog[]? Items { get; set; }

    /// <summary>
    /// <para>操作记录列表</para>
    /// </summary>
    public record TalentOperationLog
    {
        /// <summary>
        /// <para>投递 ID，详情可查看：[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6949805467799537964</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>人才 ID，详情可参考：[获取人才信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/hire-v2/talent/get)</para>
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
            /// <para>操作人 ID，与入参 `user_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_016632190e242d8c9eed0a542b00756c</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>操作人姓名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>操作人姓名</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>操作人中文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>操作人英文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：Tom</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>操作类型，操作类型枚举可查看[枚举常量介绍](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/enum)</para>
        /// <para>中 `操作类型枚举定义`</para>
        /// <para>必填：否</para>
        /// <para>示例值："3001"</para>
        /// </summary>
        [JsonPropertyName("operation_type")]
        public int? OperationType { get; set; }

        /// <summary>
        /// <para>操作时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618500278663</para>
        /// </summary>
        [JsonPropertyName("operation_time")]
        public string? OperationTime { get; set; }

        /// <summary>
        /// <para>操作人类型</para>
        /// <para>**注意**：当前只会返回类型为 `1`：员工 的操作记录</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：员工</item>
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
