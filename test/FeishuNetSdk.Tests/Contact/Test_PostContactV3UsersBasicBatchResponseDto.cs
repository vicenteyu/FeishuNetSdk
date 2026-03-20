namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 通过 ID 获取用户姓名 响应体
/// <para>接口ID：7616208028610694095</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/basic_batch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fbasic_batch</para>
/// </summary>
[TestClass]
public class Test_PostContactV3UsersBasicBatchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "users": [
            {
                "user_id": "ou_b3b46653c99f1f6177a478974bdabb72",
                "name": "张三",
                "i18n_name": {
                    "zh_cn": "张三",
                    "ja_jp": "佐藤はるか",
                    "en_us": "Jason Zhang"
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.PostContactV3UsersBasicBatchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}