namespace FeishuNetSdk.Tests.Workplace;

/// <summary>
/// 测试 获取定制工作台小组件访问数据 响应体
/// <para>接口ID：7244463472595681282</para>
/// <para>文档地址：https://open.feishu.cn/document/workplace-v1/workplace_access_data/search-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fworkplace-v1%2fworkplace_block_access_data%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostWorkplaceV1WorkplaceBlockAccessDataSearchResponseDto : TestBase
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
                "block_id": "283438293839422334",
                "access_data": {
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Workplace.PostWorkplaceV1WorkplaceBlockAccessDataSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}