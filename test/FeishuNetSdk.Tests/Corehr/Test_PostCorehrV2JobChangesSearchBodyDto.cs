namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 搜索员工异动信息 请求体
/// <para>接口ID：7211423970042150916</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job_change/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_change%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2JobChangesSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employment_ids": [
        "ou_a294793e8fa21529f2a60e3e9de45520"
    ],
    "job_change_ids": [
        "7044427347159746085"
    ],
    "statuses": [
        "Approving"
    ],
    "effective_date_start": "2022-01-01",
    "effective_date_end": "2022-01-01",
    "updated_time_start": "1704084635000",
    "updated_time_end": "1704084635000",
    "target_department_ids": [
        "7269981744640312876"
    ],
    "transfer_type_unique_identifier": [
        "assignment_start_reason_option5"
    ],
    "transfer_reason_unique_identifier": [
        "reason_for_job_change_option_7182520625066475540_7382109467556446228"
    ],
    "exception_statuses": [
        "pending"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2JobChangesSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}