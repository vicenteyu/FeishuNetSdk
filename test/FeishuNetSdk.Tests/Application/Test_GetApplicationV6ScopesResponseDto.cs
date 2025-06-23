namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 查询租户授权状态 响应体
/// <para>接口ID：7406972061036445700</para>
/// <para>文档地址：https://open.feishu.cn/document/application-v6/scope/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fscope%2flist</para>
/// </summary>
[TestClass]
public class Test_GetApplicationV6ScopesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "scopes": [
            {
                "scope_name": "user.phone:readonly",
                "grant_status": 1
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Application.GetApplicationV6ScopesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}