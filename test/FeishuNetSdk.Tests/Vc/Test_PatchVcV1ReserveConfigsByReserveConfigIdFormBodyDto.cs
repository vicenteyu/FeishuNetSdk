namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 更新会议室预定表单 请求体
/// <para>接口ID：7194790671877160962</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/scope_config/patch-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve_config-form%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchVcV1ReserveConfigsByReserveConfigIdFormBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "scope_type": 2,
    "reserve_form_config": {
        "if_cover_child_scope": true,
        "reserve_form": false,
        "notified_users": [
            {
                "user_id": "ou_a27b07a9071d90577c0177bcec98f856"
            }
        ],
        "notified_time": 3,
        "time_unit": 3
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PatchVcV1ReserveConfigsByReserveConfigIdFormBodyDto>(json);
        Assert.IsNotNull(result);
    }
}