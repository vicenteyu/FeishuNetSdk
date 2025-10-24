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
        "version": "0"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.SecurityAndCompliance.Events.SecurityAndComplianceDeviceRecordDeviceChangeEventV2EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}