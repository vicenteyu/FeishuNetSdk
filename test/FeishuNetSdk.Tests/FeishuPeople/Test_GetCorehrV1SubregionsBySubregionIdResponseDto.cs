// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV1SubregionsBySubregionIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询单条城市/区域信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 查询单条城市/区域信息 响应体
/// <para>接口ID：7072978219503550465</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/location_data/get-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fsubregion%2fget</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1SubregionsBySubregionIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "subregion": {
            "id": "12",
            "name": [
                {
                    "lang": "zh-CN",
                    "value": "张三"
                }
            ],
            "subdivision_id": "12",
            "superior_subregion_id": "12"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1SubregionsBySubregionIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}