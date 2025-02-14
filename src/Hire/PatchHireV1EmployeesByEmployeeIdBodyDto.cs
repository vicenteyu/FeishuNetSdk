// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-28
// ************************************************************************
// <copyright file="PatchHireV1EmployeesByEmployeeIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新员工状态 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新员工状态 请求体
/// <para>根据员工 ID 更新员工招聘系统内的转正、离职状态。</para>
/// <para>接口ID：6959374328975900674</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/onboard/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2femployee%2fpatch</para>
/// </summary>
public record PatchHireV1EmployeesByEmployeeIdBodyDto
{
    /// <summary>
    /// <para>修改状态操作类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：转正</item>
    /// <item>2：离职</item>
    /// <item>3：恢复至待入职</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("operation")]
    public int Operation { get; set; }

    /// <summary>
    /// <para>转正信息，操作类型operation为`转正`时必填</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("conversion_info")]
    public EmployeeConversionInfo? ConversionInfo { get; set; }

    /// <summary>
    /// <para>转正信息，操作类型operation为`转正`时必填</para>
    /// </summary>
    public record EmployeeConversionInfo
    {
        /// <summary>
        /// <para>实际转正日期，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1637596800000</para>
        /// </summary>
        [JsonPropertyName("actual_conversion_time")]
        public long? ActualConversionTime { get; set; }
    }

    /// <summary>
    /// <para>离职信息，操作类型operation为`离职`时必填</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("overboard_info")]
    public EmployeeOverboardInfo? OverboardInfo { get; set; }

    /// <summary>
    /// <para>离职信息，操作类型operation为`离职`时必填</para>
    /// </summary>
    public record EmployeeOverboardInfo
    {
        /// <summary>
        /// <para>实际离职日期，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1637596800000</para>
        /// </summary>
        [JsonPropertyName("actual_overboard_time")]
        public long? ActualOverboardTime { get; set; }

        /// <summary>
        /// <para>离职原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：职业发展考虑</para>
        /// </summary>
        [JsonPropertyName("overboard_note")]
        public string? OverboardNote { get; set; }
    }
}
