// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-24
//
// Last Modified By : yxr
// Last Modified On : 2025-10-24
// ************************************************************************
// <copyright file="PostSecurityAndComplianceV2DeviceRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增设备 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.SecurityAndCompliance;
/// <summary>
/// 新增设备 响应体
/// <para>使用该接口在设备管理中新增一台设备。新增设备的类型为管理员导入</para>
/// <para>接口ID：7430737008881614850</para>
/// <para>文档地址：https://open.feishu.cn/document/security_and_compliance-v1/security_and_compliance-v2/device_record/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v2%2fdevice_record%2fcreate</para>
/// </summary>
public record PostSecurityAndComplianceV2DeviceRecordsResponseDto
{
    /// <summary>
    /// <para>设备认证编码</para>
    /// <para>必填：否</para>
    /// <para>示例值：7089353870308032531</para>
    /// </summary>
    [JsonPropertyName("device_record_id")]
    public string? DeviceRecordId { get; set; }
}
