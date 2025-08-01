// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-01
//
// Last Modified By : yxr
// Last Modified On : 2025-08-01
// ************************************************************************
// <copyright file="Test_PostCorehrV2JobsQueryMultiTimelineResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询指定时间范围职务版本 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询指定时间范围职务版本 响应体
/// <para>接口ID：7473071080241577988</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job/query_multi_timeline</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob%2fquery_multi_timeline</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2JobsQueryMultiTimelineResponseDto : TestBase
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
                "job_version_data": [
                    {
                        "job_id": "4719456877659520852",
                        "job_version_id": "7238516215202170412",
                        "job_names": [
                            {
                                "lang": "zh-CN",
                                "value": "软件工程师"
                            }
                        ],
                        "effective_date": "2020-05-01",
                        "expiration_date": "2020-05-02",
                        "active": true,
                        "descriptions": [
                            {
                                "lang": "zh-CN",
                                "value": "负责后端开发"
                            }
                        ],
                        "code": "BD38591",
                        "job_titles": [
                            {
                                "lang": "zh-CN",
                                "value": "高级"
                            }
                        ],
                        "job_family_ids": [
                            "4719519211875096301"
                        ],
                        "job_level_ids": [
                            "4719519212005299950"
                        ],
                        "pathway_id": "4719519211875096301",
                        "working_hours_type_id": "6890452208593372679"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2JobsQueryMultiTimelineResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}