// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-24
//
// Last Modified By : yxr
// Last Modified On : 2025-10-24
// ************************************************************************
// <copyright file="GetSecurityAndComplianceV2DeviceRecordsByDeviceRecordIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取设备信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.SecurityAndCompliance;
/// <summary>
/// 获取设备信息 响应体
/// <para>使用该接口在设备管理中获取设备的设备参数、设备归属、设备状态等信息</para>
/// <para>接口ID：7430737008881647618</para>
/// <para>文档地址：https://open.feishu.cn/document/security_and_compliance-v1/security_and_compliance-v2/device_record/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v2%2fdevice_record%2fget</para>
/// </summary>
public record GetSecurityAndComplianceV2DeviceRecordsByDeviceRecordIdResponseDto
{
    /// <summary>
    /// <para>设备记录</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("device_record")]
    public GetSecurityAndComplianceV2DeviceRecordsByDeviceRecordIdResponseDtoDeviceRecord? DeviceRecord { get; set; }

    /// <summary>
    /// <para>设备记录</para>
    /// </summary>
    public record GetSecurityAndComplianceV2DeviceRecordsByDeviceRecordIdResponseDtoDeviceRecord
    {
        /// <summary>
        /// <para>设备认证编码</para>
        /// <para>必填：是</para>
        /// <para>示例值：7089353870308032531</para>
        /// </summary>
        [JsonPropertyName("device_record_id")]
        public string DeviceRecordId { get; set; } = string.Empty;

        /// <summary>
        /// <para>版本号</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; } = string.Empty;

        /// <summary>
        /// <para>当前登录用户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_b25e90585ef8c1adac4b379c2e257906</para>
        /// </summary>
        [JsonPropertyName("current_user_id")]
        public string? CurrentUserId { get; set; }

        /// <summary>
        /// <para>设备名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：Q9C6RYMFDK</para>
        /// </summary>
        [JsonPropertyName("device_name")]
        public string? DeviceName { get; set; }

        /// <summary>
        /// <para>设备型号</para>
        /// <para>必填：否</para>
        /// <para>示例值：iPhone13,2</para>
        /// </summary>
        [JsonPropertyName("model")]
        public string? Model { get; set; }

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

        /// <summary>
        /// <para>认证方式</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：未知</item>
        /// <item>1：飞书认证</item>
        /// <item>2：终端管理认证</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("certification_level")]
        public int CertificationLevel { get; set; }

        /// <summary>
        /// <para>设备类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：未知</item>
        /// <item>1：移动端</item>
        /// <item>2：桌面端</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("device_terminal_type")]
        public int DeviceTerminalType { get; set; }

        /// <summary>
        /// <para>最近登录用户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_b25e90585ef8c1adac4b379c2e257906</para>
        /// </summary>
        [JsonPropertyName("latest_user_id")]
        public string? LatestUserId { get; set; }

        /// <summary>
        /// <para>设备指纹列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("dids")]
        public string[]? Dids { get; set; }

        /// <summary>
        /// <para>是否为受管控设备</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_managed")]
        public bool? IsManaged { get; set; }

        /// <summary>
        /// <para>MDM设备ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：123abc</para>
        /// </summary>
        [JsonPropertyName("mdm_device_id")]
        public string? MdmDeviceId { get; set; }

        /// <summary>
        /// <para>MDM厂商名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：Workspace_ONE</para>
        /// </summary>
        [JsonPropertyName("mdm_provider_name")]
        public string? MdmProviderName { get; set; }
    }
}
