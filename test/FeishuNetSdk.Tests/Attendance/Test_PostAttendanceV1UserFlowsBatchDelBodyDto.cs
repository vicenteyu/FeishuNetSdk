namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 删除打卡流水 请求体
/// <para>接口ID：7473096091899805715</para>
/// <para>文档地址：https://open.feishu.cn/document/attendance-v1/user_task/batch_del</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_flow%2fbatch_del</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserFlowsBatchDelBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "record_ids": [
        "6709359313699356941"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PostAttendanceV1UserFlowsBatchDelBodyDto>(json);
        Assert.IsNotNull(result);
    }
}