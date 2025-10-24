// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-24
//
// Last Modified By : yxr
// Last Modified On : 2025-10-24
// ************************************************************************
// <copyright file="Test_PutSecurityAndComplianceV2DeviceApplyRecordsByDeviceApplyRecordIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 审批设备申报 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.SecurityAndCompliance;

/// <summary>
/// 测试 审批设备申报 请求体
/// <para>接口ID：7430737008881582082</para>
/// <para>文档地址：https://open.feishu.cn/document/security_and_compliance-v1/security_and_compliance-v2/device_apply_record/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v2%2fdevice_apply_record%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutSecurityAndComplianceV2DeviceApplyRecordsByDeviceApplyRecordIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "is_approved": true
}
""";
        var result = Deserialize<FeishuNetSdk.SecurityAndCompliance.PutSecurityAndComplianceV2DeviceApplyRecordsByDeviceApplyRecordIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}