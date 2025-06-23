namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 创建职等 请求体
/// <para>接口ID：7422326822924582914</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job_grade/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_grade%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2JobGradesBodyDto : TestBase
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
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2JobGradesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}