// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2DepartmentsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索部门信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索部门信息 请求体
/// <para>搜索部门信息</para>
/// <para>接口ID：7211423970042200068</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/department/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fsearch</para>
/// </summary>
public record PostCorehrV2DepartmentsSearchBodyDto
{
    /// <summary>
    /// <para>是否启用</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// <para>当通过上级部门 ID 查询时，填写 true 返回所有子部门，填写 false 只返回直接下级部门</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("get_all_children")]
    public bool? GetAllChildren { get; set; }

    /// <summary>
    /// <para>manager ID 列表，按部门直接负责人搜索</para>
    /// <para>字段权限要求：</para>
    /// <para>按照部门负责人搜索 (corehr:department.manager.search:read)</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("manager_list")]
    public string[]? ManagerList { get; set; }

    /// <summary>
    /// <para>部门 ID 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("department_id_list")]
    public string[]? DepartmentIdList { get; set; }

    /// <summary>
    /// <para>部门名称列表，需精确匹配</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("name_list")]
    public string[]? NameList { get; set; }

    /// <summary>
    /// <para>上级部门 ID ，可查询直接下级部门</para>
    /// <para>字段权限要求：</para>
    /// <para>按照上级部门搜索(corehr:department.organize.search:read)</para>
    /// <para>必填：否</para>
    /// <para>示例值：7094136522860922222</para>
    /// </summary>
    [JsonPropertyName("parent_department_id")]
    public string? ParentDepartmentId { get; set; }

    /// <summary>
    /// <para>部门 code 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("code_list")]
    public string[]? CodeList { get; set; }

    /// <summary>
    /// <para>返回数据的字段列表，为空时不返回任何字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("fields")]
    public string[]? Fields { get; set; }
}
