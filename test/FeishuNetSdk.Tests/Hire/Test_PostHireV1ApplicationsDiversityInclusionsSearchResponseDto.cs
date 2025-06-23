namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取申请表附加信息 响应体
/// <para>接口ID：7232192298414292993</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fdiversity_inclusion%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ApplicationsDiversityInclusionsSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "id": "6784008015948283904",
                "application_id": "6784008015948283905",
                "talent_id": "6784008015948283906",
                "source_type": 1,
                "create_time": "1681301987",
                "update_time": "1681301987",
                "di_data": [
                    {
                        "value": "1",
                        "object_attribute": {
                            "title": {
                                "zh_cn": "测试",
                                "en_us": "test"
                            },
                            "description": {
                                "zh_cn": "测试",
                                "en_us": "test"
                            },
                            "data_type": 1,
                            "tags": [
                                1
                            ],
                            "is_fcf_data": true,
                            "is_di_data": true
                        }
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1ApplicationsDiversityInclusionsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}