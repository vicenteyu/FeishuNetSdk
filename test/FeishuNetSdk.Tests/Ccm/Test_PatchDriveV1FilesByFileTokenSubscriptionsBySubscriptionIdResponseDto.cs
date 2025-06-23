namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 更新订阅状态 响应体
/// <para>接口ID：7065964758428499996</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs-assistant/file-subscription/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-subscription%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchDriveV1FilesByFileTokenSubscriptionsBySubscriptionIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "subscription_id": "1234567890987654321",
        "subscription_type": "comment_update",
        "is_subcribe": true,
        "file_type": "docx"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PatchDriveV1FilesByFileTokenSubscriptionsBySubscriptionIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}