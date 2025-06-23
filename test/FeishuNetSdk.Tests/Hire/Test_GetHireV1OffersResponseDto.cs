namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取 Offer 列表 响应体
/// <para>接口ID：7054010541106921473</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/offer/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1OffersResponseDto : TestBase
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
                "id": "7096320678581242123",
                "job_info": {
                    "job_id": "7080891505426925854",
                    "job_name": "xx"
                },
                "create_time": 1628512038000,
                "offer_status": 1,
                "offer_type": 1,
                "employee_type": {
                    "id": "1",
                    "zh_name": "正式",
                    "en_name": "Regular"
                },
                "application_id": "7096358713330272526"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1OffersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}