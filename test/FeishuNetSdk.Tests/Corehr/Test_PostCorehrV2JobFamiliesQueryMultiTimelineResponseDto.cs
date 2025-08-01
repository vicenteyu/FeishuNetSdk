// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-01
//
// Last Modified By : yxr
// Last Modified On : 2025-08-01
// ************************************************************************
// <copyright file="Test_PostCorehrV2JobFamiliesQueryMultiTimelineResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询指定时间范围序列版本 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询指定时间范围序列版本 响应体
/// <para>接口ID：7473071080241561604</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job_family/query_multi_timeline</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_family%2fquery_multi_timeline</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2JobFamiliesQueryMultiTimelineResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "job_family_version_data": [
                    {
                        "job_family_id": "4719456877659520852",
                        "job_family_version_id": "7238516215202170412",
                        "job_family_names": [
                            {
                                "lang": "zh-CN",
                                "value": "技术序列"
                            }
                        ],
                        "effective_date": "2020-05-01",
                        "expiration_date": "2020-05-02",
                        "active": true,
                        "descriptions": [
                            {
                                "lang": "zh-CN",
                                "value": "负责软件产品设计与开发的序列"
                            }
                        ],
                        "selectable": true,
                        "parent_job_family_id": "4698020757495316313",
                        "pathway_ids": [
                            "4719519211875096301"
                        ],
                        "code": "123456"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2JobFamiliesQueryMultiTimelineResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}