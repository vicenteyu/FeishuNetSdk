// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PostDirectoryV1DepartmentsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索部门 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 搜索部门 请求体
/// <para>本接口用于搜索部门信息</para>
/// <para>接口ID：7359428154233569284</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2fsearch</para>
/// </summary>
public record PostDirectoryV1DepartmentsSearchBodyDto
{
    /// <summary>
    /// <para>搜索关键词。支持部门名称的搜索</para>
    /// <para>必填：是</para>
    /// <para>示例值：zhang</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string Query { get; set; } = string.Empty;

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
        /// <para>示例值：xdcftvygbuhijhgrexr</para>
        /// </summary>
        [JsonPropertyName("page_token")]
        public string? PageToken { get; set; }
    }

    /// <summary>
    /// <para>需要查询的字段列表。将按照传递的字段列表返回有权限的行、列数据。不传则不会返回任何字段</para>
    /// <para>[了解更多：字段枚举说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/directory-v1/field-enumeration)</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("required_fields")]
    public string[] RequiredFields { get; set; } = Array.Empty<string>();
}
