namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 ID 转换 响应体
/// <para>接口ID：7338765273649348612</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/common_data-id/convert</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcommon_data-id%2fconvert</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1CommonDataIdConvertResponseDto : TestBase
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
                "id": "7224321696097404460",
                "target_id": "7224321696097404461"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PostCorehrV1CommonDataIdConvertResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}