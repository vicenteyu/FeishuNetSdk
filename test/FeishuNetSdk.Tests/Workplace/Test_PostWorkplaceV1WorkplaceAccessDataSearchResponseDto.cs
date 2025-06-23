namespace FeishuNetSdk.Tests.Workplace;

/// <summary>
/// 测试 获取工作台访问数据 响应体
/// <para>接口ID：7244463472595714050</para>
/// <para>文档地址：https://open.feishu.cn/document/workplace-v1/workplace_access_data/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fworkplace-v1%2fworkplace_access_data%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostWorkplaceV1WorkplaceAccessDataSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "date": "2023-03-12",
                "all_workplace": {
                    "pv": 100,
                    "uv": 30
                },
                "default_workplace": {
                    "pv": 100,
                    "uv": 30
                }
            }
        ],
        "has_more": true,
        "page_token": "ddowkdkl9w2d"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Workplace.PostWorkplaceV1WorkplaceAccessDataSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}