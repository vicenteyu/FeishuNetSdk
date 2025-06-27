// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutMailV1MailgroupsByMailgroupIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 修改邮件组全部信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 修改邮件组全部信息 响应体
/// <para>接口ID：6954915601882791939</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutMailV1MailgroupsByMailgroupIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "mailgroup_id": "xxx",
        "email": "xx@xx.xx",
        "name":"xxx",
        "description":"xxx",
        "direct_members_count":"x",
        "include_external_member": true,
        "include_all_company_member":false,
        "who_can_send_mail":"ANYONE"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.PutMailV1MailgroupsByMailgroupIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}