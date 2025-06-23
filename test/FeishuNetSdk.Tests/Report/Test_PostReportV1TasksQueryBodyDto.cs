namespace FeishuNetSdk.Tests.Report;

/// <summary>
/// 测试 查询任务 请求体
/// <para>接口ID：6969187588792369180</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/report-v1/task/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2freport%2freport-v1%2ftask%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostReportV1TasksQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "page_token": "6969507070261329948",
  "commit_start_time":1618279343,
  "commit_end_time":1623722543,
  "page_size": 10,
  "rule_id":6969410005221015580,
  "user_id": "ou_c26134180ba2611aede183e5e3b531ed"
}
""";
        var result = Deserialize<FeishuNetSdk.Report.PostReportV1TasksQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}