namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 获取云文档权限设置V2 响应体
/// <para>接口ID：6907569524099940353</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/permission/get-document-sharing-settings-v2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuITM3YjLyEzN24iMxcjN</para>
/// </summary>
[TestClass]
public class Test_PostDrivePermissionV2PublicResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "security_entity": "anyone_can_view",
        "comment_entity": "anyone_can_view",
        "share_entity":"only_me",
        "link_share_entity":"tenant_editable",
        "external_access":false,
        "invite_external":false，
        "permission_version":"1024",
    },
    "msg": "Success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PostDrivePermissionV2PublicResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}