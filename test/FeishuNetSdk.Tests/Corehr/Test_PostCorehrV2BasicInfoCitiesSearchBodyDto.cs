// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2BasicInfoCitiesSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询城市信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询城市信息 请求体
/// <para>接口ID：7301516605753131011</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/location_data/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-city%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2BasicInfoCitiesSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "country_region_subdivision_id_list": [
        "6863326768128853512"
    ],
    "city_id_list": [
        "7316867189968012837"
    ],
    "status_list": [
        1
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2BasicInfoCitiesSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}