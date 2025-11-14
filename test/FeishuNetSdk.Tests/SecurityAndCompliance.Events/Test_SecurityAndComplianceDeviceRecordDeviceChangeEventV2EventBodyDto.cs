// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-24
//
// Last Modified By : yxr
// Last Modified On : 2025-10-24
// ************************************************************************
// <copyright file="Test_SecurityAndComplianceDeviceRecordDeviceChangeEventV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 设备信息变更事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.SecurityAndCompliance.Events;

/// <summary>
/// 测试 设备信息变更事件 事件体
/// <para>接口ID：7563551656446246914</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/security_and_compliance-v2/device_record/events/device_change_event</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v2%2fdevice_record%2fevents%2fdevice_change_event</para>
/// </summary>
[TestClass]
public class Test_SecurityAndComplianceDeviceRecordDeviceChangeEventV2EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "security_and_compliance.device_record.device_change_event_v2",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "device_record_id": "7089353870308032531",
        "version": "0",
        "change_type": 1,
        "before": {
            "device_record_id": "7089353870308032531",
            "version": "0",
            "current_user_id": {
                "union_id": "on_8ed6aa67826108097d9ee143816345",
                "user_id": "e33ggbyz",
                "open_id": "ou_84aad35d084aa403a838cf73ee18467"
            },
            "device_name": "Q9C6RYMFDK",
            "model": "iPhone13,2",
            "device_system": 0,
            "serial_number": "C02DTHRMML7H",
            "disk_serial_number": "CC344362-5990-5A68-8DDD-64A23C99FA0C",
            "uuid": "621CDFF0-13D0-5AB1-9ADC-5F560095F6ED",
            "mac_address": "ac:de:48:00:11:21",
            "android_id": "02a11ac4a83b918e",
            "idfv": "968F0E5C-C297-4122-ACB6-102494DEFD9A",
            "aaid": "ff3c2237-cd76-4331-9d72-0a4470854567",
            "device_ownership": 0,
            "device_status": 0,
            "certification_level": 0,
            "device_terminal_type": 0,
            "is_managed": true,
            "mdm_device_id": "123abc",
            "mdm_provider_name": "Workspace_ONE"
        },
        "after": {
            "device_record_id": "7089353870308032531",
            "version": "0",
            "current_user_id": {
                "union_id": "on_8ed6aa67826108097d9ee143816345",
                "user_id": "e33ggbyz",
                "open_id": "ou_84aad35d084aa403a838cf73ee18467"
            },
            "device_name": "Q9C6RYMFDK",
            "model": "iPhone13,2",
            "device_system": 0,
            "serial_number": "C02DTHRMML7H",
            "disk_serial_number": "CC344362-5990-5A68-8DDD-64A23C99FA0C",
            "uuid": "621CDFF0-13D0-5AB1-9ADC-5F560095F6ED",
            "mac_address": "ac:de:48:00:11:21",
            "android_id": "02a11ac4a83b918e",
            "idfv": "968F0E5C-C297-4122-ACB6-102494DEFD9A",
            "aaid": "ff3c2237-cd76-4331-9d72-0a4470854567",
            "device_ownership": 0,
            "device_status": 0,
            "certification_level": 0,
            "device_terminal_type": 0,
            "is_managed": true,
            "mdm_device_id": "123abc",
            "mdm_provider_name": "Workspace_ONE"
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.SecurityAndCompliance.Events.SecurityAndComplianceDeviceRecordDeviceChangeEventV2EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}