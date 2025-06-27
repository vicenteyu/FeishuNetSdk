// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDriveExplorerV2FileByFolderTokenBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新建文件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 新建文件 请求体
/// <para>接口ID：6907569743419932674</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/create-online-document</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQTNzUjL0UzM14CN1MTN</para>
/// </summary>
[TestClass]
public class Test_PostDriveExplorerV2FileByFolderTokenBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
   "title":"测试表格",
   "type":"sheet"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostDriveExplorerV2FileByFolderTokenBodyDto>(json);
        Assert.IsNotNull(result);
    }
}