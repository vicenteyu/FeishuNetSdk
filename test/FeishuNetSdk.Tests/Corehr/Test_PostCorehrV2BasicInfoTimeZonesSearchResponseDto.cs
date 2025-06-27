// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2BasicInfoTimeZonesSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询时区信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询时区信息 响应体
/// <para>接口ID：7424038983966441473</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/basic_info-time_zone/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-time_zone%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2BasicInfoTimeZonesSearchResponseDto : TestBase
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
                "time_zone_id": "6862995813451171342",
                "name": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
                "time_zone_code": "Pacific/Niue",
                "utc_offset": "-660",
                "status": 1
            }
        ],
        "page_token": "6862995813451171342",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2BasicInfoTimeZonesSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}