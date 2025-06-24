// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchMailV1UserMailboxesByUserMailboxIdFoldersByFolderIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 修改邮箱文件夹 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 修改邮箱文件夹 请求体
/// <para>接口ID：7275929163676205059</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-folder/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-folder%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchMailV1UserMailboxesByUserMailboxIdFoldersByFolderIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "newsletter 相关",
    "parent_folder_id": "725627422334644"
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PatchMailV1UserMailboxesByUserMailboxIdFoldersByFolderIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}