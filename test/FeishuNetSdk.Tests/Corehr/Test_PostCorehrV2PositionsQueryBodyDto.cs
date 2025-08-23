// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_PostCorehrV2PositionsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询岗位信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询岗位信息 请求体
/// <para>接口ID：7384280065851064321</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/position/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fposition%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PositionsQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "department_ids": [
        "7094136522860922111"
    ],
    "effective_time": "2020-01-01",
    "active": true,
    "fields": [
        "name"
    ],
    "position_ids": [
        "7094136582860923111"
    ],
    "position_codes": [
        "42232132221241561"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2PositionsQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}