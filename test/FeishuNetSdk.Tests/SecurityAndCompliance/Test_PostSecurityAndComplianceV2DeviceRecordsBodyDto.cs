// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-24
//
// Last Modified By : yxr
// Last Modified On : 2025-10-24
// ************************************************************************
// <copyright file="Test_PostSecurityAndComplianceV2DeviceRecordsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新增设备 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.SecurityAndCompliance;

/// <summary>
/// 测试 新增设备 请求体
/// <para>接口ID：7430737008881614850</para>
/// <para>文档地址：https://open.feishu.cn/document/security_and_compliance-v1/security_and_compliance-v2/device_record/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v2%2fdevice_record%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostSecurityAndComplianceV2DeviceRecordsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "device_system": 1,
    "serial_number": "C02DTHRMML7H",
    "disk_serial_number": "CC344362-5990-5A68-8DDD-64A23C99FA0C",
    "uuid": "621CDFF0-13D0-5AB1-9ADC-5F560095F6ED",
    "device_ownership": 0,
    "device_status": 0,
    "aaid": "ff3c2237-cd76-4331-9d72-0a4470854567",
    "android_id": "02a11ac4a83b918e",
    "idfv": "968F0E5C-C297-4122-ACB6-102494DEFD9A"
}
""";
        var result = Deserialize<FeishuNetSdk.SecurityAndCompliance.PostSecurityAndComplianceV2DeviceRecordsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}