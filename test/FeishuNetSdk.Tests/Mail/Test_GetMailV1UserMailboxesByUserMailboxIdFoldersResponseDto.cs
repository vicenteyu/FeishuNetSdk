namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 列出邮箱文件夹 响应体
/// <para>接口ID：7275929163676123139</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-folder/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-folder%2flist</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdFoldersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "id": "12314123123123123",
                "name": "newsletter 相关",
                "parent_folder_id": "725627422334644",
                "folder_type": 1,
                "unread_message_count": 3,
                "unread_thread_count": 4
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdFoldersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}