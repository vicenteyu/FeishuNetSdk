namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 查询席位分配详情 响应体
/// <para>接口ID：7452929418211344412</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/seat_assignment/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fseat_assignment%2flist</para>
/// </summary>
[TestClass]
public class Test_GetApaasV1SeatAssignmentsResponseDto : TestBase
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
                "user_id": 1803710089388154,
                "namespace": "package_35f605__c",
                "status": "in_use"
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.GetApaasV1SeatAssignmentsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}