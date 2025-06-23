namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 搜索试用期信息 请求体
/// <para>接口ID：7254814386694553602</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/probation/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ProbationSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employment_ids": [
        "7140964208476371111"
    ],
    "department_ids": [
        "7140964208476371121"
    ],
    "probation_start_date_start": "2022-05-18",
    "probation_start_date_end": "2022-05-20",
    "probation_expected_end_date_start": "2022-06-20",
    "probation_expected_end_date_end": "2022-07-20",
    "actual_probation_end_date_start": "2022-08-20",
    "actual_probation_end_date_end": "2022-09-20",
    "initiating_time_start": "2022-10-20",
    "initiating_time_end": "2022-11-20",
    "probation_status": "approved",
    "final_assessment_result": "approved",
    "final_assessment_grade": "grade_a"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2ProbationSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}