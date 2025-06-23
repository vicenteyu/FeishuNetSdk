namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询编制规划方案 响应体
/// <para>接口ID：7314710843818508289</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/workforce_plan/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fworkforce_plan%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2WorkforcePlansResponseDto : TestBase
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
                "workforce_plan_id": "123456",
                "workforce_plan_name": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "start_date": "2020-10-01",
                "end_date": "2020-10-31",
                "active": true
            }
        ],
        "total": 100
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2WorkforcePlansResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}