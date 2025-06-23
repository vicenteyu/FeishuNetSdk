namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取投递列表 响应体
/// <para>接口ID：6964286393804865564</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1ApplicationsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "items": [
            "7395810933768997130"
        ],
        "page_token": "1721899407885_7395497752245422387",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1ApplicationsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}