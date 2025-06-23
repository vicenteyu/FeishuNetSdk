namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 删除多个数据表 请求体
/// <para>接口ID：6960166873968459779</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table%2fbatch_delete</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenTablesBatchDeleteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "table_ids": [
        "tbl1TkhyTWDkSoZ3"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenTablesBatchDeleteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}