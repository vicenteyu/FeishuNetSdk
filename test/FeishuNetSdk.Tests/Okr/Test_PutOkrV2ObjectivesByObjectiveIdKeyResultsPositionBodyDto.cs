// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_PutOkrV2ObjectivesByObjectiveIdKeyResultsPositionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 修改关键结果位置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 修改关键结果位置 请求体
/// <para>接口ID：7644764969658485708</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-objective/key_results_position</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-objective%2fkey_results_position</para>
/// </summary>
[TestClass]
public class Test_PutOkrV2ObjectivesByObjectiveIdKeyResultsPositionBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "key_result_ids": [
        "7342342398472398473"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Okr.PutOkrV2ObjectivesByObjectiveIdKeyResultsPositionBodyDto>(json);
        Assert.IsNotNull(result);
    }
}