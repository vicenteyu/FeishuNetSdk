namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 通过手机号或邮箱获取用户 ID 响应体
/// <para>接口ID：7026591401610526724</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/batch_get_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fbatch_get_id</para>
/// </summary>
[TestClass]
public class Test_PostContactV3UsersBatchGetIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "user_list": [{
                "user_id": "ou_979112345678741d29069abcdef01234",
                "email": "zhanxxxxx@a.com",
                "status": {
                    "is_frozen": false,
                    "is_resigned": false,
                    "is_activated": true,
                    "is_exited": false,
                    "is_unjoin": false
                }
            }, {
                "user_id": "ou_919112245678741d29069abcdef02345",
                "email": "lisixxxx@a.com",
                "status": {
                    "is_frozen": false,
                    "is_resigned": false,
                    "is_activated": true,
                    "is_exited": false,
                    "is_unjoin": false
                }
            },
            {
                "user_id": "ou_46a087654321a1dc920ffab8fedc3456",
                "mobile": "130xxxx1111",
                "status": {
                    "is_frozen": false,
                    "is_resigned": false,
                    "is_activated": true,
                    "is_exited": false,
                    "is_unjoin": false
                }
            }, {
                "user_id": "ou_01b081675121a1dc920ffab97cdc4567",
                "mobile": "130xxxx2222",
                "status": {
                    "is_frozen": false,
                    "is_resigned": false,
                    "is_activated": true,
                    "is_exited": false,
                    "is_unjoin": false
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.PostContactV3UsersBatchGetIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}