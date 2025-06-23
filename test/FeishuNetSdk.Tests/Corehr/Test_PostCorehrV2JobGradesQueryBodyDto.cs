namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询职等 请求体
/// <para>接口ID：7366602835655720964</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job_grade/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_grade%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2JobGradesQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "ids": [
        "7140964208476371111"
    ],
    "codes": [
        "A1234"
    ],
    "active": true
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2JobGradesQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}