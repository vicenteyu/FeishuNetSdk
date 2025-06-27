// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetDocxV1DocumentsByDocumentIdRawContentResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取文档纯文本内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取文档纯文本内容 响应体
/// <para>接口ID：7079983676051013634</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document/raw_content</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument%2fraw_content</para>
/// </summary>
[TestClass]
public class Test_GetDocxV1DocumentsByDocumentIdRawContentResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "content": "云文档\n多人实时协同，插入一切元素。不仅是在线文档，更是强大的创作和互动工具\n云文档：专为协作而生\n"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDocxV1DocumentsByDocumentIdRawContentResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}