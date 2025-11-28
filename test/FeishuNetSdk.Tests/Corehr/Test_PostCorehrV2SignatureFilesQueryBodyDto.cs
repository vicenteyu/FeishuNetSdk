// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="Test_PostCorehrV2SignatureFilesQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询电子签文件详情 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询电子签文件详情 请求体
/// <para>接口ID：7408897731056500740</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_file/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_file%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2SignatureFilesQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "states": [
        "sign_finished",
        "pending_seal"
    ],
    "template_ids": [
        "7282756156156560940",
        "7282756156156560945"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2SignatureFilesQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}