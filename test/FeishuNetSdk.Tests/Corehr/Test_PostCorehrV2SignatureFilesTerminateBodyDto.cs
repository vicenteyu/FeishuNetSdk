// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="Test_PostCorehrV2SignatureFilesTerminateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 终止电子签文件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 终止电子签文件 请求体
/// <para>接口ID：7420421437193633795</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_file/terminate</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_file%2fterminate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2SignatureFilesTerminateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "ids": [
        "7410063506638112300"
    ],
    "operator": "7386593105085988xxx",
    "terminate_reason": "请求流程发生变化，需要重新签署，因此终止签署流程中的文件"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2SignatureFilesTerminateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}