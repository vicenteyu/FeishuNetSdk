// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-24
//
// Last Modified By : yxr
// Last Modified On : 2025-10-24
// ************************************************************************
// <copyright file="PostSecurityAndComplianceV2DeviceRecordsBodyDtoUserApi.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增设备 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.SecurityAndCompliance;
/// <summary>
/// 新增设备 请求体
/// <para>使用该接口在设备管理中新增一台设备。新增设备的类型为管理员导入</para>
/// <para>接口ID：7430737008881614850</para>
/// <para>文档地址：https://open.feishu.cn/document/security_and_compliance-v1/security_and_compliance-v2/device_record/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v2%2fdevice_record%2fcreate</para>
/// </summary>
public record PostSecurityAndComplianceV2DeviceRecordsBodyDto
{
    /// <summary>
    /// <para>操作系统</para>
    /// <para>必填：是</para>
    /// <para>示例值：0</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：Windows</item>
    /// <item>2：macOS</item>
    /// <item>3：Linux</item>
    /// <item>4：Android</item>
    /// <item>5：iOS</item>
    /// <item>6：OpenHarmony</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("device_system")]
    public int DeviceSystem { get; set; }

    /// <summary>
    /// <para>生产序列号</para>
    /// <para>必填：否</para>
    /// <para>示例值：C02DTHRMML7H</para>
    /// </summary>
    [JsonPropertyName("serial_number")]
    public string? SerialNumber { get; set; }

    /// <summary>
    /// <para>硬盘序列号</para>
    /// <para>必填：否</para>
    /// <para>示例值：CC344362-5990-5A68-8DDD-64A23C99FA0C</para>
    /// </summary>
    [JsonPropertyName("disk_serial_number")]
    public string? DiskSerialNumber { get; set; }

    /// <summary>
    /// <para>主板UUID</para>
    /// <para>必填：否</para>
    /// <para>示例值：621CDFF0-13D0-5AB1-9ADC-5F560095F6ED</para>
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>
    /// <para>MAC地址</para>
    /// <para>必填：否</para>
    /// <para>示例值：ac:de:48:00:11:21</para>
    /// </summary>
    [JsonPropertyName("mac_address")]
    public string? MacAddress { get; set; }

    /// <summary>
    /// <para>Android标识符</para>
    /// <para>必填：否</para>
    /// <para>示例值：02a11ac4a83b918e</para>
    /// </summary>
    [JsonPropertyName("android_id")]
    public string? AndroidId { get; set; }

    /// <summary>
    /// <para>iOS供应商标识符</para>
    /// <para>必填：否</para>
    /// <para>示例值：968F0E5C-C297-4122-ACB6-102494DEFD9A</para>
    /// </summary>
    [JsonPropertyName("idfv")]
    public string? Idfv { get; set; }

    /// <summary>
    /// <para>Harmony供应商标识符</para>
    /// <para>必填：否</para>
    /// <para>示例值：ff3c2237-cd76-4331-9d72-0a4470854567</para>
    /// </summary>
    [JsonPropertyName("aaid")]
    public string? Aaid { get; set; }

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
