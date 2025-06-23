namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取云文档权限设置 响应体
/// <para>接口ID：7224057619119112196</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-public/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIzNzUjLyczM14iM3MTN%2fdrive-v2%2fpermission-public%2fget</para>
/// </summary>
[TestClass]
public class Test_GetDriveV2PermissionsByTokenPublicResponseDto : TestBase
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
            "external_access_entity": "open",
            "security_entity": "anyone_can_view",
            "comment_entity": "anyone_can_view",
            "share_entity": "anyone",
            "manage_collaborator_entity": "collaborator_can_view",
            "link_share_entity": "tenant_readable",
            "copy_entity": "anyone_can_view",
            "lock_switch": false
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDriveV2PermissionsByTokenPublicResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}