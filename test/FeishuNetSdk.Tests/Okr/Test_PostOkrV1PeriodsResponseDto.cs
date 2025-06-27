// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostOkrV1PeriodsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建 OKR 周期 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 创建 OKR 周期 响应体
/// <para>接口ID：7177567881395716124</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/period/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fperiod%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostOkrV1PeriodsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "period_id": "6969864184272078374",
        "start_month": "2022-01",
        "end_month": "2022-01"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.PostOkrV1PeriodsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}