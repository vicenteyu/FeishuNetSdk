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
/// <para>该接口支持通过部门id、上级部门ID、部门负责人、名称、编码字段批量搜索当天的部门详情信息，包括部门包含的名称、描述、启用状态等。</para>
/// <para>接口ID：7211423970042200068</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/department/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fsearch</para>
/// </summary>
public record PostCorehrV2DepartmentsSearchBodyDto
{
    /// <summary>
    /// <para>该部门是否启用，true为启用，false为停用</para>
    /// <para>- 如果传空则所有启用状态数据都返回</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// <para>当通过上级部门 ID 查询时，填写 true 返回所有子部门，填写 false 只返回直接下级部门</para>
    /// <para>- 默认为false</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("get_all_children")]
    public bool? GetAllChildren { get; set; }

    /// <summary>
    /// <para>部门负责人 ID 列表</para>
    /// <para>- 详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search) 或 [【批量查询员工】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get) 接口获取</para>
    /// <para>- 传非空值返回指定部门负责人的部门，传空值则不加该筛选条件</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("manager_list")]
    public string[]? ManagerList { get; set; }

    /// <summary>
    /// <para>部门 ID列表，用来做条件筛选</para>
    /// <para>- 传非空值返回指定部门ID，传空值则不加该筛选条件</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("department_id_list")]
    public string[]? DepartmentIdList { get; set; }

    /// <summary>
    /// <para>部门名称列表，需精确匹配，用于筛选条件</para>
    /// <para>- 传非空值则返回指定部门名称的部门，传空值则不加该筛选条件</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("name_list")]
    public string[]? NameList { get; set; }

    /// <summary>
    /// <para>上级部门 ID</para>
    /// <para>- 可通过[批量查询部门V2](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get) 或者[搜索部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/search) 获取详情</para>
    /// <para>- 传非空值返回指定上级部门ID的子部门，传空值则不加该筛选条件</para>
    /// <para>必填：否</para>
    /// <para>示例值：7094136522860922222</para>
    /// </summary>
    [JsonPropertyName("parent_department_id")]
    public string? ParentDepartmentId { get; set; }

    /// <summary>
    /// <para>部门编码列表</para>
    /// <para>- 传非空值返回指定编码的部门，传空值则不加该筛选条件</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("code_list")]
    public string[]? CodeList { get; set; }

    /// <summary>
    /// <para>返回数据的字段列表，如果传空只返回部门id，可选值：</para>
    /// <para>- version_id：当前版本ID</para>
    /// <para>- sub_type：部门类型</para>
    /// <para>- manager：负责人</para>
    /// <para>- is_root：是否根部门</para>
    /// <para>- is_confidential：是否保密</para>
    /// <para>- effective_date：当前版本生效日期</para>
    /// <para>- expiration_date：当前版本失效日期</para>
    /// <para>- department_name：部门名称</para>
    /// <para>- parent_department_id：上级部门ID</para>
    /// <para>- tree_order：树形排序</para>
    /// <para>- list_order：列表排序</para>
    /// <para>- code：部门编码</para>
    /// <para>- active：是否启用</para>
    /// <para>- description：部门描述</para>
    /// <para>- custom_fields：自定义字段</para>
    /// <para>- staffing_model：岗职务模式</para>
    /// <para>- cost_center_id：部门默认成本中心</para>
    /// <para>- created_time：创建时间</para>
    /// <para>- updated_time：更新时间</para>
    /// <para>- created_by：创建人</para>
    /// <para>- updated_by：更新人</para>
    /// <para>- record_created_time：记录创建时间</para>
    /// <para>- record_updated_time：记录更新时间</para>
    /// <para>- record_created_by：记录创建人</para>
    /// <para>- record_updated_by：记录更新人</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("fields")]
    public string[]? Fields { get; set; }
}
