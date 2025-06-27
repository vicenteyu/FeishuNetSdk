// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDriveV1FilesCreateShortcutBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建文件快捷方式 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建文件快捷方式 请求体
/// <para>接口ID：7216001760515112961</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/create_shortcut</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fcreate_shortcut</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesCreateShortcutBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "parent_token": "fldbc5qgwyQnO0uedNllWuabcef",
    "refer_entity": {
        "refer_token": "doxbcGvhSVN0R6octqPwAEabcef",
        "refer_type": "docx"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDriveV1FilesCreateShortcutBodyDto>(json);
        Assert.IsNotNull(result);
    }
}