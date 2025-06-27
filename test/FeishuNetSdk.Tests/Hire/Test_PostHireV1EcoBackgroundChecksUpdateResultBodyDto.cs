// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1EcoBackgroundChecksUpdateResultBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 回传背调订单的最终结果 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 回传背调订单的最终结果 请求体
/// <para>接口ID：7195815979079499777</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check/update_result</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check%2fupdate_result</para>
/// </summary>
[TestClass]
public class Test_PostHireV1EcoBackgroundChecksUpdateResultBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "background_check_id": "6931286400470354183",
    "result": "无差异",
    "result_time": "1660123456789",
    "report_file_list": [
        {
            "report_name": "阶段报告.pdf",
            "report_url": "https://xxxxx/xxxxxx/xxxx.pdf",
            "report_url_type": 1
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1EcoBackgroundChecksUpdateResultBodyDto>(json);
        Assert.IsNotNull(result);
    }
}