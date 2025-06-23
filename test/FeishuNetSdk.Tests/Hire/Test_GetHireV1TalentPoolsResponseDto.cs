namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取人才库列表 响应体
/// <para>接口ID：7218853190452428804</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent_pool/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent_pool%2fsearch</para>
/// </summary>
[TestClass]
public class Test_GetHireV1TalentPoolsResponseDto : TestBase
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
                "id": "6930815272790114324",
                "i18n_name": {
                    "zh_cn": "公共人才库",
                    "en_us": "Common Talent Pool"
                },
                "i18n_description": {
                    "zh_cn": "储备企业内公开可见的人才",
                    "en_us": "The talent pool is visible to all company members"
                },
                "parent_id": "6930815272790114324",
                "is_private": 1,
                "create_time": "1679300424000",
                "modify_time": "1679300424000"
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1TalentPoolsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}