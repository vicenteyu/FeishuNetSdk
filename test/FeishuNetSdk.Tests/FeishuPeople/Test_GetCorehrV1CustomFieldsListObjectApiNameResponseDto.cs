// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV1CustomFieldsListObjectApiNameResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取飞书人事对象列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 获取飞书人事对象列表 响应体
/// <para>接口ID：7112009113388105756</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/custom_field/list_object_api_name</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcustom_field%2flist_object_api_name</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1CustomFieldsListObjectApiNameResponseDto : TestBase
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
                "object_api_name": "offboarding_info",
                "name": {
                    "zh_cn": "cn",
                    "en_us": "en"
                },
                "is_open": false,
                "create_time": "1644992809",
                "update_time": "1644992809"
            }
        ],
        "has_more": true,
        "page_token": "3"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1CustomFieldsListObjectApiNameResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}