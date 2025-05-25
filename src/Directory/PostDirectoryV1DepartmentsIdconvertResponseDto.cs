// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PostDirectoryV1DepartmentsIdconvertResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>转换部门 ID 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 转换部门 ID 响应体
/// <para>转换部门 ID</para>
/// <para>接口ID：7419214646853206020</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/idconvert</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2fidconvert</para>
/// </summary>
public record PostDirectoryV1DepartmentsIdconvertResponseDto
{
    /// <summary>
    /// <para>id转换结果列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("id_convert_results")]
    public DepartmentIdConvertResult[]? IdConvertResults { get; set; }

    /// <summary>
    /// <para>id转换结果列表</para>
    /// </summary>
    public record DepartmentIdConvertResult
    {
        /// <summary>
        /// <para>ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：ahjdsioad</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>部门ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ahjdsioad</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>部门OpenID</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-9d2eae75a1789adawdaw112wae177bd60c1</para>
        /// </summary>
        [JsonPropertyName("open_department_id")]
        public string? OpenDepartmentId { get; set; }
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
