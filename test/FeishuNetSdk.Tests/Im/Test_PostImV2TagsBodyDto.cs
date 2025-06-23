namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 创建标签 请求体
/// <para>接口ID：7315032956271280132</para>
/// <para>文档地址：https://open.feishu.cn/document/tenant-tag/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2ftag%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostImV2TagsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "create_tag": {
        "tag_type": "tenant",
        "name": "default name",
        "i18n_names": [
            {
                "locale": "zh_cn",
                "name": "标签1"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV2TagsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}