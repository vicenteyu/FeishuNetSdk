namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 更新禁用状态变更通知 请求体
/// <para>接口ID：7211447510368550916</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/scope_config/patch-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve_config-disable_inform%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchVcV1ReserveConfigsByReserveConfigIdDisableInformBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "scope_type": 2,
    "disable_inform": {
        "if_cover_child_scope": true,
        "if_inform": false,
        "informed_users": [
            {
                "user_id": "ou_a27b07a9071d90577c0177bcec98f856"
            }
        ],
        "informed_depts": [
            {
                "department_id": "od-47d8b570b0a011e9679a755efcc5f61a"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PatchVcV1ReserveConfigsByReserveConfigIdDisableInformBodyDto>(json);
        Assert.IsNotNull(result);
    }
}