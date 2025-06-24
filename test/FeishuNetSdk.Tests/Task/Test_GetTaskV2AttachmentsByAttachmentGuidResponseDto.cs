// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetTaskV2AttachmentsByAttachmentGuidResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取附件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 获取附件 响应体
/// <para>接口ID：7297183031634493443</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/attachment/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fattachment%2fget</para>
/// </summary>
[TestClass]
public class Test_GetTaskV2AttachmentsByAttachmentGuidResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "attachment": {
            "guid": "f860de3e-6881-4ddd-9321-070f36d1af0b",
            "file_token": "boxcnTDqPaRA6JbYnzQsZ2doB2b",
            "name": "foo.jpg",
            "size": 62232,
            "resource": {
                "type": "task",
                "id": "e6e37dcc-f75a-5936-f589-12fb4b5c80c2"
            },
            "uploader": {
                "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
                "type": "user",
                "role": "editor"
            },
            "is_cover": false,
            "uploaded_at": "1675742789470",
            "url": "https://example.com/download/authcode/?code=OWMzNDlmMjJmZThkYzZkZGJlMjYwZTI0OTUxZTE2MDJfMDZmZmMwOWVj"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.GetTaskV2AttachmentsByAttachmentGuidResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}