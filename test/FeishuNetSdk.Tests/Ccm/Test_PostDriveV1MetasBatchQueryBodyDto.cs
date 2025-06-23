namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取文件元数据 请求体
/// <para>接口ID：7106040876741345308</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmeta%2fbatch_query</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1MetasBatchQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "request_docs": [
        {
            "doc_token": "doccnfYZzTlvXqZIGTdAHKabcef",
            "doc_type": "doc"
        }
    ],
    "with_url": false
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDriveV1MetasBatchQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}