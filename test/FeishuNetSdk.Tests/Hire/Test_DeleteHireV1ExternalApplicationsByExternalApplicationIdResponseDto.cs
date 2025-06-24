// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DeleteHireV1ExternalApplicationsByExternalApplicationIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除外部投递 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 删除外部投递 响应体
/// <para>接口ID：7215630682033979420</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_application%2fdelete</para>
/// </summary>
[TestClass]
public class Test_DeleteHireV1ExternalApplicationsByExternalApplicationIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "external_application": {
            "id": "6989202908470446380",
            "job_recruitment_type": 1,
            "job_title": "高级Java",
            "resume_source": "lagou",
            "stage": "简历初筛",
            "talent_id": "6960663240925956459",
            "termination_reason": "不合适",
            "delivery_type": 1,
            "modify_time": 1618500278645,
            "termination_type": "HR 主动终止"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.DeleteHireV1ExternalApplicationsByExternalApplicationIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}