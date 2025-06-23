namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 更新多维表格元数据 响应体
/// <para>接口ID：7073673019918811164</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutBitableV1AppsByAppTokenResponseDto : TestBase
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
            "app_token": "appbcbWCzen6D8dezhoCH2RpMAh",
            "name": "新的多维表格名字",
            "is_advanced": true
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.PutBitableV1AppsByAppTokenResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}