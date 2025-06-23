namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 为用户授权角色 请求体
/// <para>接口ID：7361618338575794204</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/authorization/add_role_assign</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fauthorization%2fadd_role_assign</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1AuthorizationsAddRoleAssignBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "assigned_organization_items": [
        [
            {
                "org_ids": [
                    "7308575143963297322",
                    "7308575143963297324"
                ],
                "org_key": "department"
            },
            {
                "org_ids": [
                    "7170288739942352223",
                    "7170288739942351193"
                ],
                "org_key": "work_location"
            }
        ],
        [
            {
                "org_codes": [
                    "D01",
                    "D02"
                ],
                "org_key": "department"
            },
            {
                "org_codes": [
                    "W01",
                    "W02"
                ],
                "org_key": "work_location"
            }
        ]
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1AuthorizationsAddRoleAssignBodyDto>(json);
        Assert.IsNotNull(result);
    }
}