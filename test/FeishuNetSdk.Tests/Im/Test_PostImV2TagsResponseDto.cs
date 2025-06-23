namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 创建标签 响应体
/// <para>接口ID：7315032956271280132</para>
/// <para>文档地址：https://open.feishu.cn/document/tenant-tag/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2ftag%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostImV2TagsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "id": "716168xxxxx",
        "create_tag_fail_reason": {
            "duplicate_id": "716168xxxxx"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PostImV2TagsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}