namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 更新云文档权限设置 响应体
/// <para>接口ID：6987581166854651905</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-public/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-public%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchDriveV1PermissionsByTokenPublicResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "permission_public": {
            "external_access": true,
            "security_entity": "anyone_can_view",
            "comment_entity": "anyone_can_view",
            "share_entity": "anyone",
            "link_share_entity": "tenant_readable",
            "invite_external": true,
            "lock_switch": false
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PatchDriveV1PermissionsByTokenPublicResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}