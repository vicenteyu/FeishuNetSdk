namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 查询外部 Offer 列表 响应体
/// <para>接口ID：7407298680641060867</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-offer-info/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_offer%2fbatch_query</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ExternalOffersBatchQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "SUCCESS",
    "data": {
        "items": [
            {
                "id": "6989202908470446380",
                "external_application_id": "7395015673275697419",
                "biz_create_time": "1721899352428",
                "owner": "张三",
                "offer_status": "已发送",
                "attachment_list": [
                    {
                        "id": "6987954043925432620",
                        "name": "test_resume.pdf",
                        "size": 126371
                    }
                ]
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1ExternalOffersBatchQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}