// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2EmployeesBpsBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询员工 HRBP / 属地 BP 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询员工 HRBP / 属地 BP 请求体
/// <para>查询员工的 HRBP 和属地 BP，包括来自上级部门的 HRBP 和属地 BP。</para>
/// <para>接口ID：7261860942295580674</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/authorization/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployees-bp%2fbatch_get</para>
/// </summary>
public record PostCorehrV2EmployeesBpsBatchGetBodyDto
{
    /// <summary>
    /// <para>员工ID，ID类型与user_id_type的取值意义一致。</para>
    /// <para>如果你需要不同类型的ID进行转换，可以使用 [ID转换服务](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/common_data-id/convert) 换取 ==employment_id==</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("employment_ids")]
    public string[] EmploymentIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>是否获取全部 BP，true 为获取员工所在部门及来自上级部门的全部 HRBP 和属地 BP，false 为仅获取员工的直属 HRBP 和属地 BP（当员工所在部门、属地无 BP 时，会上钻找到最近的 BP），默认为 false</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("get_all")]
    public bool? GetAll { get; set; }
}
