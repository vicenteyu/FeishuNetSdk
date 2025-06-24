namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 新增记录 响应体
/// <para>接口ID：6952707657162522626</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenTablesByTableIdRecordsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "code": 0,
  "data": {
    "record": {
      "fields": {
        "任务名称": "维护客户关系",
        "创建日期": 1674206443000,
        "截止日期": 1674206443000
      },
      "record_id": "recusutYZm4ulo"
    }
  },
  "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}