// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetDocxV1DocumentsByDocumentIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取文档基本信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取文档基本信息 响应体
/// <para>接口ID：7068199542315302940</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument%2fget</para>
/// </summary>
[TestClass]
public class Test_GetDocxV1DocumentsByDocumentIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "document": {
            "document_id": "doxcni6mOy7jLRWbEylaKKabcef",
            "revision_id": 1,
            "title": "title",
            "cover": {
                "token": "D6d9bkdH7onNylxKyvucm8abcef",
                "offset_ratio_x": 0,
                "offset_ratio_y": 0
            },
            "display_setting": {
                "show_authors": true,
                "show_comment_count": false,
                "show_create_time": true,
                "show_like_count": false,
                "show_pv": false,
                "show_uv": false
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDocxV1DocumentsByDocumentIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}