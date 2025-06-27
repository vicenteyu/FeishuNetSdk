// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAttendanceV1UserStatsDatasQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询统计数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 查询统计数据 响应体
/// <para>接口ID：7044467124773568513</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_stats_data/query-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_stats_data%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserStatsDatasQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "user_datas": [
            {
                "name": "小李",
                "user_id": "ec8ddg56",
                "datas": [
                    {
                        "code": "50102",
                        "value": "无需打卡(-), 无需打卡(-)",
                        "features": [
                            {
                                "key": "Abnormal",
                                "value": "false"
                            }
                        ],
                        "title": "姓名",
                        "duration_num": {
                            "day": "1",
                            "half_day": "1",
                            "hour": "1",
                            "half_hour": "1",
                            "minute": "1"
                        }
                    }
                ]
            }
        ],
        "invalid_user_list": [
            "af5ddg73"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.PostAttendanceV1UserStatsDatasQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}