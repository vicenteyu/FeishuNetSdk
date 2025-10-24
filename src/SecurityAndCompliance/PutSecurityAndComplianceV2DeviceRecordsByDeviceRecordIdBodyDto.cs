// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-24
//
// Last Modified By : yxr
// Last Modified On : 2025-10-24
// ************************************************************************
// <copyright file="PutSecurityAndComplianceV2DeviceRecordsByDeviceRecordIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新设备 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.SecurityAndCompliance;
/// <summary>
/// 更新设备 请求体
/// <para>使用该接口在设备管理中修改一台设备的设备归属、设备状态等信息</para>
/// <para>接口ID：7430737008881664002</para>
/// <para>文档地址：https://open.feishu.cn/document/security_and_compliance-v1/security_and_compliance-v2/device_record/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v2%2fdevice_record%2fupdate</para>
/// </summary>
public record PutSecurityAndComplianceV2DeviceRecordsByDeviceRecordIdBodyDto
{
    /// <summary>
    /// <para>设备归属</para>
    /// <para>必填：是</para>
    /// <para>示例值：0</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：未知设备</item>
    /// <item>1：个人设备</item>
    /// <item>2：企业设备</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("device_ownership")]
    public int DeviceOwnership { get; set; }

    /// <summary>
    /// <para>可信状态</para>
    /// <para>必填：是</para>
    /// <para>示例值：0</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：未知状态</item>
    /// <item>1：信任设备</item>
    /// <item>2：非信任设备</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("device_status")]
    public int DeviceStatus { get; set; }
}
