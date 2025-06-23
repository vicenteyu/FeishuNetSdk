namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 查看指定三方审批定义 响应体
/// <para>接口ID：7255160068449828892</para>
/// <para>文档地址：https://open.feishu.cn/document/approval-v4/external_approval/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fexternal_approval%2fget</para>
/// </summary>
[TestClass]
public class Test_GetApprovalV4ExternalApprovalsByApprovalCodeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "approval_name": "@i18n@1",
        "approval_code": "permission_test",
        "group_code": "work_group",
        "group_name": "@i18n@2",
        "description": "@i18n@2",
        "external": {
            "biz_name": "@i18n@3",
            "biz_type": "permission",
            "create_link_mobile": "https://applink.feishu.cn/client/mini_program/open?appId=cli_9c90fc38e07a9101&path=pages/approval-form/index?id=9999",
            "create_link_pc": "https://applink.feishu.cn/client/mini_program/open?mode=appCenter&appId=cli_9c90fc38e07a9101&path=pc/pages/create-form/index?id=9999",
            "support_pc": true,
            "support_mobile": true,
            "support_batch_read": true,
            "enable_mark_readed": true,
            "enable_quick_operate": true,
            "action_callback_url": "http://www.feishu.cn/approval/openapi/instanceOperate",
            "action_callback_token": "sdjkljkx9lsadf110",
            "action_callback_key": "gfdqedvsadfgfsd",
            "allow_batch_operate": true,
            "exclude_efficiency_statistics": true
        },
        "viewers": [
            {
                "viewer_type": "USER",
                "viewer_user_id": "19a294c2",
                "viewer_department_id": "od-ac9d697abfa990b715dcc33d58a62a9d"
            }
        ],
        "i18n_resources": [
            {
                "locale": "zh-CN",
                "texts": [
                    {
                        "key": "@i18n@1",
                        "value": "审批定义"
                    }
                ],
                "is_default": true
            }
        ],
        "managers": [
            "19a294c2"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.GetApprovalV4ExternalApprovalsByApprovalCodeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}