// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-18
//
// Last Modified By : yxr
// Last Modified On : 2025-10-18
// ************************************************************************
// <copyright file="Test_PostCorehrV2PositionsDelPositionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除岗位 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 删除岗位 请求体
/// <para>接口ID：7384280065851097089</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/position/del_position</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fposition%2fdel_position</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PositionsDelPositionBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "position_id": "6862995757234914824"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2PositionsDelPositionBodyDto>(json);
        Assert.IsNotNull(result);
    }
}