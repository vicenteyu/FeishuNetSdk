// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PostDirectoryV1EmployeesSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索员工 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 搜索员工信息 请求体
/// <para>本接口用于搜索员工信息，如通过关键词搜索员工的名称、手机号、邮箱等信息。</para>
/// <para>员工指飞书企业内身份为「Employee」的成员，等同于通讯录OpenAPI中的「User」。</para>
/// <para>接口ID：7359428154233618436</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fsearch</para>
/// </summary>
public record PostDirectoryV1EmployeesSearchBodyDto
{
    /// <summary>
    /// <para>搜索关键词。支持员工ID、员工名称、员工手机号、员工邮箱的搜索。其中员工ID、员工手机号支持精确搜索，员工名称、员工邮箱支持模糊搜索，员工名称支持国际化名称的搜索。</para>
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
        /// <para>本次请求条数，最小是0条，最大100条</para>
        /// <para>**默认值**：20</para>
        /// <para>必填：否</para>
        /// <para>示例值：10</para>
        /// </summary>
        [JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>顺序分页查询，不能跳页查询，支持深分页，在需要遍历全部数据的场景只能使用该方式。</para>
        /// <para>第一次传空字符串或者不传，后面传上一次的返回值中的page_token。</para>
        /// <para>必填：否</para>
        /// <para>示例值：asdjiowers</para>
        /// </summary>
        [JsonPropertyName("page_token")]
        public string? PageToken { get; set; }
    }

    /// <summary>
    /// <para>需要查询的字段列表。将按照传递的字段列表返回有权限的行、列数据。不传则不会返回任何字段[了解更多：字段枚举说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/directory-v1/field-enumeration)</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("required_fields")]
    public string[] RequiredFields { get; set; } = Array.Empty<string>();
}
