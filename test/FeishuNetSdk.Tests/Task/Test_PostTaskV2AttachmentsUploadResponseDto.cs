namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 上传附件 响应体
/// <para>接口ID：7297183031634460675</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/attachment/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fattachment%2fupload</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2AttachmentsUploadResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
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
                    "role": "creator"
                },
                "is_cover": false,
                "uploaded_at": "1675742789470"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.PostTaskV2AttachmentsUploadResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}