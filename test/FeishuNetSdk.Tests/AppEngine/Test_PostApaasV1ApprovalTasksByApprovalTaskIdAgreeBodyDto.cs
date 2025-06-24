// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApaasV1ApprovalTasksByApprovalTaskIdAgreeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 同意人工任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 同意人工任务 请求体
/// <para>接口ID：7347562540447137793</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/agree</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapproval_task%2fagree</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApprovalTasksByApprovalTaskIdAgreeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id": "1783981209205788",
    "opinion": "同意"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1ApprovalTasksByApprovalTaskIdAgreeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}