// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1EvaluationsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取简历评估信息列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取简历评估信息列表 响应体
/// <para>接口ID：7062626037662892033</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/evaluation/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fevaluation%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1EvaluationsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEsInRpbWVzdGFtcCI6MTY0MDc2NTYzMjA4OCwiaWQiOm51bGx9",
        "items": [
            {
                "id": "6875295756292425998",
                "application_id": "6875569957036738823",
                "stage_id": "6784315427607595268",
                "creator_id": "ou_aaf83d1b2c856ead36aa9a38784b9a5c",
                "evaluator_id": "ou_aaf83d1b2c856ead36aa9a38784b9a5c",
                "commit_status": 1,
                "conclusion": 1,
                "content": "这位同学很优秀",
                "create_time": "1600843767338",
                "update_time": "1600843937733"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1EvaluationsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}