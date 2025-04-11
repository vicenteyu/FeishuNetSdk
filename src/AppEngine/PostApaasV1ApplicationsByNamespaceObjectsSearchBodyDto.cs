// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="PostApaasV1ApplicationsByNamespaceObjectsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 搜索记录 请求体
/// <para>在应用内搜索记录</para>
/// <para>接口ID：7384730094873051164</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object%2fsearch</para>
/// </summary>
public record PostApaasV1ApplicationsByNamespaceObjectsSearchBodyDto
{
    /// <summary>
    /// <para>搜索词</para>
    /// <para>必填：否</para>
    /// <para>示例值：搜索关键字</para>
    /// </summary>
    [JsonPropertyName("q")]
    public string? Q { get; set; }

    /// <summary>
    /// <para>搜索对象范围</para>
    /// <para>必填：否</para>
    /// <para>最大长度：256</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("search_objects")]
    public SearchObjectParam[]? SearchObjects { get; set; }

    /// <summary>
    /// <para>搜索对象范围</para>
    /// </summary>
    public record SearchObjectParam
    {
        /// <summary>
        /// <para>对象 APIName</para>
        /// <para>必填：否</para>
        /// <para>示例值：_user</para>
        /// <para>最大长度：256</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("api_name")]
        public string? ApiName { get; set; }

        /// <summary>
        /// <para>搜索字段 SearchFields 列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：500</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("search_fields")]
        public string[]? SearchFields { get; set; }

        /// <summary>
        /// <para>召回字段 APIID/APIName 列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("select")]
        public string[]? Select { get; set; }

        /// <summary>
        /// <para>过滤条件，序列化的结果{"filter": "「标准Criterion」"}</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("filter")]
        public Criterion? Filter { get; set; }

        /// <summary>
        /// <para>过滤条件，序列化的结果{"filter": "「标准Criterion」"}</para>
        /// </summary>
        public record Criterion
        {
            /// <summary>
            /// <para>查询条件</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("conditions")]
            public Condition[]? Conditions { get; set; }

            /// <summary>
            /// <para>查询条件</para>
            /// </summary>
            public record Condition
            {
                /// <summary>
                /// <para>序号</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("index")]
                public string? Index { get; set; }

                /// <summary>
                /// <para>左值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("left")]
                public ConditionValue? Left { get; set; }

                /// <summary>
                /// <para>左值</para>
                /// </summary>
                public record ConditionValue
                {
                    /// <summary>
                    /// <para>左值类型，只支持 "metadataVariable"，表示字段</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：metadataVariable</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public string? Type { get; set; }

                    /// <summary>
                    /// <para>字段具体值，以 JSONString 表示，格式：{"fieldPath":[{"fieldApiName": "字段名","objectApiName": "对象名"}]}</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：{\"fieldPath\":[{\"fieldApiName\": \"_id\",\"objectApiName\": \"_user\"}]}</para>
                    /// </summary>
                    [JsonPropertyName("settings")]
                    public string? Settings { get; set; }
                }

                /// <summary>
                /// <para>右值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("right")]
                public ConditionValue? Right { get; set; }

                /// <summary>
                /// <para>操作符</para>
                /// <para>必填：否</para>
                /// <para>示例值：equal</para>
                /// </summary>
                [JsonPropertyName("operator")]
                public string? Operator { get; set; }
            }

            /// <summary>
            /// <para>逻辑关系</para>
            /// <para>必填：否</para>
            /// <para>示例值：1 and 2</para>
            /// </summary>
            [JsonPropertyName("logic_expression")]
            public string? LogicExpression { get; set; }
        }

        /// <summary>
        /// <para>排序条件</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("order_by")]
        public OrderCondition? OrderBy { get; set; }

        /// <summary>
        /// <para>排序条件</para>
        /// </summary>
        public record OrderCondition
        {
            /// <summary>
            /// <para>字段名</para>
            /// <para>必填：否</para>
            /// <para>示例值：_id</para>
            /// <para>最大长度：256</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("field")]
            public string? Field { get; set; }

            /// <summary>
            /// <para>排序方式</para>
            /// <para>必填：否</para>
            /// <para>示例值：asc</para>
            /// <para>最大长度：256</para>
            /// <para>最小长度：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>asc：升序</item>
            /// <item>desc：降序</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("order_type")]
            public string? OrderType { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJvYmplY3RzX3BhZ2VfdG9rZW4iOlt7Im9ial9pZCI6MTc2OTI4NzM5M</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>返回数量，默认为50，最大不超过2000</para>
    /// <para>必填：否</para>
    /// <para>示例值：100</para>
    /// </summary>
    [JsonPropertyName("page_size")]
    public string? PageSize { get; set; }

    /// <summary>
    /// <para>返回元数据枚举值</para>
    /// <para>必填：否</para>
    /// <para>示例值：Label</para>
    /// <para>可选值：<list type="bullet">
    /// <item>Label：只返回 Label</item>
    /// <item>SearchLayout：返回搜索布局信息</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}
