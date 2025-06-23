namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 上传文件 响应体
/// <para>接口ID：7076346346946543644</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/person/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fperson%2fupload</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1PersonsUploadResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "id": "100"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PostCorehrV1PersonsUploadResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}