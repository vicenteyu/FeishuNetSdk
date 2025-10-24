// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-24
//
// Last Modified By : yxr
// Last Modified On : 2025-10-24
// ************************************************************************
// <copyright file="Test_GetSecurityAndComplianceV2DeviceRecordsMineResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取客户端设备认证信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.SecurityAndCompliance;

/// <summary>
/// 测试 获取客户端设备认证信息 响应体
/// <para>接口ID：7563551656446263298</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/security_and_compliance-v2/device_record/mine</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v2%2fdevice_record%2fmine</para>
/// </summary>
[TestClass]
public class Test_GetSecurityAndComplianceV2DeviceRecordsMineResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "device_record_id": "7089353870308032531",
        "device_ownership": 0,
        "device_status": 0
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.SecurityAndCompliance.GetSecurityAndComplianceV2DeviceRecordsMineResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}