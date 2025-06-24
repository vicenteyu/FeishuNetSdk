// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2ProbationAssessmentsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新增试用期考核信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 新增试用期考核信息 请求体
/// <para>接口ID：7254814386694586370</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/probation/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation-assessment%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ProbationAssessmentsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employment_id": "7140964208476371111",
    "assessments": [
        {
            "assessment_status": "completed",
            "assessment_result": "approved",
            "assessment_score": 99.9,
            "assessment_grade": "grade_a",
            "assessment_comment": "超出预期",
            "assessment_detail": "暂无示例",
            "is_final_asssessment": false
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2ProbationAssessmentsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}