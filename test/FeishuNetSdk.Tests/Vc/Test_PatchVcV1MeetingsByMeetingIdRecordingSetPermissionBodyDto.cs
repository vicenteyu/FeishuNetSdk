namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 授权录制文件 请求体
/// <para>接口ID：6960861158129025027</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting-recording/set_permission</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting-recording%2fset_permission</para>
/// </summary>
[TestClass]
public class Test_PatchVcV1MeetingsByMeetingIdRecordingSetPermissionBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "permission_objects": [
        {
            "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
            "type": 1,
            "permission": 1
        }
    ],
    "action_type": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PatchVcV1MeetingsByMeetingIdRecordingSetPermissionBodyDto>(json);
        Assert.IsNotNull(result);
    }
}