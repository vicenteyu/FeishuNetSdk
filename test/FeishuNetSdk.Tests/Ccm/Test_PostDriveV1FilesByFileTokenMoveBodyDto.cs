// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDriveV1FilesByFileTokenMoveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 移动文件或文件夹 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 移动文件或文件夹 请求体
/// <para>接口ID：7080903916725993474</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/move</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fmove</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesByFileTokenMoveBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "type": "file",
    "folder_token": "fldbcO1UuPz8VwnpPx5a92abcef"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDriveV1FilesByFileTokenMoveBodyDto>(json);
        Assert.IsNotNull(result);
    }
}