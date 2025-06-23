namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 上传文件 响应体
/// <para>接口ID：6946222931479461889</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/file/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2ffile%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostImV1FilesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "file_key": "file_456a92d6-c6ea-4de4-ac3f-7afcf44ac78g"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PostImV1FilesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}