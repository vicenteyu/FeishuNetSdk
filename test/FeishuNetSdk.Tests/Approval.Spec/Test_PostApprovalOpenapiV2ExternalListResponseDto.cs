// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalOpenapiV2ExternalListResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取三方审批任务状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 获取三方审批任务状态 响应体
/// <para>接口ID：6915007875422568450</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/third-party-approval-integration/external_status</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukjNyYjL5YjM24SO2IjN%2fexternal_status</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV2ExternalListResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "data": [
            {
                "approval_code": "60D0F7A2-052D-49E9-B570-C29C836CDF8E",
                "approval_id": "fwwweffff33111133xxx",
                "instance_id": "29075",
                "status": "PENDING",
                "tasks": [
                    {
                        "id": "310",
                        "status": "PENDING",
                        "update_time": 1621863215000
                    }
                ],
                "update_time": 1621863215000
            }
        ],
        "scroll_id": "DnF1ZXJ5VGhlbkZldGNoCgAAAAAFSe_nFjlFcHhJU2dXVEJlbzRhUDd2MHFEX2cAAAAABUnKKBZ2dkJLRkFHQVRrdTJWTGF3M2JFeENnAAAAAAOGMY0WUS1XNmw3bFlUZ2VORjNVT2cwOWtxUQAAAAADhjGOFlEtVzZsN2xZVGdlTkYzVU9nMDlrcVEAAAAAA8VIKxZ4VEFGaHRHRVE5V0s0ek9lNE9nOWpRAAAAAAQ9zgEWTDRLcUJ4c2VUU21ZRV9FQlRLWmNCQQAAAAAEfNk8Fno4emowUExBUzJTaFhPTkprU2RBaXcAAAAABQpkOxZ4V1drX2M5UVEycW5XUmpvNXJweG13AAAAAAPFSCwWeFRBRmh0R0VROVdLNHpPZTRPZzlqUQAAAAAEPlQ8FmZNc0Rsdm1TU2t5VnFrWjFsYjRhdlE="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV2ExternalListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}