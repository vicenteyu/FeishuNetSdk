namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询当前生效信息发生变更的职级 响应体
/// <para>接口ID：7452973109948612610</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job_level/query_recent_change</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_level%2fquery_recent_change</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2JobLevelsQueryRecentChangeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "job_level_ids": [
            "7094136522860922111"
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true,
        "deleted_job_level_ids": [
            "7094136522860922111"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2JobLevelsQueryRecentChangeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}