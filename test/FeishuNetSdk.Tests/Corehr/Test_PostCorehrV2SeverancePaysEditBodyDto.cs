// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-15
//
// Last Modified By : yxr
// Last Modified On : 2026-11-15
// ************************************************************************
// <copyright file="Test_PostCorehrV2SeverancePaysEditBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 编辑被动解除补偿金信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 编辑被动解除补偿金信息 请求体
/// <para>接口ID：7667872540325759962</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/severance_pay/edit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fseverance_pay%2fedit</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2SeverancePaysEditBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "severance_pay_id": "7660423757252773420",
    "operator_id": "7659617611689510444",
    "update_data": [
        {
            "field_name": "name",
            "value": "Sandy"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2SeverancePaysEditBodyDto>(json);
        Assert.IsNotNull(result);
    }
}