namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 获取多维表格元数据 响应体
/// <para>接口ID：6960166873968574467</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp%2fget</para>
/// </summary>
[TestClass]
public class Test_GetBitableV1AppsByAppTokenResponseDto : TestBase
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
            "name": "mybase",
            "revision": 1,
            "is_advanced": false,
            "time_zone": "Asia/Beijing",
            "formula_type": 1,
            "advance_version": "v1"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.GetBitableV1AppsByAppTokenResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}