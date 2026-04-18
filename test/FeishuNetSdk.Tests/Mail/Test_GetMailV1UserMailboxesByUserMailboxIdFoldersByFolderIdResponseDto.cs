// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="Test_GetMailV1UserMailboxesByUserMailboxIdFoldersByFolderIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取邮箱文件信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 获取邮箱文件信息 响应体
/// <para>接口ID：7620478754624375740</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-folder/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-folder%2fget</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdFoldersByFolderIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "folder": {
            "id": "7620095646711680541",
            "name": "newsletter 相关",
            "parent_folder_id": "725627422334644",
            "folder_type": 1,
            "unread_message_count": 3,
            "unread_thread_count": 4
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdFoldersByFolderIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}