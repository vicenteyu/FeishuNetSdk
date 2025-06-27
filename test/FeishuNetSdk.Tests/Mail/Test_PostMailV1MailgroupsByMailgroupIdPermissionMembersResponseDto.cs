// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostMailV1MailgroupsByMailgroupIdPermissionMembersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建邮件组权限成员 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 创建邮件组权限成员 响应体
/// <para>接口ID：6954915601882923011</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-permission_member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-permission_member%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostMailV1MailgroupsByMailgroupIdPermissionMembersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "permission_member_id": "xxxxxxxxxxxxxxx",
        "user_id": "xxxxxxxxxx",
        "department_id": "xxxxxxxxxx",
        "email": "xxx@xx.x",
        "type": "USER"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.PostMailV1MailgroupsByMailgroupIdPermissionMembersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}