// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-24
//
// Last Modified By : yxr
// Last Modified On : 2025-10-24
// ************************************************************************
// <copyright file="PutSecurityAndComplianceV2DeviceApplyRecordsByDeviceApplyRecordIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>审批设备申报 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.SecurityAndCompliance;
/// <summary>
/// 审批设备申报 请求体
/// <para>使用该接口在设备管理中通过或驳回一条成员自主申报申请</para>
/// <para>接口ID：7430737008881582082</para>
/// <para>文档地址：https://open.feishu.cn/document/security_and_compliance-v1/security_and_compliance-v2/device_apply_record/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v2%2fdevice_apply_record%2fupdate</para>
/// </summary>
public record PutSecurityAndComplianceV2DeviceApplyRecordsByDeviceApplyRecordIdBodyDto
{
    /// <summary>
    /// <para>是否审批通过</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("is_approved")]
    public bool IsApproved { get; set; }
}
