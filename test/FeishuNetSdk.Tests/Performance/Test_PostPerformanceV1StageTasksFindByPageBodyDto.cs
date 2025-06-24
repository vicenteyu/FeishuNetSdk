// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPerformanceV1StageTasksFindByPageBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取周期任务（全部用户） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取周期任务（全部用户） 请求体
/// <para>接口ID：7275704938197237762</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/stage_task/find_by_page</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v1%2fstage_task%2ffind_by_page</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV1StageTasksFindByPageBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "semester_id": "7235911950407352321",
  "task_option_lists": [1, 2, 3],
  "after_time": "1717142243000",
  "before_time": "1717142245000",
  "page_size": 30,
  "page_token": "84I9nKzkGJjwv1FrJ1sIveEE2ij7xnes6nhcmxNOXLaLLe52sFVu8S0NPxRFkMhLFCMutL9a6Eod7kzOqWQeu47R7NWiZEmBKJ93Asg5VZv1oJkrG318reCJlrljfaeR"
}
""";
        var result = Deserialize<FeishuNetSdk.Performance.PostPerformanceV1StageTasksFindByPageBodyDto>(json);
        Assert.IsNotNull(result);
    }
}