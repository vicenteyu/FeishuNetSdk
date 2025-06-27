// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1JobsByJobIdManagersBatchUpdateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新职位相关人员 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新职位相关人员 响应体
/// <para>接口ID：7098334044387475484</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob-manager%2fbatch_update</para>
/// </summary>
[TestClass]
public class Test_PostHireV1JobsByJobIdManagersBatchUpdateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "job_manager": {
            "id": "1618209327096",
            "recruiter_id": "1612209227096",
            "hiring_manager_id_list": [
                "on_94a1ee5551019f18cd73d9f111898cf2"
            ],
            "assistant_id_list": [
                "on_94a1ee5551019f18cd73d9f111898cf2"
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1JobsByJobIdManagersBatchUpdateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}