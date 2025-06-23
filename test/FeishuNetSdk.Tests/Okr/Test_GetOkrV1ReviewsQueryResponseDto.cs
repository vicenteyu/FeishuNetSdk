namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 查询复盘信息 响应体
/// <para>接口ID：7078206296554274820</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/review/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2freview%2fquery</para>
/// </summary>
[TestClass]
public class Test_GetOkrV1ReviewsQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "review_list": [
            {
                "review_period_list": [
                    {
                        "cycle_review_list": [
                            {
                                "create_time": "1646902033525",
                                "url": "https://okr-boe1.feishu-boe.cn/docs/docbcZ4PTuEDd2MBJ9k2W4rOeY1"
                            }
                        ],
                        "period_id": "7067724095781142548",
                        "progress_report_list": [
                            {
                                "create_time": "1646904637251",
                                "url": "https://okr-boe1.feishu-boe.cn/docs/docbcthFL8qo5ENgYW5k3iTLZWf"
                            },
                            {
                                "create_time": "1646902091512",
                                "url": "https://okr-boe1.feishu-boe.cn/docs/docbcRS2NbVRcPfm77W9H4031qb"
                            }
                        ]
                    }
                ],
                "user_id": {
                    "open_id": "ou_e6139117c300506837def50545420c6a",
                    "user_id": "6969855501744834092"
                }
            }
        ]
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.GetOkrV1ReviewsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}