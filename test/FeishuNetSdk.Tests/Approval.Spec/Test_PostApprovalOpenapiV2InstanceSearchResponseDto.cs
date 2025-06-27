// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalOpenapiV2InstanceSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 实例列表查询 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 实例列表查询 响应体
/// <para>接口ID：6907568073251946498</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/approval-search/instance-list-query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQjMxYjL0ITM24CNyEjN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV2InstanceSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "count": 10,
        "instance_list": [
            {
                "approval": {
                    "code": "EB828003-9FFE-4B3F-AA50-2E199E2ED943",
                    "name": "approval",
                    "is_external": true,
                    "external": {
                         "batch_cc_read": false
                    }
                },
                "group": {
                     "external_id": "0004",
                    "name": "groupA"
                },
                "instance": {
                    "code": "EB828003-9FFE-4B3F-AA50-2E199E2ED943",
                    "external_id": "0004_3ED52DC1-AA6C",
                    "user_id": "lwiu098wj",
                    "start_time": 1547654251506,
                    "end_time": 1547654251506,
                    "status": "PENDING",
                    "title": "",
                    "extra": "{}",
                    "serial_id": "201902020001",
                    "link": {
                        "pc_link": "",
                        "mobile_link": ""
                    }
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV2InstanceSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}