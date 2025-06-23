namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取职位类别列表 响应体
/// <para>接口ID：7287407243900895234</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/recruitment-related-configuration/job/list-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_type%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1JobTypesResponseDto : TestBase
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
                "name": {
                    "zh_cn": "金融",
                    "en_us": "finance"
                },
                "parent_id": "6930815272790114323"
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1JobTypesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}