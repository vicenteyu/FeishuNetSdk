// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalOpenapiV3ExternalApprovalCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 三方审批定义创建 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 三方审批定义创建 请求体
/// <para>接口ID：6907569744329883649</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/third-party-approval-integration/external-approval-create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDNyYjLyQjM24iM0IjN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV3ExternalApprovalCreateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "approval_name": "@i18n@1",
    "approval_code": "permission_test",
    "group_code": "work_group",
    "group_name": "@i18n@2",
    "external": {
        "create_link_pc": "https://applink.feishu.cn/client/mini_program/open?mode=appCenter&appId=cli_9c90fc38e07a9101&path=pc%2Fpages%2Fcreate-form%2Findex%3Fid%3D9999",
        "create_link_mobile": "https://applink.feishu.cn/client/mini_program/open?appId=cli_9c90fc38e07a9101&path=pages%2Fapproval-form%2Findex%3Fid%3D9999",
        "support_pc": true,
        "support_mobile": true,
        "support_batch_read": false,
        "action_callback_url":"http://feishu.cn/approval/openapi/operate",
        "action_callback_token":"sdjkljkx9lsadf110",
        "action_callback_key":"gfdqedvsadfgfsd",
        "enable_mark_readed": false,
        "enable_quick_operate": false,
        "allow_batch_operate": false
    },
    "i18n_resources":[
     {
        "locale":"zh-CN",
        "is_default":true,
         "texts":{
            "@i18n@1":"people",
             "@i18n@2":"hr",
             "@i18n@3":"HR"
         }
      }
    ],
    "viewers": [
        {
            "viewer_type": "TENANT"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV3ExternalApprovalCreateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}