// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAilyV1SessionsByAilySessionIdRunsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建运行 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 创建运行 请求体
/// <para>接口ID：7358047310868185092</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/aily_session-run/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2faily_session-run%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAilyV1SessionsByAilySessionIdRunsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "app_id": "spring_449d72db2f__c",
    "skill_id": "skill_6cc6166178ca",
    "skill_input": "{\"key\": \"value\"}",
    "metadata": "{}"
}
""";
        var result = Deserialize<FeishuNetSdk.Aily.PostAilyV1SessionsByAilySessionIdRunsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}