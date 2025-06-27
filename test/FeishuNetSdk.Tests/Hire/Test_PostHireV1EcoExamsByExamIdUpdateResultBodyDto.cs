// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1EcoExamsByExamIdUpdateResultBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 回传笔试结果 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 回传笔试结果 请求体
/// <para>接口ID：7195815979079467009</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_exam/update_result</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_exam%2fupdate_result</para>
/// </summary>
[TestClass]
public class Test_PostHireV1EcoExamsByExamIdUpdateResultBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "result": "60.5",
    "result_time": "1658676234053",
    "report_list": [
        {
            "name": "张三的笔试结果.pdf",
            "url": "https://xxxxx/xxxxxx/xxxx.pdf",
            "answer_time": "1658676234053"
        }
    ],
    "detail_list": [
        {
            "id": "pj001",
            "name": "基本功",
            "result": "优秀"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1EcoExamsByExamIdUpdateResultBodyDto>(json);
        Assert.IsNotNull(result);
    }
}