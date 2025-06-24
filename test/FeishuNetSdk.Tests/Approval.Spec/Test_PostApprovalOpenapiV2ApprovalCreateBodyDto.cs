// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalOpenapiV2ApprovalCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建审批定义 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 创建审批定义 请求体
/// <para>接口ID：6907569743420686338</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-store-app-integration/create-an-approval-definition</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUzNyYjL1cjM24SN3IjN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV2ApprovalCreateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "approval_name": "@i18n@approval_name",
    "approval_code": "7C468A54-8745-2245-9675-08B7C63E7A85",
    "description": "@i18n@description",
    "viewers":[
        {
            "type":"TENANT",
            "open_id":"ou_e03053f0541cecc3269d7a9dc34a0b21",
            "user_id":"f7cb567e"
        }
    ],
    "form": {
          "form_content": "[{\"id\":\"user_name\", \"type\": \"input\", \"required\":true, \"name\":\"@i18n@widget1\"}]"
        },
    "node_list": [{
          "id": "START"
        },{
          "id": "node_id",
          "name": "@i18n@node_name",
          "node_type": "AND",
          "approver": [
            {
              "type": "Personal",
              "open_id": "ou_e03053f0541cecc3269d7a9dc34a0b21",
              "user_id": "f7cb567e"
            }
          ],
          "ccer": [
            {
              "type": "Supervisor",
              "open_id": "ou_e03053f0541cecc3269d7a9dc34a0b21",
              "user_id": "f7cb567e"
            }
          ]
        },{
          "id": "END"
        }],
    "settings" : {
          "revert_interval":0
        },
    "config" : {
          "can_update_viewer": false,
          "can_update_form": false,
          "can_update_process": false,
          "can_update_revert": false,
          "help_url":"https://xxx.xxx.xxx"
        },
    "icon": 0,
    "i18n_resources" : [{
          "locale": "zh-CN",
          "texts" : {
              "@i18n@approval_name": "审批名称",
              "@i18n@description": "审批描述",
              "@i18n@widget1": "控件1",
              "@i18n@node_name": "节点名称"
            },
          "is_default": true
        }]
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV2ApprovalCreateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}