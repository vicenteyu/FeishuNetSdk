// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2EmployeesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加人员 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 添加人员 响应体
/// <para>支持在单个接口中进行人员全信息添加，包括人员的基本信息，雇佣信息，入职任职记录及其他分组信息</para>
/// <para>接口ID：7350663854198161410</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee%2fcreate</para>
/// </summary>
public record PostCorehrV2EmployeesResponseDto
{
    /// <summary>
    /// <para>雇佣信息 ID</para>
    /// <para>可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取详细信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：6862995757234914824</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }

    /// <summary>
    /// <para>合同 ID</para>
    /// <para>可通过[【批量查询合同】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/contract/list)接口获取详细信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：6862995757234914824</para>
    /// </summary>
    [JsonPropertyName("contract_id")]
    public string? ContractId { get; set; }

    /// <summary>
    /// <para>任职信息 ID</para>
    /// <para>可通过[【批量查询员工任职信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employees-job_data/batch_get)接口获取详细信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：6862995757234914824</para>
    /// </summary>
    [JsonPropertyName("job_data_id")]
    public string? JobDataId { get; set; }
}
