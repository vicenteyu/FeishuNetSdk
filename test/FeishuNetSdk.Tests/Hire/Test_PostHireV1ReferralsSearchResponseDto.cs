namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 查询人才内推信息 响应体
/// <para>接口ID：7307160083569704963</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/referral/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ReferralsSearchResponseDto : TestBase
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
                "id": "6930815272790114322",
                "application_ids": [
                    "6930815272790114323"
                ],
                "create_time": "1618899376474",
                "referral_user": {
                    "id": "6930815272790114324",
                    "name": {
                        "zh_cn": "张三",
                        "en_us": "zhangsan"
                    }
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1ReferralsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}