namespace FeishuNetSdk.Tests.Acs.Spec;

/// <summary>
/// 测试 修改用户部分信息 请求体
/// <para>接口ID：6979790924691963906</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/acs-v1/user/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2fuser%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchAcsV1UsersByUserIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "feature": {
        "card": 123456
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Acs.Spec.PatchAcsV1UsersByUserIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}