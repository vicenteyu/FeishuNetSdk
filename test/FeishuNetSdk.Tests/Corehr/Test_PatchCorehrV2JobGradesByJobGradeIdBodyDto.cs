namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 更新职等 请求体
/// <para>接口ID：7422326822924566530</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job_grade/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_grade%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV2JobGradesByJobGradeIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "grade_order": 9999,
    "code": "A01234",
    "names": [
        {
            "lang": "zh-CN",
            "value": "中文示例"
        }
    ],
    "descriptions": [
        {
            "lang": "zh-CN",
            "value": "中文示例"
        }
    ],
    "active": true
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PatchCorehrV2JobGradesByJobGradeIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}