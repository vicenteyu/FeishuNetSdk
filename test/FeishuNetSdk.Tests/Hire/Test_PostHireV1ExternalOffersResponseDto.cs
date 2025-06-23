namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 创建外部 Offer 响应体
/// <para>接口ID：7407298680640946179</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-offer-info/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_offer%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ExternalOffersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "SUCCESS",
    "data": {
        "external_offer": {
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
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1ExternalOffersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}