namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取招聘流程信息 响应体
/// <para>接口ID：6964286393804947484</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job_process/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_process%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1JobProcessesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": true,
        "page_token": "7342029494511126794",
        "items": [
            {
                "id": "7383889964737988883",
                "zh_name": "社招流程",
                "en_name": "Social Process",
                "type": 1,
                "stage_list": [
                    {
                        "id": "6793210103211510024",
                        "zh_name": "面试阶段",
                        "en_name": "Interivew",
                        "type": 1
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1JobProcessesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}