// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-24
// ************************************************************************
// <copyright file="PostCorehrV2DepartmentsTreeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询指定生效日期的部门架构树 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询指定生效日期的部门架构树 响应体
/// <para>支持传入部门ID（不传默认根部门），任意日期（不传默认当前日期）。从给定部门ID开始广度遍历，每页最多返回2000行数据</para>
/// <para>接口ID：7405851978397581314</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/department/tree</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2ftree</para>
/// </summary>
public record PostCorehrV2DepartmentsTreeResponseDto
{
    /// <summary>
    /// <para>部门树节点</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public DepartmentTree[]? Items { get; set; }

    /// <summary>
    /// <para>部门树节点</para>
    /// </summary>
    public record DepartmentTree
    {
        /// <summary>
        /// <para>部门 ID</para>
        /// <para>- 可通过[批量查询部门V2](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get) 或者[搜索部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/search) 获取详情</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719456877659520852</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>部门绝对层级，根部门层级为0，根部门的子部门层级为1，依次类推</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>最大值：99</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("level")]
        public int? Level { get; set; }

        /// <summary>
        /// <para>下级部门 ID 列表</para>
        /// <para>- 可通过[批量查询部门V2](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get) 或者[搜索部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/search) 获取详情</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("children")]
        public string[]? Children { get; set; }
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
