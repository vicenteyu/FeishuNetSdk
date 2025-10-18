// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-11
//
// Last Modified By : yxr
// Last Modified On : 2025-10-11
// ************************************************************************
// <copyright file="Test_PostCorehrV2PositionsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建岗位信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 创建岗位信息 响应体
/// <para>接口ID：7384280065851113473</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/position/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fposition%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PositionsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "position_id": "12345678"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2PositionsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}