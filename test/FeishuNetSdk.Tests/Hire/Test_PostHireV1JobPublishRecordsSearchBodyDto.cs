namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取职位广告发布记录 请求体
/// <para>接口ID：7098526921116745729</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_publish_record%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostHireV1JobPublishRecordsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "job_channel_id": "7047318856652261676"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1JobPublishRecordsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}