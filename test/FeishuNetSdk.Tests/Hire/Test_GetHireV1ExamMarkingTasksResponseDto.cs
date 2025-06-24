// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1ExamMarkingTasksResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取笔试阅卷任务列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取笔试阅卷任务列表 响应体
/// <para>接口ID：7096308827411120129</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/recruitment-process-follow-up/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexam_marking_task%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1ExamMarkingTasksResponseDto : TestBase
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
        "page_token": "eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ==",
        "items": [
            {
                "id": "6989202908470446380",
                "job_id": "6897921873523247373",
                "talent_id": "7046263097923537196",
                "application_id": "7046315599510833452",
                "activity_status": 1
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1ExamMarkingTasksResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}