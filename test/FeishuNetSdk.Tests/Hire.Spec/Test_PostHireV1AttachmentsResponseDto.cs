namespace FeishuNetSdk.Tests.Hire.Spec;

/// <summary>
/// 测试 创建附件 响应体
/// <para>接口ID：6921988678870040577</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/attachment/create_attachment</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDN1YjLyQTN24iM0UjN%2fcreate_attachment</para>
/// </summary>
[TestClass]
public class Test_PostHireV1AttachmentsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "id": "3382901186408483126",
        "name": "test.rar",
        "url": "https://xxx.feishu.cn/hire/file/blob/ZXlKaGJHY2lPaUpJVXpJMU5pS3==/"
    },
    "msg": "OK"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.Spec.PostHireV1AttachmentsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}