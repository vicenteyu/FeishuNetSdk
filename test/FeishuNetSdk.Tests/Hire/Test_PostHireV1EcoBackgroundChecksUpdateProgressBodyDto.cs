namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新背调订单进度 请求体
/// <para>接口ID：7195815979079483393</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check/update_progress</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check%2fupdate_progress</para>
/// </summary>
[TestClass]
public class Test_PostHireV1EcoBackgroundChecksUpdateProgressBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "background_check_id": "6931286400470354183",
    "stage_id": "6931286400470354183",
    "stage_en_name": "stage report",
    "stage_name": "阶段报告",
    "stage_time": "1660123456789",
    "result": "通过",
    "report_file_list": [
        {
            "report_name": "阶段报告.pdf",
            "report_url": "https://xxxxx/xxxxxx/xxxx.pdf",
            "report_url_type": 1
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1EcoBackgroundChecksUpdateProgressBodyDto>(json);
        Assert.IsNotNull(result);
    }
}