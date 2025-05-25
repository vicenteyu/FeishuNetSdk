// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PostDirectoryV1EmployeesIdconvertResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>转换员工 ID 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 转换员工 ID 响应体
/// <para>转换员工 ID</para>
/// <para>接口ID：7419214646853107716</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/idconvert</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fidconvert</para>
/// </summary>
public record PostDirectoryV1EmployeesIdconvertResponseDto
{
    /// <summary>
    /// <para>id转换结果列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("id_convert_results")]
    public EmployeeIdConvertResult[]? IdConvertResults { get; set; }

    /// <summary>
    /// <para>id转换结果列表</para>
    /// </summary>
    public record EmployeeIdConvertResult
    {
        /// <summary>
        /// <para>ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：ahjdsioad</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>员工ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ahjdsioad</para>
        /// </summary>
        [JsonPropertyName("employee_id")]
        public string? EmployeeId { get; set; }

        /// <summary>
        /// <para>员工OpenID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_55432732133012310fb4390611231de61</para>
        /// </summary>
        [JsonPropertyName("open_employee_id")]
        public string? OpenEmployeeId { get; set; }

        /// <summary>
        /// <para>员工UnionID</para>
        /// <para>必填：否</para>
        /// <para>示例值：on_b25e9058531123dawac4b379c2e257906</para>
        /// </summary>
        [JsonPropertyName("union_employee_id")]
        public string? UnionEmployeeId { get; set; }
    }

    /// <summary>
    /// <para>异常信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("abnormals")]
    public AbnormalRecord[]? Abnormals { get; set; }

    /// <summary>
    /// <para>异常信息列表</para>
    /// </summary>
    public record AbnormalRecord
    {
        /// <summary>
        /// <para>异常ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：eedasfwe</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>行级异常</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>最大值：100</para>
        /// <para>最小值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：成功</item>
        /// <item>1000：没权限</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("row_error")]
        public int? RowError { get; set; }

        /// <summary>
        /// <para>列级异常</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("field_errors")]
        public object? FieldErrors { get; set; }
    }
}
