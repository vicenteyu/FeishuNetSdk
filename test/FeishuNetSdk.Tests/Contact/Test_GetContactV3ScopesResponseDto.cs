namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 获取通讯录授权范围 响应体
/// <para>接口ID：7026591401610543108</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/scope/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fscope%2flist</para>
/// </summary>
[TestClass]
public class Test_GetContactV3ScopesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "department_ids": [
            "75217143312g9842"
        ],
        "group_ids": [
            "4bgga762"
        ],
        "has_more": true,
        "page_token": "AQD9/Rn9eij9Pm39ED40/e4EuQbBea/ybCE7/PQ1yzQXAVoq7bxTVC%2BI1oJqeoRY",
        "user_ids": [
            "9b2fabg6"
        ]
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.GetContactV3ScopesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}