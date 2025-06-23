namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 批量添加用户组成员 响应体
/// <para>接口ID：7106501358249852931</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group-member/batch_add</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup-member%2fbatch_add</para>
/// </summary>
[TestClass]
public class Test_PostContactV3GroupByGroupIdMemberBatchAddResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "results": [
            {
                "member_id": "u287xj12",
                "code": 0
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.PostContactV3GroupByGroupIdMemberBatchAddResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}