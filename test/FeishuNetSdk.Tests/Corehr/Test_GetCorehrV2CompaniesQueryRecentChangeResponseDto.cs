namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询当前生效信息变更公司 响应体
/// <para>接口ID：7428129573351817220</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/company/query_recent_change</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcompany%2fquery_recent_change</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2CompaniesQueryRecentChangeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "company_ids": [
            "7094136522860922111"
        ],
        "page_token": "7094136522860922111",
        "has_more": true,
        "deleted_company_ids": [
            "7094136522860922111"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2CompaniesQueryRecentChangeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}