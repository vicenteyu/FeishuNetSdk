namespace FeishuNetSdk.Tests.Workplace;

/// <summary>
/// 测试 获取定制工作台访问数据 响应体
/// <para>接口ID：7244463472595697666</para>
/// <para>文档地址：https://open.feishu.cn/document/workplace-v1/workplace_access_data/search-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fworkplace-v1%2fcustom_workplace_access_data%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostWorkplaceV1CustomWorkplaceAccessDataSearchResponseDto : TestBase
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
                "custom_workplace_id": "tpl_645b003aaa40001435b2ddw",
                "access_data": {
                    "pv": 100,
                    "uv": 30
                },
                "date": "2023-03-12",
                "custom_workplace_name": [
                    {
                        "language": "zh",
                        "name": "名字"
                    }
                ]
            }
        ],
        "has_more": true,
        "page_token": "ddowkdkl9w2d"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Workplace.PostWorkplaceV1CustomWorkplaceAccessDataSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}