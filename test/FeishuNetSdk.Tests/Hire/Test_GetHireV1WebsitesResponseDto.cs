namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取招聘官网列表 响应体
/// <para>接口ID：6990661791098699779</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1WebsitesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "items": [
            {
                "id": "1213213123123",
                "name": {
                    "zh_cn": "校招官网",
                    "en_us": "campus recruitment site"
                },
                "process_type_list": [
                    2
                ],
                "job_channel_id": "1213213123123"
            }
        ],
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ=="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1WebsitesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}