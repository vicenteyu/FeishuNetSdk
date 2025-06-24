// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1TalentOperationLogsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询人才操作记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 查询人才操作记录 请求体
/// <para>接口ID：7098526921012936706</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2ftalent_operation_log%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TalentOperationLogsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "job_id_list": [
        "6949805467799537965"
    ],
    "operator_id_list": [
        "ou_b29276c7c3e2ff4bd3fcfb567ce690e3"
    ],
    "operation_list": [
        1
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1TalentOperationLogsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}