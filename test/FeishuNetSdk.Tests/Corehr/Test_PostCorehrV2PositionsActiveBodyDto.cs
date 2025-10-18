// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-18
//
// Last Modified By : yxr
// Last Modified On : 2025-10-18
// ************************************************************************
// <copyright file="Test_PostCorehrV2PositionsActiveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 启停用岗位 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 启停用岗位 请求体
/// <para>接口ID：7384280065851129857</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/position/active</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fposition%2factive</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PositionsActiveBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "position_id": "6862995757234914823",
    "active": true,
    "effective_time": "2020-01-01"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2PositionsActiveBodyDto>(json);
        Assert.IsNotNull(result);
    }
}