// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-19
//
// Last Modified By : yxr
// Last Modified On : 2025-09-19
// ************************************************************************
// <copyright file="Test_PostBoardV1WhiteboardsByWhiteboardIdNodesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建节点 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Board;

/// <summary>
/// 测试 创建节点 响应体
/// <para>接口ID：7545367804831629314</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/board-v1/whiteboard-node/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fboard-v1%2fwhiteboard-node%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostBoardV1WhiteboardsByWhiteboardIdNodesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "ids": [
            "o2:27",
            "a2:4",
            "c2:10",
            "t2:8",
            "n2:4",
            "o2:28"
        ],
        "client_token": "fe599b60-450f-46ff-b2ef-9f6675625b97"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Board.PostBoardV1WhiteboardsByWhiteboardIdNodesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}