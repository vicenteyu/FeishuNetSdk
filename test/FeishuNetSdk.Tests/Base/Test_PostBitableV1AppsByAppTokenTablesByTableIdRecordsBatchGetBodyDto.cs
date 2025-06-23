namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 批量获取记录 请求体
/// <para>接口ID：7386702252390268956</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/bitable-v1/app-table-record/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fbatch_get</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchGetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "record_ids": [
    "recyOaMB2F",
    "rec111111",
    "recyOaMB2F"
  ],
  "user_id_type": "open_id",
  "with_shared_url": true,
  "automatic_fields": true
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchGetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}