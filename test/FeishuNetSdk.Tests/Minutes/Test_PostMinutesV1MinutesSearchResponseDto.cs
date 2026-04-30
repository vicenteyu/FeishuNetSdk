// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-01
//
// Last Modified By : yxr
// Last Modified On : 2026-05-01
// ************************************************************************
// <copyright file="Test_PostMinutesV1MinutesSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索妙记 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Minutes;

/// <summary>
/// 测试 搜索妙记 响应体
/// <para>接口ID：7633638495471881156</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostMinutesV1MinutesSearchResponseDto : TestBase
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
                "token": "obbcwkkdw885tetaf82pu184",
                "display_info": "2026-03-28 产品<h>周会</h>纪要",
                "meta_data": {
                    "app_link": "https://example.feishu.cn/minutes/xxxxxx",
                    "avatar": "https://p3-lark-file.byteimg.com/img/xxxx.jpg",
                    "description": "产品周会纪要"
                }
            }
        ],
        "has_more": true,
        "page_token": "fcefd50bc6e8026a="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Minutes.PostMinutesV1MinutesSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}