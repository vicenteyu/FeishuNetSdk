// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2ApprovalGroupsOpenQueryDepartmentChangeListByIdsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询部门调整内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 批量查询部门调整内容 响应体
/// <para>接口ID：7317581509003771908</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/approval_groups/open_query_department_change_list_by_ids</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fapproval_groups%2fopen_query_department_change_list_by_ids</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ApprovalGroupsOpenQueryDepartmentChangeListByIdsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "department_changes": [{
            "department_change_id": "6991776076699549697",
            "department_id": "6966236934218579208",
            "draft_department_id": "3346236933198579208",
            "department_change_type": "Modify",
            "reorganization_info": {
                "original_department_names": [{
                    "lang": "zh-CN",
                    "value": "技术研发部"
                }],
                "target_department_names": [{
                    "lang": "zh-CN",
                    "value": "产品技术中心"
                }],
                "original_department_code": "D00000456",
                "target_department_code": "D00000456",
                "original_sub_type": {
                    "enum_name": "division",
                    "display": [{
                        "lang": "zh-CN",
                        "value": "系"
                    }]
                },
                "target_sub_type": {
                    "enum_name": "department",
                    "display": [{
                        "lang": "zh-CN",
                        "value": "部门"
                    }]
                },
                "original_department_manager": "6974648866876573198",
                "target_department_manager": "7013328578351842852",
                "original_descriptions": [{
                    "lang": "zh-CN",
                    "value": "负责公司核心系统的技术研发与维护，专注于后端架构搭建和性能优化"
                }],
                "target_descriptions": [{
                    "lang": "zh-CN",
                    "value": "统筹产品设计与技术研发工作，涵盖从需求分析到系统落地的全流程，推动产品技术一体化发展"
                }],
                "original_cost_center": {
                    "cost_center_id": "6969828847121885087",
                    "name": [{
                        "lang": "zh-CN",
                        "value": "研发成本中心 - 001"
                    }]
                },
                "target_cost_center": {
                    "cost_center_id": "696982884876585087",
                    "name": [{
                        "lang": "zh-CN",
                        "value": "产品技术成本中心 - 002"
                    }]
                },
                "original_is_confidential": true,
                "target_is_confidential": true,
                "original_parent_department_id": "6974659700705068581",
                "target_parent_department_id": "69746597007987678581",
                "draft_target_parent_department_id": "6966236933198579208",
                "original_department_id_path": [{
                    "department_id": "6974612300705068581",
                    "draft_department_id": "6974655643205068581"
                }],
                "target_department_id_path": [{
                    "department_id": "6974634700705068581",
                    "draft_department_id": "6974659700705068581"
                }],
                "original_staffing_mode_option": {
                    "enum_name": "job",
                    "display": [{
                        "lang": "zh-CN",
                        "value": "职务模式"
                    }]
                },
                "target_staffing_mode_option": {
                    "enum_name": "position",
                    "display": [{
                        "lang": "zh-CN",
                        "value": "岗位模式"
                    }]
                },
                "custom_fields": [{
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
                }]
            }
        }]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2ApprovalGroupsOpenQueryDepartmentChangeListByIdsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}