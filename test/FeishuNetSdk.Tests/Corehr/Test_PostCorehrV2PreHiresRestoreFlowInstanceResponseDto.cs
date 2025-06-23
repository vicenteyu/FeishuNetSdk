namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 恢复入职 响应体
/// <para>接口ID：7450056310967681026</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/pre_hire/restore_flow_instance</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2frestore_flow_instance</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PreHiresRestoreFlowInstanceResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "success": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2PreHiresRestoreFlowInstanceResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}