// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetDriveExplorerV2RootFolderMetaResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取我的空间（root folder）元数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 获取我的空间（root folder）元数据 响应体
/// <para>接口ID：6979502797244170243</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/folder/get-root-folder-meta</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugTNzUjL4UzM14CO1MTN%2fget-root-folder-meta</para>
/// </summary>
[TestClass]
public class Test_GetDriveExplorerV2RootFolderMetaResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "code": 0,
  "msg": "Success",
  "data": {
    "token": "nodbcbHUdOsS613xVzTzFEabcef",
    "id": "7110173013420512356",
    "user_id": "7103496998321312356"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.GetDriveExplorerV2RootFolderMetaResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}