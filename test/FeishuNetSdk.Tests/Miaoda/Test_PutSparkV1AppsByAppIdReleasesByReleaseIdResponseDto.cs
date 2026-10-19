// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-10-17
//
// Last Modified By : yxr
// Last Modified On : 2026-10-17
// ************************************************************************
// <copyright file="Test_PutSparkV1AppsByAppIdReleasesByReleaseIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 回写发布节点状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 回写发布节点状态 响应体
/// <para>接口ID：7692846107466222565</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-release/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-release%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutSparkV1AppsByAppIdReleasesByReleaseIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "app_id": "app_4ka4egt4j2y6p",
        "release_id": "7683140375070166555",
        "node_task_id": "evt_7683140375070395931",
        "node": "build",
        "node_status": "APPROVED",
        "result": {
            "approval_url": "https://audit.example.com/tickets/10086",
            "operator": "ou_7d8a6e6df7621556ce0d21922b676706ccs",
            "message": "安全扫描通过，同意发布"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Miaoda.PutSparkV1AppsByAppIdReleasesByReleaseIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}