// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-08
//
// Last Modified By : yxr
// Last Modified On : 2025-11-08
// ************************************************************************
// <copyright file="Test_PostBoardV1WhiteboardsByWhiteboardIdNodesPlantumlBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 解析画板语法 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Board;

/// <summary>
/// 测试 解析画板语法 请求体
/// <para>接口ID：7567790459344879618</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/board-v1/whiteboard-node/create_plantuml</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fboard-v1%2fwhiteboard-node%2fcreate_plantuml</para>
/// </summary>
[TestClass]
public class Test_PostBoardV1WhiteboardsByWhiteboardIdNodesPlantumlBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "plant_uml_code": "@startuml\nAlice -> Bob: Authentication Request\nBob --> Alice: Authentication Response\n@enduml",
    "style_type": 1,
    "syntax_type": 1,
    "diagram_type": 0
}
""";
        var result = Deserialize<FeishuNetSdk.Board.PostBoardV1WhiteboardsByWhiteboardIdNodesPlantumlBodyDto>(json);
        Assert.IsNotNull(result);
    }
}