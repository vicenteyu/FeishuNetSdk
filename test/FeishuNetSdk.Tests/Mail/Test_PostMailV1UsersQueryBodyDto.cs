// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostMailV1UsersQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询邮箱地址状态 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 查询邮箱地址状态 请求体
/// <para>接口ID：7055500003323379713</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/user/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostMailV1UsersQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "email_list": [
        "test@a.com"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1UsersQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}