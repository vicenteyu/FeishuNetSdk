// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostContactV3UsersByUserIdResurrectBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 恢复已删除用户 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 恢复已删除用户 请求体
/// <para>接口ID：7122710137048399875</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/resurrect</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fresurrect</para>
/// </summary>
[TestClass]
public class Test_PostContactV3UsersByUserIdResurrectBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "departments": [
        {
            "department_id": "od-4e6ac4d14bcd5071a37a39de902c7141",
            "user_order": 0,
            "department_order": 0
        }
    ],
    "subscription_ids": [
        "23213213213123123"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PostContactV3UsersByUserIdResurrectBodyDto>(json);
        Assert.IsNotNull(result);
    }
}