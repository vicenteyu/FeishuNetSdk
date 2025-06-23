namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 移除协作者权限 请求体
/// <para>接口ID：6998069547745214492</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-member%2fdelete</para>
/// </summary>
[TestClass]
public class Test_DeleteDriveV1PermissionsByTokenMembersByMemberIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "type": "user",
    "perm_type": "container"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.DeleteDriveV1PermissionsByTokenMembersByMemberIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}