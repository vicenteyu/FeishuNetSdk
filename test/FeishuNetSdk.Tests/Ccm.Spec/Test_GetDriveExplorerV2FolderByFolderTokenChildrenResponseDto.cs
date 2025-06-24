// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetDriveExplorerV2FolderByFolderTokenChildrenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取文件夹下的文档清单 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 获取文件夹下的文档清单 响应体
/// <para>接口ID：6907569524100890625</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/folder/get-folder-children</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEjNzUjLxYzM14SM2MTN</para>
/// </summary>
[TestClass]
public class Test_GetDriveExplorerV2FolderByFolderTokenChildrenResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
   "code":0,
   "msg":"Success",
   "data":{
      "parentToken":"token",
      "children":{
         "nodbc9eC8*****UFOq05rLhpjzc":{
            "token":"fldbcRho4*****3mJkOAuPUZR9d",
            "name":"test_folder_name",
            "type":"folder",
            "is_shortcut":false
         },
         "nodbcOjPU*****aVVjRDSw4mpeb":{
            "token":"boxbcj55r*****YAS3C7Z4GWKNg",
            "name":"test_file_name",
            "type":"file",
            "is_shortcut":false
         }
      }
   }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.GetDriveExplorerV2FolderByFolderTokenChildrenResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}