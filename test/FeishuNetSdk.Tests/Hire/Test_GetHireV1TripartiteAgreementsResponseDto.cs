namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取三方协议 响应体
/// <para>接口ID：7307160083569672195</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/delivery-process-management/tripartite_agreement/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftripartite_agreement%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1TripartiteAgreementsResponseDto : TestBase
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
                "application_id": "6930815272790114325",
                "state": 1,
                "create_time": "1698292282660",
                "modify_time": "1698292282661"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1TripartiteAgreementsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}