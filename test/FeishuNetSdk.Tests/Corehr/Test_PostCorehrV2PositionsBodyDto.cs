// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-11
//
// Last Modified By : yxr
// Last Modified On : 2025-10-11
// ************************************************************************
// <copyright file="Test_PostCorehrV2PositionsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建岗位信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 创建岗位信息 请求体
/// <para>接口ID：7384280065851113473</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/position/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fposition%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PositionsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": "A01234",
    "names": [
        {
            "lang": "zh-CN",
            "value": "张三"
        }
    ],
    "descriptions": [
        {
            "lang": "zh-CN",
            "value": "张三"
        }
    ],
    "job_family_ids": [
        "4719519211875096301"
    ],
    "cost_center_id": "4719519211875096301",
    "job_id": "4719519211875096301",
    "job_level_ids": [
        "4719519211875096301"
    ],
    "employee_type_ids": [
        "4719519211875096301"
    ],
    "job_grade_ids": [
        "4719519211875096301"
    ],
    "work_location_ids": [
        "4719519211875096301"
    ],
    "working_hours_type_id": "4719519211875096301",
    "department_id": "4719519211875096301",
    "direct_leader_id": "4719519211875096301",
    "dotted_line_leader_id": "4719519211875096301",
    "is_key_position": true,
    "effective_time": "2020-05-01",
    "custom_fields": [
        {
            "custom_api_name": "name",
            "value": "\"231\""
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2PositionsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}