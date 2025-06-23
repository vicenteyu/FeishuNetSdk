namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 上传进展记录图片 响应体
/// <para>接口ID：7047048928294174722</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/progress_record/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fimage%2fupload</para>
/// </summary>
[TestClass]
public class Test_PostOkrV1ImagesUploadResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "file_token": "boxbcc6DmPfgi4rNXIaGfptc9HX",
        "url": "https://internal-****.cn/stream/api/downloadFile/?file_token=boxbcc6DmPfgi4rNXIaGfptc9HX&ticket=eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJ0YXJnZXRfaWQiOiI3MDQxNTA5NTg4MzkwMzQ2NzcyIiwidGFyZ2V0X3R5cGUiOjEsImFjdGlvbiI6MiwiZmlsZV90b2tlbiI6ImJveGJjYzZEbVBmZ2k0ck5YSWFHZnB0YzlIWCIsInVzZXJfaWQiOiI2OTY5ODU1NTAxNzQ0ODM0MDkyIiwidGVuYW50X2lkIjoiNjg3NzUwMjY4NzYwOTQwNjk5MCIsImV4cCI6MTY0MDY4MzI4OX0.VqOLS7kDtCuhyU_WuWeXvxg1XIyJxskBfNGFQP8uGkCBhYh9scwcbWQJ4xubAZs3cmsrPMVm-aho3tz5d7NT5Q"
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.PostOkrV1ImagesUploadResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}