// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询记录列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 查询记录列表 请求体
/// <para>获取对象中符合指定条件的记录列表</para>
/// <para>接口ID：7384730094873067548</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/application-object-record/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fbatch_query</para>
/// </summary>
public record PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchQueryBodyDto
{
    /// <summary>
    /// <para>需要获取的字段，使用字段唯一标识符进行查询，关联字段可使用「.」进行下钻</para>
    /// <para>必填：是</para>
    /// <para>最大长度：256</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("select")]
    public string[] Select { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>筛选条件，通过 JSON 格式指定条件</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("filter")]
    public Criterion? Filter { get; set; }

    /// <summary>
    /// <para>筛选条件，通过 JSON 格式指定条件</para>
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
    /// <para>排序参数，通过 JSON 格式指定条件。其中， field 为参与排序字段，direction 为排序方向，多个条件按其在数组中的顺序生效。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：256</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("order_by")]
    public Sort[]? Orderies { get; set; }

    /// <summary>
    /// <para>排序参数，通过 JSON 格式指定条件。其中， field 为参与排序字段，direction 为排序方向，多个条件按其在数组中的顺序生效。</para>
    /// </summary>
    public record Sort
    {
        /// <summary>
        /// <para>字段唯一标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：_id</para>
        /// <para>最大长度：256</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("field")]
        public string Field { get; set; } = string.Empty;

        /// <summary>
        /// <para>排序方向，值为 "ASC" 或者 "DESC"，代表升序和降序</para>
        /// <para>必填：是</para>
        /// <para>示例值：ASC</para>
        /// <para>最大长度：256</para>
        /// <para>最小长度：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>ASC：升序</item>
        /// <item>DESC：降序</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>聚合参数，通过 JSON 格式指定条件。其中， field 为参与聚合的字段。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：256</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("group_by")]
    public RecordGroupByItem[]? Groupies { get; set; }

    /// <summary>
    /// <para>聚合参数，通过 JSON 格式指定条件。其中， field 为参与聚合的字段。</para>
    /// </summary>
    public record RecordGroupByItem
    {
        /// <summary>
        /// <para>字段唯一标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：_id</para>
        /// <para>最大长度：256</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("field")]
        public string Field { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否使用 page_token 功能。为 True 时将使用 page_token 的值作为起始位置查询记录，并且会在 Response 中返回 next_page_token 。默认为 False 。</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("use_page_token")]
    public bool? UsePageToken { get; set; }

    /// <summary>
    /// <para>期望服务端返回的记录条数，上限 500 条。不填则取默认值，默认值为 500。</para>
    /// <para>必填：否</para>
    /// <para>示例值：100</para>
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    /// <summary>
    /// <para>返回记录的偏移量，默认为 0 ，即从查询到的第一条记录开始返回。offset 较大时查询性能较差，可能引起接口响应超时，拉取全部记录时建议使用 ID 游标分页，具体见 ID 游标分页说明</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>最大值：10000000000</para>
    /// <para>最小值：0</para>
    /// </summary>
    [JsonPropertyName("offset")]
    public int? Offset { get; set; }

    /// <summary>
    /// <para>是否返回符合条件的记录总数（Total）。默认为 False，不返回记录总数。</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("need_total_count")]
    public bool? NeedTotalCount { get; set; }
}
