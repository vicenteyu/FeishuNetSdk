namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 解绑标签与群 请求体
/// <para>接口ID：7315032956271263748</para>
/// <para>文档地址：https://open.feishu.cn/document/tenant-tag/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fbiz_entity_tag_relation%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutImV2BizEntityTagRelationBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "tag_biz_type": "chat",
    "biz_entity_id": "oc_xxxxx",
    "tag_ids": [
        "7161681111"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PutImV2BizEntityTagRelationBodyDto>(json);
        Assert.IsNotNull(result);
    }
}