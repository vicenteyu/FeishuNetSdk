namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 更新用户被授权的数据范围 请求体
/// <para>接口ID：7361618338575810588</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/authorization/update_role_assign</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fauthorization%2fupdate_role_assign</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1AuthorizationsUpdateRoleAssignBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "assigned_organization_items": [
        [
            {
                "org_key": "department",
                "org_ids": [
                    "1"
                ],
                "org_codes": [
                    "D01"
                ]
            }
        ]
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1AuthorizationsUpdateRoleAssignBodyDto>(json);
        Assert.IsNotNull(result);
    }
}