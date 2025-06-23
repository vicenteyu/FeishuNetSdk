namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 新增多个数据表 请求体
/// <para>接口ID：6960166873968558083</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table%2fbatch_create</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenTablesBatchCreateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "tables": [
        {
            "name": "一个新的数据表"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenTablesBatchCreateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}