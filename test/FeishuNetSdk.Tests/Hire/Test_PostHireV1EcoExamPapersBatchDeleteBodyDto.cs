// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1EcoExamPapersBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除试卷列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 删除试卷列表 请求体
/// <para>接口ID：7195815976042577922</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_exam_paper/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_exam_paper%2fbatch_delete</para>
/// </summary>
[TestClass]
public class Test_PostHireV1EcoExamPapersBatchDeleteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "account_id": "7147998241542539527",
    "paper_id_list": [
        "7147998241542539526"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1EcoExamPapersBatchDeleteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}