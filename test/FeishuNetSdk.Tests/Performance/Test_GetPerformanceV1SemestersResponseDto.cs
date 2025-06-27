// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetPerformanceV1SemestersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取周期列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取周期列表 响应体
/// <para>接口ID：7275544940596789251</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/semester_activity/semester/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v1%2fsemester%2flist</para>
/// </summary>
[TestClass]
public class Test_GetPerformanceV1SemestersResponseDto : TestBase
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
                "id": "6992035450862224940",
                "year": 2024,
                "type_group": "Quarter",
                "type": "Q1",
                "name": {
                    "zh-CN": "2024 全年绩效周期",
                    "en-US": "2024 full year semester"
                },
                "progress": "enabled",
                "start_time": "1625068800000",
                "end_time": "1640966399999",
                "create_time": "1625068800000",
                "modify_time": "1625068800000",
                "create_user_id": "ou_ce613028fe74745421f5dc320bb9c709",
                "modify_user_id": "ou_ce613028fe74745421f5dc320bb9c709"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Performance.GetPerformanceV1SemestersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}