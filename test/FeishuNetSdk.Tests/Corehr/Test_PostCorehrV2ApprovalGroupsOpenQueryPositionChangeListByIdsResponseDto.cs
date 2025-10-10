// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-11
//
// Last Modified By : yxr
// Last Modified On : 2025-10-11
// ************************************************************************
// <copyright file="Test_PostCorehrV2ApprovalGroupsOpenQueryPositionChangeListByIdsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询岗位调整内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 批量查询岗位调整内容 响应体
/// <para>接口ID：7428890785897234433</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/approval_groups/open_query_position_change_list_by_ids</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fapproval_groups%2fopen_query_position_change_list_by_ids</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ApprovalGroupsOpenQueryPositionChangeListByIdsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "position_changes": [
            {
                "position_change_id": "6991776076699549697",
                "position_id": "6966236933198579208",
                "draft_position_id": "6966236933198579208",
                "position_change_type": "Create",
                "position_adjustment_info": {
                    "original_job_families": [
                        "6974659700705068581"
                    ],
                    "target_job_families": [
                        "6974659700705068581"
                    ],
                    "original_department": "6974659700705068581",
                    "target_department": "6974659700705068581",
                    "target_draft_department": "td_704442734715974602312",
                    "original_cost_center": "6974659700705068581",
                    "target_cost_center": "6974659700705068581",
                    "original_working_hours_type": "6974659700705068581",
                    "target_working_hours_type": "6974659700705068581",
                    "original_job": "6974659700705068581",
                    "target_job": "6974659700705068581",
                    "original_is_key_position": true,
                    "target_is_key_position": true,
                    "original_employee_types": [
                        "6974659700705068581"
                    ],
                    "target_employee_types": [
                        "6974659700705068581"
                    ],
                    "original_names": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ],
                    "target_names": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ],
                    "original_job_grades": [
                        "6974659700705068581"
                    ],
                    "target_job_grades": [
                        "6974659700705068581"
                    ],
                    "original_code": "P00000456",
                    "target_code": "P00000456",
                    "original_job_levels": [
                        "6974659700705068581"
                    ],
                    "target_job_levels": [
                        "6974659700705068581"
                    ],
                    "original_active": true,
                    "target_active": true,
                    "original_direct_leader": "6974659700705068581",
                    "target_direct_leader": "6974659700705068581",
                    "target_draft_direct_leader": "6974659700705068581",
                    "original_work_locations": [
                        "6974659700705068581"
                    ],
                    "target_work_locations": [
                        "6974659700705068581"
                    ],
                    "original_descriptions": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ],
                    "target_descriptions": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ],
                    "original_department_id_paths": [
                        {
                            "department_id": "6974659700705068581",
                            "draft_department_id": "6974659700705068581"
                        }
                    ],
                    "target_department_id_paths": [
                        {
                            "department_id": "6974659700705068581",
                            "draft_department_id": "6974659700705068581"
                        }
                    ],
                    "custom_fields": [
                        {
                            "origin_value": {
                                "custom_api_name": "name",
                                "name": {
                                    "zh_cn": "自定义姓名",
                                    "en_us": "Custom Name"
                                },
                                "type": 1,
                                "value": "\"231\""
                            },
                            "target_value": {
                                "custom_api_name": "name",
                                "name": {
                                    "zh_cn": "自定义姓名",
                                    "en_us": "Custom Name"
                                },
                                "type": 1,
                                "value": "\"231\""
                            }
                        }
                    ]
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2ApprovalGroupsOpenQueryPositionChangeListByIdsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}