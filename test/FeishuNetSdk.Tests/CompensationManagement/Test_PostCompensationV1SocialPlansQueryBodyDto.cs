// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_PostCompensationV1SocialPlansQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 根据方案ID和生效日期批量查询参保方案 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 根据方案ID和生效日期批量查询参保方案 请求体
/// <para>接口ID：7420038908975431682</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/social_plan/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fsocial_plan%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1SocialPlansQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "plan_ids": [
        "10001"
    ],
    "effective_date": "2024-01-01"
}
""";
        var result = Deserialize<FeishuNetSdk.CompensationManagement.PostCompensationV1SocialPlansQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}