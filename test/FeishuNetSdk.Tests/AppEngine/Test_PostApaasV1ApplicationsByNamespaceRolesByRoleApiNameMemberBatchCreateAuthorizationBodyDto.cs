namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 批量创建角色成员授权 请求体
/// <para>接口ID：7417675812785520643</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/permission/application-role-member/batch_create_authorization</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-role-member%2fbatch_create_authorization</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApplicationsByNamespaceRolesByRoleApiNameMemberBatchCreateAuthorizationBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_ids": [
        "1802412778084426"
    ],
    "department_ids": [
        "1802412778084426"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1ApplicationsByNamespaceRolesByRoleApiNameMemberBatchCreateAuthorizationBodyDto>(json);
        Assert.IsNotNull(result);
    }
}