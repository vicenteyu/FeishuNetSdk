namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 搜索待入职信息 请求体
/// <para>接口ID：7263303427627270148</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/pre_hire/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PreHiresSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "worker_ids": [
        "A55045"
    ],
    "pre_hire_ids": [
        "7094136522860922112"
    ],
    "person_ids": [
        "7094136522860922112"
    ],
    "onboarding_date_start": "2006-01-02",
    "onboarding_date_end": "2006-01-02",
    "updated_date_start": "2006-01-02",
    "updated_date_end": "2006-01-02",
    "onboarding_location_ids": [
        "7094136522860922112"
    ],
    "onboarding_status": "preboarding",
    "department_ids": [
        "7094136522860922111"
    ],
    "direct_manager_ids": [
        "7094136522860922111"
    ],
    "employee_type_ids": [
        "7094136522860922111"
    ],
    "employee_subtype_ids": [
        "7094136522860922111"
    ],
    "job_family_ids": [
        "7094136522860922111"
    ],
    "key_word": "张三",
    "condition_worker": true,
    "rehire": "to_be_confirmed",
    "fields": [
        "employment_info.department"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2PreHiresSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}