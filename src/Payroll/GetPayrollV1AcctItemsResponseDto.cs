// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="GetPayrollV1AcctItemsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询算薪项 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Payroll;
/// <summary>
/// 批量查询算薪项 响应体
/// <para>批量查询算薪项</para>
/// <para>接口ID：7387360801748402177</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/acct_item/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2facct_item%2flist</para>
/// </summary>
public record GetPayrollV1AcctItemsResponseDto : IPageableResponse<GetPayrollV1AcctItemsResponseDto.AcctItem>
{
    /// <summary>
    /// <para>算薪项列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public AcctItem[]? Items { get; set; }

    /// <summary>
    /// <para>算薪项列表</para>
    /// </summary>
    public record AcctItem
    {
        /// <summary>
        /// <para>算薪项ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7169773973790425132</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>算薪项名称</para>
        /// <para>必填：否</para>
        /// <para>最大长度：99</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("i18n_names")]
        public I18nContent[]? I18nNames { get; set; }

        /// <summary>
        /// <para>算薪项名称</para>
        /// </summary>
        public record I18nContent
        {
            /// <summary>
            /// <para>语种</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn</para>
            /// <para>默认值：zh_cn</para>
            /// </summary>
            [JsonPropertyName("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// <para>语种对应的值</para>
            /// <para>必填：否</para>
            /// <para>示例值：名称</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }

            /// <summary>
            /// <para>名称对应的实体id，该场景不返回，请忽略</para>
            /// <para>必填：否</para>
            /// <para>示例值：723123123123123213</para>
            /// <para>最大长度：99</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }
        }

        /// <summary>
        /// <para>算薪项分类ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7169773973790425132</para>
        /// </summary>
        [JsonPropertyName("category_id")]
        public string? CategoryId { get; set; }

        /// <summary>
        /// <para>算薪项数据类型</para>
        /// <para>文本 - 1</para>
        /// <para>金额 - 2</para>
        /// <para>数值 - 3</para>
        /// <para>百分数 - 4</para>
        /// <para>日期 - 5</para>
        /// <para>引用项 - 6</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>最大值：99</para>
        /// <para>最小值：1</para>
        /// </summary>
        [JsonPropertyName("data_type")]
        public int? DataType { get; set; }

        /// <summary>
        /// <para>小数位数</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// <para>最大值：99</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("decimal_places")]
        public int? DecimalPlaces { get; set; }

        /// <summary>
        /// <para>启用状态</para>
        /// <para>已启用 - 1</para>
        /// <para>已停用 - 2</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>最大值：2</para>
        /// <para>最小值：1</para>
        /// </summary>
        [JsonPropertyName("active_status")]
        public int? ActiveStatus { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
