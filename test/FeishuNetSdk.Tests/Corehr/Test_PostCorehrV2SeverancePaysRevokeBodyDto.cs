// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-20
//
// Last Modified By : yxr
// Last Modified On : 2026-11-20
// ************************************************************************
// <copyright file="Test_PostCorehrV2SeverancePaysRevokeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 撤销被动解除补偿金业务单 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 撤销被动解除补偿金业务单 请求体
/// <para>接口ID：7709381754305826087</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/severance_pay/revoke</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fseverance_pay%2frevoke</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2SeverancePaysRevokeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "severance_pay_id": "1000000000000000001",
    "operator_id": "1000000000000000002",
    "withdrawn_reason": "补偿金方案调整"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2SeverancePaysRevokeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}