// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDriveExplorerV2FolderByFolderTokenBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新建文件夹 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 新建文件夹 请求体
/// <para>接口ID：6907569745299750914</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/folder/create-a-new-folder</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukTNzUjL5UzM14SO1MTN</para>
/// </summary>
[TestClass]
public class Test_PostDriveExplorerV2FolderByFolderTokenBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "title": "string"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostDriveExplorerV2FolderByFolderTokenBodyDto>(json);
        Assert.IsNotNull(result);
    }
}