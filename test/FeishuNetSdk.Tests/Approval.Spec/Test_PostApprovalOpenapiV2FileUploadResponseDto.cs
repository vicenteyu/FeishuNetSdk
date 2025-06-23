namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 上传文件 响应体
/// <para>接口ID：6907569745298767874</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/file/upload-files</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDOyUjL1gjM14SN4ITN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV2FileUploadResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"success",
    "data": {
        "code": "D93653C3-2609-4EE0-8041-61DC1D84F0B5",
        "url": "https://example.com/lark-approval-attachment/image/20210819/a8c1a1f1-47ae-4147-9deb-a8bf2c1234.jpg~image.image?x-expires=1634941234&x-signature=1234Tfv50ryUesNwKTUTnBlJivY%3D#.jpg"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV2FileUploadResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}