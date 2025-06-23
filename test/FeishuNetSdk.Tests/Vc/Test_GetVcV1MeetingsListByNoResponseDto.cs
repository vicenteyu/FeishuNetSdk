namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 获取与会议号关联的会议列表 响应体
/// <para>接口ID：7013251669786116097</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting/list_by_no</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2flist_by_no</para>
/// </summary>
[TestClass]
public class Test_GetVcV1MeetingsListByNoResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "has_more": true,
        "meeting_briefs": [
            {
                "id": "7011030664708603907",
                "meeting_no": "146453285",
                "password": "971024",
                "topic": "测试标题"
            },
            {
                "id": "7011031045899354115",
                "meeting_no": "146453285",
                "password": "971024",
                "topic": "测试标题"
            }
        ],
        "page_token": "2"
    },
    "msg": ""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1MeetingsListByNoResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}