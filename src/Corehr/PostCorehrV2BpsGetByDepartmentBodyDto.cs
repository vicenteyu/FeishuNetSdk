// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2BpsGetByDepartmentBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询部门 HRBP 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询部门 HRBP 请求体
/// <para>查询部门的 HRBP 信息，包括来自上级部门的 HRBP。</para>
/// <para>接口ID：7261860942295547906</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/bp/get_by_department</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbp%2fget_by_department</para>
/// </summary>
public record PostCorehrV2BpsGetByDepartmentBodyDto
{
    /// <summary>
    /// <para>部门 ID，ID类型与department_id_type的取值意义一致。</para>
    /// <para>可以使用 [ID转换服务](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/common_data-id/convert)换取 ==department_id==</para>
    /// <para>部门id也可通过[搜索部门信息](https://open.larkoffice.com/document/server-docs/corehr-v1/organization-management/department/search)接口获取。</para>
    /// <para>必填：是</para>
    /// <para>示例值：6893014062142064111</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string DepartmentId { get; set; } = string.Empty;
}
