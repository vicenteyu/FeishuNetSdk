// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAttendanceV1UserFlowsBatchCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 导入打卡流水 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 导入打卡流水 请求体
/// <para>接口ID：7044467124773437441</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_flow%2fbatch_create</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserFlowsBatchCreateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "flow_records": [
        {
            "user_id": "abd754f7",
            "creator_id": "abd754f7",
            "location_name": "西溪八方城",
            "check_time": "1611476284",
            "comment": "上班打卡",
            "record_id": "6709359313699356941",
            "ssid": "b0:b8:67:5c:1d:72",
            "bssid": "b0:b8:67:5c:1d:72",
            "is_field": true,
            "is_wifi": true,
            "type": 7,
            "photo_urls": [
                "https://time.clockin.biz/manage/download/6840389754748502021"
            ],
            "device_id": "99e0609ee053448596502691a81428654d7ded64c7bd85acd982d26b3636c37d",
            "check_result": "Invalid",
            "external_id": "record_123",
            "idempotent_id": "****_***"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PostAttendanceV1UserFlowsBatchCreateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}