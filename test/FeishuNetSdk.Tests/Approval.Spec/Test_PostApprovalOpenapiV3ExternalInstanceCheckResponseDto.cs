namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 三方审批实例校验 响应体
/// <para>接口ID：6907569745298604034</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/third-party-approval-integration/external-approval-instance-check</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDNyYjL1QjM24SN0IjN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV3ExternalInstanceCheckResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg": "success",
    "data":{
      "diff_times": [
              {
                  "instance_id": "1234234234242423",
                  "update_time": 1591603040000,
                  "tasks": [
                      {
                          "task_id": "112255",
                          "update_time": 0
                      }
                  ]
              }
          ]
      }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV3ExternalInstanceCheckResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}