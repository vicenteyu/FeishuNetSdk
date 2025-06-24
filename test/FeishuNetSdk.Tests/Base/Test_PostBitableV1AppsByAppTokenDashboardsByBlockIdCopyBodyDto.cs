// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostBitableV1AppsByAppTokenDashboardsByBlockIdCopyBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 复制仪表盘 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 复制仪表盘 请求体
/// <para>接口ID：7177650713441812483</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-dashboard/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-dashboard%2fcopy</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenDashboardsByBlockIdCopyBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "New Dashboard"
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenDashboardsByBlockIdCopyBodyDto>(json);
        Assert.IsNotNull(result);
    }
}