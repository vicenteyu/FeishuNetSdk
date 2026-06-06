// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_PostOkrV2ObjectivesByObjectiveIdAlignmentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建目标对齐关系 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 创建目标对齐关系 响应体
/// <para>接口ID：7644764969658289100</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-objective-alignment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-objective-alignment%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostOkrV2ObjectivesByObjectiveIdAlignmentsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "alignment_id": "7342342398472398473"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.PostOkrV2ObjectivesByObjectiveIdAlignmentsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}