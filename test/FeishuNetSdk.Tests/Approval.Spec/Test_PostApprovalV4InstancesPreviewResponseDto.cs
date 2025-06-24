// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalV4InstancesPreviewResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 预览审批流程 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 预览审批流程 响应体
/// <para>接口ID：6995509710095695876</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance/approval-preview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukTM5UjL5ETO14SOxkTN%2fapproval-preview</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4InstancesPreviewResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{ 
    "code":0, 
    "msg":"success", 
    "data": { 
        "preview_nodes":[
            {
                "user_id_list":["ffffffff"],
                "end_cc_id_list":[],
                "node_id":"b078ffd28db767c502ac367053f6e0ac",
                "node_name":"发起",
                "node_type":"",
                "comments":[],
                "custom_node_id":""
            },
            {
                "user_id_list":["ffffffff"],
                "end_cc_id_list":[],
                "node_id":"e6ce10282a3cc3bf4a408feffd678dcf",
                "node_name":"审批",
                "node_type":"AND",
                "comments":[],
                "custom_node_id":"",
                "is_empty_logic":false,
                "is_approver_type_free":false,
                "has_cc_type_free":false
            },
            {
                "user_id_list":[],
                "end_cc_id_list":[],
                "node_id":"b1a326c06d88bf042f73d70f50197905",
                "node_name":"结束",
                "node_type":"",
                "comments":[],
                "custom_node_id":""
             }
         ]
    }        
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.Spec.PostApprovalV4InstancesPreviewResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}