namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取绩效结果 请求体
/// <para>接口ID：7000193886257725441</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/performance-v1/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v1%2freview_data%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV1ReviewDatasQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "reviewee_user_id_list":["ou_3245842393d09e9428ad4655da6e30b3"],
    "start_time":"1430425599999",
    "end_time":"1630425599999",
    "stage_types":["leader_review","communication_and_open_result"],
    "semester_id_list":["6992035450862224940"],
    "stage_progress":[0,1,2,3],
    "updated_later_than":"1430425599999"
}
""";
        var result = Deserialize<FeishuNetSdk.Performance.PostPerformanceV1ReviewDatasQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}