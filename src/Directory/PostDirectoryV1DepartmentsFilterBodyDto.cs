// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PostDirectoryV1DepartmentsFilterBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取部门列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 批量获取部门列表 请求体
/// <para>本接口用于依据指定条件，批量获取符合条件的部门详情列表。</para>
/// <para>接口ID：7359428154233700356</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/filter</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2ffilter</para>
/// </summary>
public record PostDirectoryV1DepartmentsFilterBodyDto
{
    /// <summary>
    /// <para>查询条件[了解更多：查询条件用法](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/directory-v1/filter-usage)</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("filter")]
    public MultiFilterCondition Filter { get; set; } = new();

    /// <summary>
    /// <para>查询条件[了解更多：查询条件用法](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/directory-v1/filter-usage)</para>
    /// </summary>
    public record MultiFilterCondition
    {
        /// <summary>
        /// <para>比较表达式列表。多个表达式之间的关系默认为“and”</para>
        /// <para>必填：是</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("conditions")]
        public FilterCondition[] Conditions { get; set; } = Array.Empty<FilterCondition>();

        /// <summary>
        /// <para>比较表达式列表。多个表达式之间的关系默认为“and”</para>
        /// </summary>
        public record FilterCondition
        {
            /// <summary>
            /// <para>筛选条件的左值，值为字段的参数名称。</para>
            /// <para>**可选的筛选条件有：**</para>
            /// <para>- parent_department_id</para>
            /// <para>必填：是</para>
            /// <para>示例值：parent_department_id</para>
            /// </summary>
            [JsonPropertyName("field")]
            public string Field { get; set; } = string.Empty;

            /// <summary>
            /// <para>比较操作符</para>
            /// <para>**可选值有：**</para>
            /// <para>- eq：等于，支持任何类型的左值</para>
            /// <para>- in：属于任一，不支持parent_department_id，右值为多个目标筛选值构成的数组（不得超过100个）</para>
            /// <para>必填：是</para>
            /// <para>示例值：eq</para>
            /// </summary>
            [JsonPropertyName("operator")]
            public string Operator { get; set; } = string.Empty;

            /// <summary>
            /// <para>筛选条件的右值。内容为左值字段类型及操作符组合下，对应的值类型。</para>
            /// <para>使用parent_department_id条件时，根部门的ID可使用"0"</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"0\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>需要查询的字段列表。将按照传递的字段列表返回有权限的行、列数据。不传则不会返回任何字段[了解更多：字段枚举说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/directory-v1/field-enumeration)</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("required_fields")]
    public string[] RequiredFields { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>分页信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("page_request")]
    public PageCondition PageRequest { get; set; } = new();

    /// <summary>
    /// <para>分页信息</para>
    /// </summary>
    public record PageCondition
    {
        /// <summary>
        /// <para>本次请求条数，最大100条</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>顺序分页查询，不能跳页查询，支持深分页，在需要遍历全部数据的场景只能使用该方式。第一次传空字符串或者不传，后面传上一次的返回值中的page_token</para>
        /// <para>必填：否</para>
        /// <para>示例值：iuu14140aknladna91ndas</para>
        /// </summary>
        [JsonPropertyName("page_token")]
        public string? PageToken { get; set; }
    }
}
