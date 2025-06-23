namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询当前生效信息变更的自定义组织 响应体
/// <para>接口ID：7458122701110624275</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/custom_org/query_recent_change</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcustom_org%2fquery_recent_change</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2CustomOrgsQueryRecentChangeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "custom_org_ids": [
            "7094136522860922111"
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true,
        "deleted_custom_org_ids": [
            "7094136522860922111"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2CustomOrgsQueryRecentChangeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}