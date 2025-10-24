// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-24
//
// Last Modified By : yxr
// Last Modified On : 2025-10-24
// ************************************************************************
// <copyright file="GetSecurityAndComplianceV2DeviceRecordsMineResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取客户端设备认证信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.SecurityAndCompliance;
/// <summary>
/// 获取客户端设备认证信息 响应体
/// <para>通过客户端授权信息获取对应设备认证信息，包含设备归属、可信状态等</para>
/// <para>接口ID：7563551656446263298</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/security_and_compliance-v2/device_record/mine</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v2%2fdevice_record%2fmine</para>
/// </summary>
public record GetSecurityAndComplianceV2DeviceRecordsMineResponseDto
{
    /// <summary>
    /// <para>设备认证编码</para>
    /// <para>必填：否</para>
    /// <para>示例值：7089353870308032531</para>
    /// </summary>
    [JsonPropertyName("device_record_id")]
    public string? DeviceRecordId { get; set; }

    /// <summary>
    /// <para>设备归属</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：未知设备</item>
    /// <item>1：个人设备</item>
    /// <item>2：企业设备</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("device_ownership")]
    public int? DeviceOwnership { get; set; }

    /// <summary>
    /// <para>可信状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：未知状态</item>
    /// <item>1：信任设备</item>
    /// <item>2：非信任设备</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("device_status")]
    public int? DeviceStatus { get; set; }
}
