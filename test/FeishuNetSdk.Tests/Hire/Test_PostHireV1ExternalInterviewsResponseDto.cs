// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1ExternalInterviewsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建外部面试 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 创建外部面试 响应体
/// <para>接口ID：6992822583076339715</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/create-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_interview%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ExternalInterviewsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "external_interview": {
            "external_application_id": "6960663240925956437",
            "id": "6960663240925956436",
            "participate_status": 1,
            "begin_time": 1618500278638,
            "end_time": 1618500278639,
            "interview_assessments": [
                {
                    "id": "6989181065243969836",
                    "username": "张三",
                    "conclusion": 1,
                    "assessment_dimension_list": [
                        {
                            "score": 99,
                            "option": "选项1",
                            "options": [
                                "选项1"
                            ],
                            "content": "第一次面试记录",
                            "assessment_type": 1,
                            "title": "性格测试",
                            "description": "这是性格测试相关的"
                        }
                    ],
                    "content": "内容输出"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1ExternalInterviewsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}