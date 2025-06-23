namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 转移拥有者 请求体
/// <para>接口ID：6907569744329719809</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/permission/transfer-ownership</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQzNzUjL0czM14CN3MTN</para>
/// </summary>
[TestClass]
public class Test_PostDrivePermissionMemberTransferBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "type": "string", // "doc" or "sheet" or "file",
    "token": "string",
    "owner": {  
         "member_type": "openid",
         "member_id": "string"
    },
   "remove_old_owner": false,
   "cancel_notify": false
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostDrivePermissionMemberTransferBodyDto>(json);
        Assert.IsNotNull(result);
    }
}