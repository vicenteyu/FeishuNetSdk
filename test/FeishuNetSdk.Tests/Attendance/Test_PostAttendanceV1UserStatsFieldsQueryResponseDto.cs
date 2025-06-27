// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAttendanceV1UserStatsFieldsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询统计表头 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 查询统计表头 响应体
/// <para>接口ID：7044467124773814273</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_stats_data/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_stats_field%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserStatsFieldsQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "",
    "data": {
        "user_stats_field": {
            "fields": [
                {
                    "child_fields": [
                        {
                            "code": "50103",
                            "title": "Employee ID"
                        }
                    ],
                    "code": "501",
                    "title": "Basic info"
                },
                {
                    "child_fields": [
                        {
                            "code": "52108",
                            "title": "Attendance group name"
                        },
                        {
                            "code": "52101",
                            "title": "Required attendance days"
                        },
                        {
                            "code": "52102",
                            "title": "Days of attendance"
                        },
                        {
                            "code": "52104",
                            "time_unit": "Minute",
                            "title": "Required attendance duration"
                        },
                        {
                            "code": "52105",
                            "time_unit": "Minute",
                            "title": "Actual attendance duration"
                        },
                        {
                            "code": "52107",
                            "title": "Overtime hours"
                        }
                    ],
                    "code": "521",
                    "title": "Attendance statistics"
                },
                {
                    "child_fields": [
                        {
                            "code": "52201",
                            "title": "Late in times"
                        },
                        {
                            "code": "52203",
                            "title": "Early out times"
                        },
                        {
                            "code": "52207",
                            "title": "No records"
                        }
                    ],
                    "code": "522",
                    "title": "Abnormal statistics"
                },
                {
                    "child_fields": [
                        {
                            "code": "2021-03-16",
                            "title": "2021-03-16 Tue"
                        },
                        {
                            "code": "2021-03-17",
                            "title": "2021-03-17 Wed"
                        },
                        {
                            "code": "2021-03-18",
                            "title": "2021-03-18 Thu"
                        },
                        {
                            "code": "2021-03-19",
                            "title": "2021-03-19 Fri"
                        },
                        {
                            "code": "2021-03-20",
                            "title": "2021-03-20 Sat"
                        },
                        {
                            "code": "2021-03-21",
                            "title": "2021-03-21 Sun"
                        },
                        {
                            "code": "2021-03-22",
                            "title": "2021-03-22 Mon"
                        },
                        {
                            "code": "2021-03-23",
                            "title": "2021-03-23 Tue"
                        }
                    ],
                    "code": "524",
                    "title": "Daily statistics"
                }
            ],
            "stats_type": "month",
            "user_id": ""
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.PostAttendanceV1UserStatsFieldsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}