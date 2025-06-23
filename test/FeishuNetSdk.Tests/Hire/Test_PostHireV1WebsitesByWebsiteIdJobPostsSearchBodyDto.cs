namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 搜索招聘官网下的职位广告列表 请求体
/// <para>接口ID：7021042393814450179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-job_post%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostHireV1WebsitesByWebsiteIdJobPostsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "job_type_id_list": [
        "6791698585114724616"
    ],
    "city_code_list": [
        "CN_1"
    ],
    "job_function_id_list": [
        "101"
    ],
    "subject_id_list": [
        "7220407512049240376"
    ],
    "keyword": "HR",
    "update_start_time": "1618500278663",
    "update_end_time": "1618500278663",
    "create_start_time": "1618500278663",
    "create_end_time": "1618500278663"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1WebsitesByWebsiteIdJobPostsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}