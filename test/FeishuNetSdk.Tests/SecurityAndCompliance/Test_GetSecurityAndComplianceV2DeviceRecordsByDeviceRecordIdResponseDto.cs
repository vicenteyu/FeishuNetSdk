// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-24
//
// Last Modified By : yxr
// Last Modified On : 2025-10-24
// ************************************************************************
// <copyright file="Test_GetSecurityAndComplianceV2DeviceRecordsByDeviceRecordIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取设备信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.SecurityAndCompliance;

/// <summary>
/// 测试 获取设备信息 响应体
/// <para>接口ID：7430737008881647618</para>
/// <para>文档地址：https://open.feishu.cn/document/security_and_compliance-v1/security_and_compliance-v2/device_record/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v2%2fdevice_record%2fget</para>
/// </summary>
[TestClass]
public class Test_GetSecurityAndComplianceV2DeviceRecordsByDeviceRecordIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "device_record": {
            "device_record_id": "7089353870308032531",
            "version": "0",
            "current_user_id": "ou_b25e90585ef8c1adac4b379c2e257906",
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
            "latest_user_id": "ou_b25e90585ef8c1adac4b379c2e257906",
            "dids": [
                "7089353870308032531"
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.SecurityAndCompliance.GetSecurityAndComplianceV2DeviceRecordsByDeviceRecordIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}