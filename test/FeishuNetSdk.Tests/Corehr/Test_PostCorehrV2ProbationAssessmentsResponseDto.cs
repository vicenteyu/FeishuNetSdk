namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 新增试用期考核信息 响应体
/// <para>接口ID：7254814386694586370</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/probation/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation-assessment%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ProbationAssessmentsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "assessment_ids": [
            "7140964208476371991"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2ProbationAssessmentsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}