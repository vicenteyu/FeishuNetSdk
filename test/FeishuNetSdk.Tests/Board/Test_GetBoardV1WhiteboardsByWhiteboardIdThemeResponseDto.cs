// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-19
//
// Last Modified By : yxr
// Last Modified On : 2025-09-19
// ************************************************************************
// <copyright file="Test_GetBoardV1WhiteboardsByWhiteboardIdThemeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取画板主题 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Board;

/// <summary>
/// 测试 获取画板主题 响应体
/// <para>接口ID：7545367804831612930</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/board-v1/whiteboard/theme</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fboard-v1%2fwhiteboard%2ftheme</para>
/// </summary>
[TestClass]
public class Test_GetBoardV1WhiteboardsByWhiteboardIdThemeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "theme": "classic"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Board.GetBoardV1WhiteboardsByWhiteboardIdThemeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}