// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-24
//
// Last Modified By : yxr
// Last Modified On : 2025-11-14
// ************************************************************************
// <copyright file="SecurityAndComplianceDeviceRecordDeviceChangeEventV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>设备信息变更事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.SecurityAndCompliance.Events;
/// <summary>
/// 设备信息变更事件 事件体
/// <para>使用该接口，可以订阅接收设备管理变更记录通知，包含设备新增、设备删除、设备归属变更、可信状态变更、设备特征如生产序列号、硬盘序列号等相关信息发生变化时事件通知{使用示例}(url=/api/tools/api_explore/api_explore_config?project=security_and_compliance&amp;version=v2&amp;resource=device_record&amp;event=device_change_event)</para>
/// <para>接口ID：7563551656446246914</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/security_and_compliance-v2/device_record/events/device_change_event</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v2%2fdevice_record%2fevents%2fdevice_change_event</para>
/// </summary>
public record SecurityAndComplianceDeviceRecordDeviceChangeEventV2EventBodyDto() : EventBodyDto("security_and_compliance.device_record.device_change_event_v2")
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
    /// <para>变更类型</para>
    /// <para>**可选值有**：</para>
    /// <para>1:插入,2:更新,3:删除</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：插入</item>
    /// <item>2：更新</item>
    /// <item>3：删除</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("change_type")]
    public int? ChangeType { get; set; }

    /// <summary>
    /// <para>变更前数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("before")]
    public DeviceChangeEvent? Before { get; set; }

    /// <summary>
    /// 设备信息
    /// </summary>
    public record DeviceChangeEvent
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
        /// <para>用户 ID</para>
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

        /// <summary>
        /// <para>是否为受管控设备</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("is_managed")]
        public bool? IsManaged { get; set; }

        /// <summary>
        /// <para>MDM设备ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("mdm_device_id")]
        public string? MdmDeviceId { get; set; }

        /// <summary>
        /// <para>MDM厂商名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("mdm_provider_name")]
        public string? MdmProviderName { get; set; }
    }    

    /// <summary>
    /// <para>变更后数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("after")]
    public DeviceChangeEvent? After { get; set; }    
}
