namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取附件 PDF 格式下载链接 响应体
/// <para>接口ID：6964631863168647171</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/attachment/preview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fattachment%2fpreview</para>
/// </summary>
[TestClass]
public class Test_GetHireV1AttachmentsByAttachmentIdPreviewResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "url": "https://xxx.feishu.cn/hire/file/blob/ZXlKaGJHY2lPaUpJVXpJMU5pS3==/"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1AttachmentsByAttachmentIdPreviewResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}