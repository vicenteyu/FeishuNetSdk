namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取人才标签信息列表 响应体
/// <para>接口ID：7404770953199714306</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/recruitment-related-configuration/application/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent_tag%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1TalentTagsResponseDto : TestBase
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
                "id": "7023711013443944467",
                "name": {
                    "zh_cn": "985",
                    "en_us": "985"
                },
                "description": {
                    "zh_cn": "985工程，俗称985院校，是指中华人民共和国教育部原为了建设若干所世界一流大学和一批世界著名高水平研究型大学而实施的教育计划",
                    "en_us": "Project 985 was a higher education development and sponsorship scheme of the Chinese central government for creating world-class higher education institutions"
                },
                "type": 1,
                "active_status": 1
            }
        ],
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ=="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1TalentTagsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}