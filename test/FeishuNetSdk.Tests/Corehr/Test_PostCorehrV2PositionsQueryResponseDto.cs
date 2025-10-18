// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_PostCorehrV2PositionsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询岗位信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询岗位信息 响应体
/// <para>接口ID：7384280065851064321</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/position/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fposition%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PositionsQueryResponseDto : TestBase
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
                "position_id": "4692446793125560154",
                "code": "A01234",
                "names": [
                    {
                        "lang": "zh-CN",
                        "value": "高级产品经理"
                    }
                ],
                "descriptions": [
                    {
                        "lang": "zh-CN",
                        "value": "岗位的描述"
                    }
                ],
                "active": true,
                "job_family_id_list": [
                    "4719519211875096301"
                ],
                "cost_center_id": "4719519211875096301",
                "job_id": "4719519211875096302",
                "job_level_id_list": [
                    "4719519211875096301"
                ],
                "employee_type_id_list": [
                    "4719519211875096301"
                ],
                "job_grade_id_list": [
                    "4719519211875096301"
                ],
                "work_location_id_list": [
                    "4719519211875096301"
                ],
                "working_hours_type_id": "4719519211875096301",
                "department_id": "4719519211875096301",
                "direct_leader_id": "4719519211875096301",
                "dotted_line_leader_id": "4719519211875096301",
                "is_key_position": true,
                "effective_time": "2020-05-01",
                "expiration_time": "2020-05-01",
                "custom_fields": [
                    {
                        "custom_api_name": "name",
                        "name": {
                            "zh_cn": "自定义姓名",
                            "en_us": "Custom Name"
                        },
                        "type": 1,
                        "value": "\"231\""
                    }
                ],
                "created_by": "4719519211875096301"
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2PositionsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}