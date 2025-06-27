// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2BasicInfoCitiesSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询城市信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询城市信息 响应体
/// <para>接口ID：7301516605753131011</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/location_data/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-city%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2BasicInfoCitiesSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "city_id": "6863333352603125255",
                "name": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
                "country_region_subdivision_id": "6863326262757164551",
                "code": "HRB",
                "subregion_code": "230100",
                "status": 1
            }
        ],
        "page_token": "7316867189967963685",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2BasicInfoCitiesSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}