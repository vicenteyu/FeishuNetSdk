// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2DepartmentsBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询部门 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量查询部门 请求体
/// <para>批量查询部门信息，**该接口只返回部门当前内容**。</para>
/// <para>接口ID：7280432392631549953</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/department/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fbatch_get</para>
/// </summary>
public record PostCorehrV2DepartmentsBatchGetBodyDto
{
    /// <summary>
    /// <para>部门ID列表，和 department_name_list 至少传一种，两个字段都传会按照 AND 方式查询，都不传则返回空。</para>
    /// <para>ID获取方式：</para>
    /// <para>- 调用[【创建部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/create)[【搜索部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/search)等接口可以返回部门ID</para>
    /// <para>- 也可以通过[【事件】创建部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/created)[【事件】更新部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/updated) 获取部门ID信息</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("department_id_list")]
    public string[]? DepartmentIdList { get; set; }

    /// <summary>
    /// <para>返回数据的字段列表，都不传则只返回部门 ID，可选值：</para>
    /// <para>- version_id：当前版本ID</para>
    /// <para>- sub_type：部门子类型</para>
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
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("fields")]
    public string[]? Fields { get; set; }

    /// <summary>
    /// <para>部门名称精确匹配，最多传100个。和 department_id_list 至少传一种，两个字段都传会按照 AND 方式查询，都不传则返回空。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("department_name_list")]
    public string[]? DepartmentNameList { get; set; }
}
