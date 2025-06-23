namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 查询邮箱地址状态 响应体
/// <para>接口ID：7055500003323379713</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/user/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostMailV1UsersQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "user_list": [
            {
                "email": "aaa@lark.com",
                "status": 4,
                "type": 1
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.PostMailV1UsersQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}