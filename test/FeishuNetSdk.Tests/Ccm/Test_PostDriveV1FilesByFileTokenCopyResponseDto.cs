// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDriveV1FilesByFileTokenCopyResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 复制文件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 复制文件 响应体
/// <para>接口ID：7087776630140157955</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fcopy</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesByFileTokenCopyResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "file": {
            "name": "Demo copy",
            "parent_token": "fldcnBh8LrnX42dr1pBYclabcef",
            "token": "doxcnUkUOWtOelpFcha2Z9abcef",
            "type": "docx",
            "url": "https://feishu.cn/docx/doxcnUkUOWtOelpFcha2Zabcef"
        }
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostDriveV1FilesByFileTokenCopyResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}