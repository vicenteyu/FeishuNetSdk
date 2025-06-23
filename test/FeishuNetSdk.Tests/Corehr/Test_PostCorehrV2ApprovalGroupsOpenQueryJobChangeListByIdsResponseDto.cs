namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 批量查询人员调整内容 响应体
/// <para>接口ID：7317581509003788292</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/approval_groups/open_query_job_change_list_by_ids</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fapproval_groups%2fopen_query_job_change_list_by_ids</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ApprovalGroupsOpenQueryJobChangeListByIdsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "job_changes": [
            {
                "job_change_id": "6991776076699549697",
                "employment_id": "ou_a294793e8fa21529f2a60e3e9de45520",
                "transfer_info": {
                    "original_department": "6966236933198579208",
                    "target_department": "6966236933198579208",
                    "target_draft_department": "td_704442734715974602312",
                    "original_department_id_path": [
                        {
                            "department_id": "6974659700705068581",
                            "draft_department_id": "6974659700705068581"
                        }
                    ],
                    "target_department_id_path": [
                        {
                            "department_id": "6974659700705068581",
                            "draft_department_id": "6974659700705068581"
                        }
                    ],
                    "original_direct_manager": "6974641477444060708",
                    "target_direct_manager": "7013619729281713671",
                    "original_job": "6969469398088287751",
                    "target_job": "6969469557836760606",
                    "original_job_family": "6967287547462419975",
                    "target_job_family": "6967287547462419975",
                    "original_job_level": "6972085707674355214",
                    "target_job_level": "6972085707674355214",
                    "original_cost_center_rate": [
                        {
                            "cost_center_id": "6950635856373745165",
                            "rate": 100
                        }
                    ],
                    "target_cost_center_rate": [
                        {
                            "cost_center_id": "6950635856373745165",
                            "rate": 100
                        }
                    ],
                    "original_job_grade": "7289005963599693366",
                    "target_job_grade": "7289005963599693366",
                    "original_position": "7289005963599693367",
                    "target_position": "7289005963599693367",
                    "target_draft_position": "td_7289005963599693367"
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2ApprovalGroupsOpenQueryJobChangeListByIdsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}