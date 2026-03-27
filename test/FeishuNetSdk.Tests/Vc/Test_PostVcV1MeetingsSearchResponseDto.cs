// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="Test_PostVcV1MeetingsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索会议记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 搜索会议记录 响应体
/// <para>接口ID：7621540721572694970</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostVcV1MeetingsSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "total": 10,
        "has_more": true,
        "items": [
            {
                "id": "6911188411932033028",
                "display_info": "会议名 \n 片段1＜h>搜索词/h>片段2\n 会议时间 | 组织者：组织者姓名 | ID: 会议ID",
                "meta_data": {
                    "app_link": "https://applink.larkoffice.com/*",
                    "avatar": "https://lf-packag*",
                    "description": "会议时间 | 组织者：组织者姓名 | ID：123456789"
                }
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.PostVcV1MeetingsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}