// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-24
//
// Last Modified By : yxr
// Last Modified On : 2025-10-24
// ************************************************************************
// <copyright file="SecurityAndComplianceDeviceApplyRecordDeviceApplyEventV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>设备申报事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.SecurityAndCompliance.Events;
/// <summary>
/// 设备申报事件 事件体
/// <para>订阅此事件后，成员提交设备自主申报后会收到通知，通知包含申报设备的参数以及申报人等信息{使用示例}(url=/api/tools/api_explore/api_explore_config?project=security_and_compliance&amp;version=v2&amp;resource=device_apply_record&amp;event=device_apply_event)</para>
/// <para>接口ID：7430737008881598466</para>
/// <para>文档地址：https://open.feishu.cn/document/security_and_compliance-v1/security_and_compliance-v2/device_apply_record/events/device_apply_event</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v2%2fdevice_apply_record%2fevents%2fdevice_apply_event</para>
/// </summary>
public record SecurityAndComplianceDeviceApplyRecordDeviceApplyEventV2EventBodyDto() : EventBodyDto("security_and_compliance.device_apply_record.device_apply_event_v2")
{
    /// <summary>
    /// <para>设备申报记录ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("device_apply_record_id")]
    public string? DeviceApplyRecordId { get; set; }

    /// <summary>
    /// <para>设备记录</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("device_record")]
    public DeviceRecordEvent? DeviceRecord { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record DeviceRecordEvent
    {
        /// <summary>
        /// <para>设备认证编码</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("device_record_id")]
        public string? DeviceRecordId { get; set; }

        /// <summary>
        /// <para>版本号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// <para>当前登录用户 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("current_user_id")]
        public UserIdSuffix? CurrentUserId { get; set; }

        /// <summary>
        /// <para>设备名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("device_name")]
        public string? DeviceName { get; set; }

        /// <summary>
        /// <para>设备型号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// <para>操作系统</para>
        /// <para>**可选值有**：</para>
        /// <para>1:Windows,2:macOS,3:Linux,4:Android,5:iOS,6:OpenHarmony</para>
        /// <para>必填：否</para>
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
        public int? DeviceSystem { get; set; }

        /// <summary>
        /// <para>生产序列号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("serial_number")]
        public string? SerialNumber { get; set; }

        /// <summary>
        /// <para>硬盘序列号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("disk_serial_number")]
        public string? DiskSerialNumber { get; set; }

        /// <summary>
        /// <para>主板UUID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// <para>MAC地址</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("mac_address")]
        public string? MacAddress { get; set; }

        /// <summary>
        /// <para>Android标识符</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("android_id")]
        public string? AndroidId { get; set; }

        /// <summary>
        /// <para>iOS供应商标识符</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("idfv")]
        public string? Idfv { get; set; }

        /// <summary>
        /// <para>Harmony供应商标识符</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("aaid")]
        public string? Aaid { get; set; }

        /// <summary>
        /// <para>设备归属</para>
        /// <para>**可选值有**：</para>
        /// <para>0:未知设备,1:个人设备,2:企业设备</para>
        /// <para>必填：否</para>
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
        /// <para>**可选值有**：</para>
        /// <para>0:未知状态,1:信任设备,2:非信任设备</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：未知状态</item>
        /// <item>1：信任设备</item>
        /// <item>2：非信任设备</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("device_status")]
        public int? DeviceStatus { get; set; }

        /// <summary>
        /// <para>认证方式</para>
        /// <para>**可选值有**：</para>
        /// <para>0:未知,1:飞书认证,2:终端管理认证</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：未知</item>
        /// <item>1：飞书认证</item>
        /// <item>2：终端管理认证</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("certification_level")]
        public int? CertificationLevel { get; set; }

        /// <summary>
        /// <para>设备类型</para>
        /// <para>**可选值有**：</para>
        /// <para>0:未知,1:移动端,2:桌面端</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：未知</item>
        /// <item>1：移动端</item>
        /// <item>2：桌面端</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("device_terminal_type")]
        public int? DeviceTerminalType { get; set; }
    }

    /// <summary>
    /// <para>申报时间</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("apply_time")]
    public string? ApplyTime { get; set; }

    /// <summary>
    /// <para>申报状态</para>
    /// <para>**可选值有**：</para>
    /// <para>0:未知,1:待审核,2:审核通过,3:已驳回</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：未知</item>
    /// <item>1：待审核</item>
    /// <item>2：审核通过</item>
    /// <item>3：已驳回</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("apply_status")]
    public int? ApplyStatus { get; set; }

    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator")]
    public UserIdSuffix? Operator { get; set; }

    /// <summary>
    /// <para>申报设备归属</para>
    /// <para>**可选值有**：</para>
    /// <para>0:未知设备,1:个人设备,2:企业设备</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：未知设备</item>
    /// <item>1：个人设备</item>
    /// <item>2：企业设备</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("apply_device_ownership")]
    public int? ApplyDeviceOwnership { get; set; }
}
