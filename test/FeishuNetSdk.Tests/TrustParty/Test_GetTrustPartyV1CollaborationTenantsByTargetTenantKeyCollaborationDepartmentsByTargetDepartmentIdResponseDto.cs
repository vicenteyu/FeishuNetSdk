namespace FeishuNetSdk.Tests.TrustParty;

/// <summary>
/// 测试 获取关联组织部门详情 响应体
/// <para>接口ID：7442539768884674588</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/-collaboraiton-organization/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftrust_party-v1%2fcollaboration_tenant-collaboration_department%2fget</para>
/// </summary>
[TestClass]
public class Test_GetTrustPartyV1CollaborationTenantsByTargetTenantKeyCollaborationDepartmentsByTargetDepartmentIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "target_department": {
            "open_department_id": "od-4e6ac4d14bcd5071a37a39de902c7141",
            "department_id": "902c7141",
            "name": "测试部门",
            "i18n_name": {
                "zh_cn": "zh_cn_name",
                "ja_jp": "ja_jp_name",
                "en_us": "en_name"
            },
            "order": "2000",
            "leaders": [
                {
                    "leader_type": 1,
                    "id": {
                        "user_id": "1dfsads",
                        "open_id": "ou_8b8d8b4e310575fd7e4947cf6f1402ac",
                        "union_id": "on_cad4860e7af114fb4ff6c5d496d1dd76"
                    }
                }
            ],
            "parent_department_id": {
                "department_id": "902c7141",
                "open_department_id": "od-4e6ac4d14bcd5071a37a39de902c7141"
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.TrustParty.GetTrustPartyV1CollaborationTenantsByTargetTenantKeyCollaborationDepartmentsByTargetDepartmentIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}