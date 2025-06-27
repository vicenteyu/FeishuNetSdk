// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSuiteDocsApiMetaBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取元数据 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 获取元数据 请求体
/// <para>接口ID：6907569743420637186</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/file/obtain-metadata</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMjN3UjLzYzN14yM2cTN</para>
/// </summary>
[TestClass]
public class Test_PostSuiteDocsApiMetaBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "request_docs": [
        {
            "docs_token": "12345",
            "docs_type": "doc"
        },  
        {
            "docs_token": "12345",
            "docs_type": "sheet"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostSuiteDocsApiMetaBodyDto>(json);
        Assert.IsNotNull(result);
    }
}