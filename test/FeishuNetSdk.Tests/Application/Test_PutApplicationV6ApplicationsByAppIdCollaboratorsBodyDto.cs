namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 更新应用协作者 请求体
/// <para>接口ID：7320160200451686403</para>
/// <para>文档地址：https://open.feishu.cn/document/application-v6/application/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-collaborators%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutApplicationV6ApplicationsByAppIdCollaboratorsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "adds": [
        {
            "type": "administrator",
            "user_id": "ou_d317f090b7258ad0372aa53963cda70d"
        }
    ],
    "removes": [
        "ou_84aad35d084aa403a838cf73ee18467"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Application.PutApplicationV6ApplicationsByAppIdCollaboratorsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}