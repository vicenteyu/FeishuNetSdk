namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取项目列表 响应体
/// <para>接口ID：7002055120885202947</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/subject/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fsubject%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1SubjectsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": true,
        "page_token": "1234452132",
        "items": [
            {
                "id": "1213213123123",
                "name": {
                    "zh_cn": "测试",
                    "en_us": "test"
                },
                "create_time": "1628512038000",
                "active_status": 1,
                "application_limit": 1,
                "creator": {
                    "id": "1213213123123",
                    "name": {
                        "zh_cn": "测试",
                        "en_us": "test"
                    }
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1SubjectsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}