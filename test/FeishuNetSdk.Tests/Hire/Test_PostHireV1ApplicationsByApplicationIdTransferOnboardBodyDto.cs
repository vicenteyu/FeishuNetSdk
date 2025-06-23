namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 操作候选人入职 请求体
/// <para>接口ID：6964286393804800028</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/onboard/transfer_onboard</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2ftransfer_onboard</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ApplicationsByApplicationIdTransferOnboardBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "actual_onboard_time": 1616428800000,
    "expected_conversion_time": 1616428800000,
    "job_requirement_id": "6960663240925956402",
    "operator_id": "7326856229396906012",
    "onboard_city_code": "CT_2",
    "department": "6966123381141866028",
    "leader": "7326856229396906012",
    "sequence": "7006234385490345986",
    "level": "6937934036379650311",
    "employee_type": "cSbrHjS5Ogiwq0Zu-cKz1g=="
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1ApplicationsByApplicationIdTransferOnboardBodyDto>(json);
        Assert.IsNotNull(result);
    }
}