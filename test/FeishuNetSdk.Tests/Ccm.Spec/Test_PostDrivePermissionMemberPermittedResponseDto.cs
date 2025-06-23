namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 判断协作者是否有某权限 响应体
/// <para>接口ID：6907569524101087233</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/permission/querying-if-a-collaborator-has-a-specific-permission</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYzN3UjL2czN14iN3cTN</para>
/// </summary>
[TestClass]
public class Test_PostDrivePermissionMemberPermittedResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "Success",
    "data": {
        "is_permitted": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PostDrivePermissionMemberPermittedResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}