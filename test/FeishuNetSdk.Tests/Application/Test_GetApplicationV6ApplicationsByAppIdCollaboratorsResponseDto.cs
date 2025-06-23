namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 获取应用协作者列表 响应体
/// <para>接口ID：7320225176225087491</para>
/// <para>文档地址：https://open.feishu.cn/document/application-v6/application/get-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-collaborators%2fget</para>
/// </summary>
[TestClass]
public class Test_GetApplicationV6ApplicationsByAppIdCollaboratorsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "collaborators": [
            {
                "type": "administrator",
                "user_id": "ou_d317f090b7258ad0372aa53963cda70d"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Application.GetApplicationV6ApplicationsByAppIdCollaboratorsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}