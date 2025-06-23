namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 判断协作者是否有某权限 请求体
/// <para>接口ID：6907569524101087233</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/permission/querying-if-a-collaborator-has-a-specific-permission</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYzN3UjL2czN14iN3cTN</para>
/// </summary>
[TestClass]
public class Test_PostDrivePermissionMemberPermittedBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "token": "doccnBKgoMyY5OMbUG6FioTXuBe",
    "type": "doc",
     "perm": "string"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostDrivePermissionMemberPermittedBodyDto>(json);
        Assert.IsNotNull(result);
    }
}