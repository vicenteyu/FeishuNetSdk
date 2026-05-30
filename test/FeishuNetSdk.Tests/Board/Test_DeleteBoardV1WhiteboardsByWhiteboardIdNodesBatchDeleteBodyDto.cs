// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-30
//
// Last Modified By : yxr
// Last Modified On : 2026-05-29
// ************************************************************************
// <copyright file="Test_DeleteBoardV1WhiteboardsByWhiteboardIdNodesBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量删除节点 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Board;

/// <summary>
/// 测试 批量删除节点 请求体
/// <para>接口ID：7642261728186174667</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/board-v1/whiteboard-node/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fboard-v1%2fwhiteboard-node%2fbatch_delete</para>
/// </summary>
[TestClass]
public class Test_DeleteBoardV1WhiteboardsByWhiteboardIdNodesBatchDeleteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "ids": [
        "o1:1"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Board.DeleteBoardV1WhiteboardsByWhiteboardIdNodesBatchDeleteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}