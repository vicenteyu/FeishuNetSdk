// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-29
//
// Last Modified By : yxr
// Last Modified On : 2025-10-29
// ************************************************************************
// <copyright file="Test_PostBoardV1WhiteboardsByWhiteboardIdUpdateThemeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新画板主题 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Board;

/// <summary>
/// 测试 更新画板主题 请求体
/// <para>接口ID：7566200424774680595</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/board-v1/whiteboard/update_theme</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fboard-v1%2fwhiteboard%2fupdate_theme</para>
/// </summary>
[TestClass]
public class Test_PostBoardV1WhiteboardsByWhiteboardIdUpdateThemeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "theme": "classic"
}
""";
        var result = Deserialize<FeishuNetSdk.Board.PostBoardV1WhiteboardsByWhiteboardIdUpdateThemeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}