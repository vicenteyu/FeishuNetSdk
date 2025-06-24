// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1TestsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取笔试列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取笔试列表 响应体
/// <para>接口ID：7127207246887796740</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/exam/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftest%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TestsSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "items": [
            {
                "test_id": "6963784391454918956",
                "application_id": "6920544531948800269",
                "talent_id": "6830437484509675522",
                "job_id": "6920544531948800269",
                "test_paper_id": "6963549885526346028",
                "test_paper_name": "数据结构测验",
                "test_paper_source_id": "5",
                "test_paper_source_name": {
                    "zh_cn": "高考全国卷（一）",
                    "en_us": "National Exam 1"
                },
                "reply_status": 1,
                "test_status": 1,
                "test_schedule": {
                    "start_time": "1621390695000",
                    "end_time": "1632839400000"
                },
                "test_complete_time": "1608725989000",
                "report_url_list": [
                    "https://open.feishu.cn/xxx/xxx/result.pdf"
                ],
                "result_detail_list": [
                    {
                        "subject": "定制化报告测验",
                        "result": "合格"
                    }
                ],
                "result_upload_time": "1608725989000",
                "score": "60",
                "score_submit_time": "1608725989000",
                "reviewer": "ou_266ed047ed37f24554e5a0afdbb15556",
                "review_created_at": "1608725989000",
                "created_at": "1608725989000"
            }
        ],
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ=="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1TestsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}