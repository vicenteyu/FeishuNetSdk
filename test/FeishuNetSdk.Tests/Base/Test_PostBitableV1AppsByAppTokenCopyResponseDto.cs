namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 复制多维表格 响应体
/// <para>接口ID：7205776220394160156</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp%2fcopy</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenCopyResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "app": {
            "app_token": "S404b*****e9PQsYDWYcNryFn0g",
            "name": "一篇新的多维表格",
            "folder_token": "fldbco*****CIMltVc",
            "url": "https://example.feishu.cn/base/S404b*****e9PQsYDWYcNryFn0g",
            "time_zone": ""
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenCopyResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}