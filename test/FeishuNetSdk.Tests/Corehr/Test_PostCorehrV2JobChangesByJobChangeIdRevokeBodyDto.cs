// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2JobChangesByJobChangeIdRevokeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 撤销异动 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 撤销异动 请求体
/// <para>接口ID：7449328616456585235</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job_change/revoke</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_change%2frevoke</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2JobChangesByJobChangeIdRevokeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "operator_id": "ou_a294793e8fa21529f2a60e3e9de45520"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2JobChangesByJobChangeIdRevokeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}