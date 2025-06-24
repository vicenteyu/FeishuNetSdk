// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1ApplicationsByApplicationIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取投递信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取投递信息 响应体
/// <para>接口ID：6964286393804849180</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2fget</para>
/// </summary>
[TestClass]
public class Test_GetHireV1ApplicationsByApplicationIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "application": {
            "id": "6949805467799537964",
            "job_id": "6843547872837273223",
            "talent_id": "6843547872837273223",
            "resume_source_id": "6583482347283472832",
            "stage": {
                "id": "614218419274131",
                "zh_name": "面试",
                "en_name": "Interview",
                "type": 1
            },
            "active_status": 1,
            "delivery_type": 1,
            "resume_source_info": {
                "id": "614218419274131",
                "name": {
                    "zh_cn": "测试",
                    "en_us": "test"
                },
                "resume_source_type": 10002
            },
            "website_resume_source": {
                "website_id": "614218419274131",
                "website_name": {
                    "zh_cn": "测试",
                    "en_us": "test"
                },
                "channel": {
                    "channel_id": "777218419274131",
                    "channel_name": {
                        "zh_cn": "测试",
                        "en_us": "test"
                    }
                }
            },
            "talent_attachment_resume_id": "6960663240925956415",
            "create_time": "1632990774278",
            "modify_time": "1634801678103",
            "stage_time_list": [
                {
                    "stage_id": "614218419274131",
                    "enter_time": "1632991542615",
                    "exit_time": "1631509574398"
                }
            ],
            "termination_type": 1,
            "termination_reason_list": [
                "6942778198054125570"
            ],
            "termination_reason_note": "其他投递已入职",
            "application_preferred_city_list": [
                {
                    "code": "1111",
                    "name": {
                        "zh_cn": "测试",
                        "en_us": "test"
                    }
                }
            ],
            "creator_id": "ou_ce613028fe74745421f5dc320bb9c709"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1ApplicationsByApplicationIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}