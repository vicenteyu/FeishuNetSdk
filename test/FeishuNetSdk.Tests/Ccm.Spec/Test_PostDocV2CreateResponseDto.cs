// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDocV2CreateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建旧版文档 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 创建旧版文档 响应体
/// <para>接口ID：6908984614439829506</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docs/apiRef/create-document</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugDM2YjL4AjN24COwYjN</para>
/// </summary>
[TestClass]
public class Test_PostDocV2CreateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "objToken": "doccn2EwbGEdcmryBvKzk0loaCd",
        "url": "https://xxx.feishu.cn/docs/doccn2EwbGEdcmryBvKzk0loaCd"
    },
    "msg": "Success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PostDocV2CreateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}