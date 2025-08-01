// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-08-01
// ************************************************************************
// <copyright file="Test_PostApprovalV4ExternalApprovalsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建三方审批定义 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 创建三方审批定义 请求体
/// <para>接口ID：7114621541589794819</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/external_approval/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fexternal_approval%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4ExternalApprovalsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "approval_name": "@i18n@d937443c-686f-11f0-aa8c-b6e035aec42e",
    "approval_code": "F46EB460-9476-4789-9524-ECD564291234",
    "group_code": "work_group",
    "group_name": "@i18n@d937444f-686f-11f0-aa8c-b6e035aec42e",
    "external": {
        "create_link_pc": "https://applink.feishu.cn/client/mini_program/open?mode=appCenter&appId=cli_9c90fc38e07a9101&path=pc%2Fpages%2Fcreate-form%2Findex%3Fid%3D9999",
        "create_link_mobile": "https://applink.feishu.cn/client/mini_program/open?appId=cli_9c90fc38e07a9101&path=pages%2Fapproval-form%2Findex%3Fid%3D9999",
        "support_pc": true,
        "support_mobile": true,
        "support_batch_read": false,
        "action_callback_url":"http://feishu.cn/approval/openapi/operate",
        "action_callback_token":"sdjkljkx9lxxxxx",
        "action_callback_key":"gfdqedvsadxxxxx",
        "enable_mark_readed": false
    },
    "i18n_resources":[
     {
        "locale":"zh-CN",
        "is_default":true,
         "texts":[
             {
             "key": "@i18n@d937443c-686f-11f0-aa8c-b6e035aec42e",
             "value":"people"  
            },
            {
             "key": "@i18n@d937444f-686f-11f0-aa8c-b6e035aec42e",
             "value":"hr"  
            }
         ]
      }
    ],
    "viewers": [
        {
            "viewer_type": "TENANT"
        }
    ],
    "managers":["96449fb3"]
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.PostApprovalV4ExternalApprovalsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}