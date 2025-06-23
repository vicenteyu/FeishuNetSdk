namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建订阅 响应体
/// <para>接口ID：7065964758428483612</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs-assistant/file-subscription/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-subscription%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesByFileTokenSubscriptionsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "file_type": "docx",
        "is_subcribe": true,
        "subscription_id": "xxxxxxx",
        "subscription_type": "comment_update"
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostDriveV1FilesByFileTokenSubscriptionsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}