namespace FeishuNetSdk.Tests.Application.Spec;

/// <summary>
/// 测试 更新应用可用范围 请求体
/// <para>接口ID：6907569745298800642</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/admin/update-the-availability-of-an-app</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fucDN3UjL3QzN14yN0cTN</para>
/// </summary>
[TestClass]
public class Test_PostApplicationV3AppUpdateVisibilityBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "app_id" : "cli_9db45f86b7799104",
    "add_users": [
        {
            "open_id": "ou_d317f090b7258ad0372aa53963cda70d",
            "user_id":"79affdge"
         }
    ],
    "del_users": [
    ],
    "is_visiable_to_all" : 0,
    "add_departments": [
        "od-4b4a6907ad726ea07b27b0d2882b7c65",
        "od-2a0c3396b2cbd9a0befb104eccd1209f"
    ],
    "del_departments": [
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Application.Spec.PostApplicationV3AppUpdateVisibilityBodyDto>(json);
        Assert.IsNotNull(result);
    }
}